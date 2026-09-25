using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WMS_Project.Models;

namespace WMS_Project.Data
{
    public static class Repository
    {
        public static User CurrentUser { get; private set; }

        public static User Login(string username, string password)
        {
            username = (username ?? "").Trim();
            using (var connection = Db.Open())
            {
                User user = null;
                string storedHash = null, storedSalt = null;

                using (var command = new SqlCommand(
                    "SELECT UserId, Username, FullName, Role, PasswordHash, Salt FROM dbo.Users WHERE Username = @u;", connection))
                {
                    command.Parameters.AddWithValue("@u", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                FullName = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                            storedHash = reader.GetString(4);
                            storedSalt = reader.GetString(5);
                        }
                    }
                }

                if (user == null || Db.HashPassword(password ?? "", storedSalt) != storedHash)
                    return null;

                LogAction(connection, user.UserId, "Login");
                CurrentUser = user;
                return user;
            }
        }

        public static void Logout()
        {
            if (CurrentUser == null) return;
            try
            {
                using (var connection = Db.Open())
                {
                    LogAction(connection, CurrentUser.UserId, "Logout");
                }
            }
            finally
            {
                CurrentUser = null;
            }
        }

        private static void LogAction(SqlConnection connection, int userId, string action)
        {
            using (var command = new SqlCommand("INSERT INTO dbo.LoginHistory (UserId, Action) VALUES (@id, @a);", connection))
            {
                command.Parameters.AddWithValue("@id", userId);
                command.Parameters.AddWithValue("@a", action);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetWarehousesTable()
        {
            return RunQuery(@"
SELECT w.WarehouseId,
       w.Code,
       w.Name,
       ISNULL(w.Address, N'')          AS [Address],
       COUNT(i.ItemId)                 AS [Items],
       ISNULL(SUM(i.Quantity), 0)      AS [Units On Hand],
       FORMAT(w.CreatedAt, 'yyyy-MM-dd HH:mm') AS [Created]
FROM dbo.Warehouses w
LEFT JOIN dbo.Items i ON i.WarehouseId = w.WarehouseId
GROUP BY w.WarehouseId, w.Code, w.Name, w.Address, w.CreatedAt
ORDER BY w.Code;");
        }

        public static List<Warehouse> GetWarehouses()
        {
            var list = new List<Warehouse>();
            using (var connection = Db.Open())
            using (var command = new SqlCommand("SELECT WarehouseId, Code, Name, ISNULL(Address, N'') FROM dbo.Warehouses ORDER BY Code;", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Warehouse
                    {
                        WarehouseId = reader.GetInt32(0),
                        Code = reader.GetString(1),
                        Name = reader.GetString(2),
                        Address = reader.GetString(3)
                    });
                }
            }
            return list;
        }

        public static void AddWarehouse(string code, string name, string address)
        {
            code = RequireValue(code, "Warehouse code").ToUpperInvariant();
            name = RequireValue(name, "Warehouse name");
            RunCommand("INSERT INTO dbo.Warehouses (Code, Name, Address) VALUES (@c, @n, @a);",
                duplicateKeyMessage: "Warehouse code " + code + " already exists.",
                parameters: new[] { Param("@c", code), Param("@n", name), Param("@a", NullIfEmpty(address)) });
        }

        public static void UpdateWarehouse(int warehouseId, string code, string name, string address)
        {
            code = RequireValue(code, "Warehouse code").ToUpperInvariant();
            name = RequireValue(name, "Warehouse name");
            RunCommand("UPDATE dbo.Warehouses SET Code = @c, Name = @n, Address = @a WHERE WarehouseId = @id;",
                duplicateKeyMessage: "Warehouse code " + code + " already exists.",
                parameters: new[] { Param("@c", code), Param("@n", name), Param("@a", NullIfEmpty(address)), Param("@id", warehouseId) });
        }

        public static void DeleteWarehouse(int warehouseId)
        {
            int itemCount = Convert.ToInt32(RunScalar(
                "SELECT COUNT(*) FROM dbo.Items WHERE WarehouseId = @id;", Param("@id", warehouseId)));
            if (itemCount > 0)
                throw new InvalidOperationException(
                    "This warehouse still has " + itemCount + " item(s). Delete or move the items first.");

            RunCommand("DELETE FROM dbo.Warehouses WHERE WarehouseId = @id;",
                duplicateKeyMessage: null, parameters: new[] { Param("@id", warehouseId) });
        }

        public static DataTable GetItemsTable(string search, int? warehouseId)
        {
            return RunQuery(@"
SELECT i.ItemId,
       i.WarehouseId,
       i.Sku                     AS [SKU],
       i.Name                    AS [Item Name],
       i.Unit,
       w.Code                    AS [Warehouse],
       i.Quantity,
       i.ReorderLevel            AS [Reorder Level],
       CASE WHEN i.Quantity <= i.ReorderLevel THEN N'Low' ELSE N'OK' END AS [Status],
       FORMAT(ISNULL(i.UpdatedAt, i.CreatedAt), 'yyyy-MM-dd HH:mm')     AS [Last Updated]
FROM dbo.Items i
JOIN dbo.Warehouses w ON w.WarehouseId = i.WarehouseId
WHERE (@search = N'' OR i.Sku LIKE N'%' + @search + N'%' OR i.Name LIKE N'%' + @search + N'%')
  AND (@wh IS NULL OR i.WarehouseId = @wh)
ORDER BY i.Sku, w.Code;",
                Param("@search", (search ?? "").Trim()),
                Param("@wh", warehouseId.HasValue ? (object)warehouseId.Value : DBNull.Value));
        }

        public static void AddItem(string sku, string name, string unit, int warehouseId, int quantity, int reorderLevel)
        {
            sku = RequireValue(sku, "SKU").ToUpperInvariant();
            name = RequireValue(name, "Item name");
            ValidateItemFields(warehouseId, quantity, reorderLevel);

            RunCommand(@"INSERT INTO dbo.Items (Sku, Name, Unit, WarehouseId, Quantity, ReorderLevel)
                      VALUES (@sku, @n, @u, @wh, @q, @r);",
                duplicateKeyMessage: "SKU " + sku + " already exists in that warehouse. Select it in the list and click Update instead.",
                parameters: new[]
                {
                    Param("@sku", sku), Param("@n", name), Param("@u", DefaultUnitIfEmpty(unit)),
                    Param("@wh", warehouseId), Param("@q", quantity), Param("@r", reorderLevel)
                });
        }

        public static void UpdateItem(int itemId, string sku, string name, string unit, int warehouseId, int quantity, int reorderLevel)
        {
            sku = RequireValue(sku, "SKU").ToUpperInvariant();
            name = RequireValue(name, "Item name");
            ValidateItemFields(warehouseId, quantity, reorderLevel);

            RunCommand(@"UPDATE dbo.Items
                      SET Sku = @sku, Name = @n, Unit = @u, WarehouseId = @wh,
                          Quantity = @q, ReorderLevel = @r, UpdatedAt = SYSDATETIME()
                      WHERE ItemId = @id;",
                duplicateKeyMessage: "SKU " + sku + " already exists in that warehouse.",
                parameters: new[]
                {
                    Param("@sku", sku), Param("@n", name), Param("@u", DefaultUnitIfEmpty(unit)),
                    Param("@wh", warehouseId), Param("@q", quantity), Param("@r", reorderLevel), Param("@id", itemId)
                });
        }

        public static void DeleteItem(int itemId)
        {
            RunCommand("DELETE FROM dbo.Items WHERE ItemId = @id;",
                duplicateKeyMessage: null, parameters: new[] { Param("@id", itemId) });
        }

        public static DashboardStats GetDashboardStats()
        {
            var stats = new DashboardStats();
            using (var connection = Db.Open())
            using (var command = new SqlCommand(@"
SELECT (SELECT COUNT(*) FROM dbo.Warehouses),
       (SELECT COUNT(DISTINCT Sku) FROM dbo.Items),
       (SELECT ISNULL(SUM(Quantity), 0) FROM dbo.Items),
       (SELECT COUNT(*) FROM dbo.Items WHERE Quantity <= ReorderLevel);", connection))
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    stats.Warehouses = reader.GetInt32(0);
                    stats.DistinctSkus = reader.GetInt32(1);
                    stats.UnitsOnHand = reader.GetInt32(2);
                    stats.LowStockItems = reader.GetInt32(3);
                }
            }
            return stats;
        }

        public static DataTable GetRecentItemsTable()
        {
            return RunQuery(@"
SELECT TOP 10
       i.Sku      AS [SKU],
       i.Name     AS [Item Name],
       w.Code     AS [Warehouse],
       i.Quantity,
       FORMAT(ISNULL(i.UpdatedAt, i.CreatedAt), 'yyyy-MM-dd HH:mm') AS [Last Updated]
FROM dbo.Items i
JOIN dbo.Warehouses w ON w.WarehouseId = i.WarehouseId
ORDER BY ISNULL(i.UpdatedAt, i.CreatedAt) DESC;");
        }

        private static SqlParameter Param(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        private static DataTable RunQuery(string sql, params SqlParameter[] parameters)
        {
            using (var connection = Db.Open())
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddRange(parameters);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private static object RunScalar(string sql, params SqlParameter[] parameters)
        {
            using (var connection = Db.Open())
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }

        private static void RunCommand(string sql, string duplicateKeyMessage, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = Db.Open())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                if ((ex.Number == 2627 || ex.Number == 2601) && duplicateKeyMessage != null)
                    throw new InvalidOperationException(duplicateKeyMessage);
                throw;
            }
        }

        private static void ValidateItemFields(int warehouseId, int quantity, int reorderLevel)
        {
            if (warehouseId <= 0) throw new InvalidOperationException("Please choose a warehouse. Add one on the Warehouses page first.");
            if (quantity < 0) throw new InvalidOperationException("Quantity cannot be negative.");
            if (reorderLevel < 0) throw new InvalidOperationException("Reorder level cannot be negative.");
        }

        private static string RequireValue(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new InvalidOperationException(fieldName + " is required.");
            return value.Trim();
        }

        private static object NullIfEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? (object)DBNull.Value : value.Trim();
        }

        private static string DefaultUnitIfEmpty(string unit)
        {
            return string.IsNullOrWhiteSpace(unit) ? "pcs" : unit.Trim();
        }
    }
}
