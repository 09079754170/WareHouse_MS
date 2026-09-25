using System;
using System.Windows.Forms;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class DispatchControl : UserControl, IRefreshable
    {
        public DispatchControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridDispatches);
            UiHelper.SelectFirst(cboCarrier, cboFilterStatus);
            dtpDate.Value = DateTime.Today;
        }

        public void RefreshData()
        {
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Dispatching");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            UiHelper.ShowNotConnected("Printing delivery notes");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            txtTracking.Clear();
            txtPlate.Clear();
            txtDriver.Clear();
            cboCarrier.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;
            txtTracking.Focus();
        }
    }
}
