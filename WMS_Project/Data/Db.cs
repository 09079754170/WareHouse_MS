using System;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;

namespace WMS_Project.Data
{
    public static class Db
    {
        public const string Server = @"(localdb)\MSSQLLocalDB";
        public const string DatabaseName = "WarehouseDB";

        public static string ConnectionString
        {
            get { return BuildConnectionString(DatabaseName); }
        }

        private static string BuildConnectionString(string database)
        {
            return "Server=" + Server + ";Database=" + database +
                   ";Integrated Security=True;TrustServerCertificate=True;Connect Timeout=30;";
        }

        public static SqlConnection Open()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void EnsureDatabase()
        {
            using (var master = new SqlConnection(BuildConnectionString("master")))
            {
                master.Open();
                RunSql(master, "IF DB_ID(N'" + DatabaseName + "') IS NULL CREATE DATABASE [" + DatabaseName + "];");
            }
            SqlConnection.ClearAllPools();

            using (var connection = Open())
            {
                RunSql(connection, CreateTablesSql);

                object userCount = new SqlCommand("SELECT COUNT(*) FROM dbo.Users;", connection).ExecuteScalar();
                if (Convert.ToInt32(userCount) == 0)
                {
                    InsertUser(connection, "admin", "admin123", "Admin User", "Administrator");
                    InsertUser(connection, "staff", "staff123", "Warehouse Staff", "Staff");
                }
            }
        }

        private static void RunSql(SqlConnection connection, string sql)
        {
            using (var command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public static void InsertUser(SqlConnection connection, string username, string password, string fullName, string role)
        {
            string salt = NewSalt();
            using (var command = new SqlCommand(
                "INSERT INTO dbo.Users (Username, PasswordHash, Salt, FullName, Role) VALUES (@u, @h, @s, @f, @r);", connection))
            {
                command.Parameters.AddWithValue("@u", username);
                command.Parameters.AddWithValue("@h", HashPassword(password, salt));
                command.Parameters.AddWithValue("@s", salt);
                command.Parameters.AddWithValue("@f", fullName);
                command.Parameters.AddWithValue("@r", role);
                command.ExecuteNonQuery();
            }
        }

        public static string NewSalt()
        {
            var bytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return Convert.ToBase64String(bytes);
        }

        public static string HashPassword(string password, string salt)
        {
            using (var sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(salt + ":" + password));
                return Convert.ToBase64String(hash);
            }
        }

        private const string CreateTablesSql = @"
IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    UserId       INT IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash NVARCHAR(128) NOT NULL,
    Salt         NVARCHAR(64)  NOT NULL,
    FullName     NVARCHAR(100) NOT NULL,
    Role         NVARCHAR(30)  NOT NULL,
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);

IF OBJECT_ID(N'dbo.LoginHistory', N'U') IS NULL
CREATE TABLE dbo.LoginHistory (
    LoginHistoryId INT IDENTITY(1,1) PRIMARY KEY,
    UserId         INT          NOT NULL REFERENCES dbo.Users(UserId),
    Action         NVARCHAR(10) NOT NULL,
    ActionAt       DATETIME2    NOT NULL DEFAULT SYSDATETIME()
);

IF OBJECT_ID(N'dbo.Warehouses', N'U') IS NULL
CREATE TABLE dbo.Warehouses (
    WarehouseId INT IDENTITY(1,1) PRIMARY KEY,
    Code        NVARCHAR(20)  NOT NULL UNIQUE,
    Name        NVARCHAR(100) NOT NULL,
    Address     NVARCHAR(200) NULL,
    CreatedAt   DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);

IF OBJECT_ID(N'dbo.Items', N'U') IS NULL
CREATE TABLE dbo.Items (
    ItemId       INT IDENTITY(1,1) PRIMARY KEY,
    Sku          NVARCHAR(30)  NOT NULL,
    Name         NVARCHAR(100) NOT NULL,
    Unit         NVARCHAR(20)  NOT NULL DEFAULT N'pcs',
    WarehouseId  INT           NOT NULL REFERENCES dbo.Warehouses(WarehouseId),
    Quantity     INT           NOT NULL DEFAULT 0 CHECK (Quantity >= 0),
    ReorderLevel INT           NOT NULL DEFAULT 0 CHECK (ReorderLevel >= 0),
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    UpdatedAt    DATETIME2     NULL,
    CONSTRAINT UQ_Items_Sku_Warehouse UNIQUE (Sku, WarehouseId)
);";
    }
}
