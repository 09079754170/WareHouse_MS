using System;
using System.Windows.Forms;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class ReceivingControl : UserControl, IRefreshable
    {
        public ReceivingControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridReceipts);
            dtpDate.Value = DateTime.Today;
        }

        public void RefreshData()
        {
            UiHelper.BindWarehouses(cboWarehouse, false);
            UiHelper.BindWarehouses(cboFilterWarehouse, true);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Receiving stock");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReference.Clear();
            txtSupplier.Clear();
            txtSku.Clear();
            txtRemarks.Clear();
            numQuantity.Value = 0;
            dtpDate.Value = DateTime.Today;
            txtReference.Focus();
        }

        private void lblPreviewNotice_Click(object sender, EventArgs e)
        {

        }
    }
}
