using System;
using System.Windows.Forms;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class PickingControl : UserControl, IRefreshable
    {
        public PickingControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridOrders);
            UiHelper.SelectFirst(cboPriority, cboPacking, cboFilterStatus);
            dtpDueDate.Value = DateTime.Today;
        }

        public void RefreshData()
        {
            UiHelper.BindWarehouses(cboWarehouse, false);
            UiHelper.BindWarehouses(cboFilterWarehouse, true);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Creating pick lists");
        }

        private void btnMarkPicked_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Marking orders as picked");
        }

        private void btnMarkPacked_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Marking orders as packed");
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Cancelling orders");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderNo.Clear();
            txtCustomer.Clear();
            txtSku.Clear();
            numQuantity.Value = 0;
            cboPriority.SelectedIndex = 0;
            cboPacking.SelectedIndex = 0;
            dtpDueDate.Value = DateTime.Today;
            txtOrderNo.Focus();
        }
    }
}
