namespace WMS_Project.Models
{

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }

    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string DisplayName
        {
            get { return WarehouseId == 0 ? Name : Code + " - " + Name; }
        }
    }

    public class DashboardStats
    {
        public int Warehouses { get; set; }
        public int DistinctSkus { get; set; }
        public int UnitsOnHand { get; set; }
        public int LowStockItems { get; set; }
    }
}
