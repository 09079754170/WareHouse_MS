using System.Windows.Forms;
using WMS_Project.Data;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class DashboardControl : UserControl, IRefreshable
    {
        public DashboardControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridRecent);
        }

        public void RefreshData()
        {
            var stats = Repository.GetDashboardStats();
            lblWarehousesValue.Text = stats.Warehouses.ToString("N0");
            lblSkusValue.Text = stats.DistinctSkus.ToString("N0");
            lblUnitsValue.Text = stats.UnitsOnHand.ToString("N0");
            lblLowStockValue.Text = stats.LowStockItems.ToString("N0");

            var recent = Repository.GetRecentItemsTable();
            gridRecent.DataSource = recent;
            gridRecent.Visible = recent.Rows.Count > 0;
            lblNoItems.Visible = recent.Rows.Count == 0;
        }
    }
}
