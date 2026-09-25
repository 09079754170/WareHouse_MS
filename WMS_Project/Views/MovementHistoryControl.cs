using System;
using System.Windows.Forms;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class MovementHistoryControl : UserControl, IRefreshable
    {
        public MovementHistoryControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridMovements);
            UiHelper.SelectFirst(cboType);
            ResetDates();
        }

        public void RefreshData()
        {
            UiHelper.BindWarehouses(cboWarehouse, true);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Movement history");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Exporting movement history");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDates();
            cboType.SelectedIndex = 0;
            if (cboWarehouse.Items.Count > 0) cboWarehouse.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void ResetDates()
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
        }
    }
}
