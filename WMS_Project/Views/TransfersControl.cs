using System;
using System.Windows.Forms;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class TransfersControl : UserControl, IRefreshable
    {
        public TransfersControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridTransfers);
            UiHelper.SelectFirst(cboFilterStatus);
            dtpDate.Value = DateTime.Today;
        }

        public void RefreshData()
        {
            UiHelper.BindWarehouses(cboFromWarehouse, false);
            UiHelper.BindWarehouses(cboToWarehouse, false);
            UiHelper.BindWarehouses(cboFilterWarehouse, true);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Stock transfers");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSku.Clear();
            txtRemarks.Clear();
            numQuantity.Value = 0;
            lblAvailable.Text = "-";
            dtpDate.Value = DateTime.Today;
            txtSku.Focus();
        }
    }
}
