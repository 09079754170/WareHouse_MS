using System;
using System.Windows.Forms;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class StockMonitoringControl : UserControl, IRefreshable
    {
        public StockMonitoringControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridStock);
            UiHelper.SelectFirst(cboFilterStatus);
        }

        public void RefreshData()
        {
            UiHelper.BindWarehouses(cboFilterWarehouse, true);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Exporting stock levels");
        }
    }
}
