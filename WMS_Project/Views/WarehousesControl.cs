using System;
using System.Windows.Forms;
using WMS_Project.Data;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class WarehousesControl : UserControl, IRefreshable
    {
        private int selectedWarehouseId;

        public WarehousesControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridWarehouses);
        }

        public void RefreshData()
        {
            gridWarehouses.DataSource = Repository.GetWarehousesTable();
            UiHelper.HideColumns(gridWarehouses, "WarehouseId");
            lblListTitle.Text = "Warehouses (" + gridWarehouses.Rows.Count + ")";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Repository.AddWarehouse(txtCode.Text, txtName.Text, txtAddress.Text);
                UiHelper.ShowInfo("Warehouse saved.");
                ClearForm();
                RefreshData();
            }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedWarehouseId == 0)
            {
                UiHelper.ShowInfo("Click a warehouse in the list first.");
                return;
            }
            try
            {
                Repository.UpdateWarehouse(selectedWarehouseId, txtCode.Text, txtName.Text, txtAddress.Text);
                UiHelper.ShowInfo("Warehouse updated.");
                ClearForm();
                RefreshData();
            }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedWarehouseId == 0)
            {
                UiHelper.ShowInfo("Click a warehouse in the list first.");
                return;
            }
            if (!UiHelper.Confirm("Delete warehouse " + txtCode.Text + "?")) return;

            try
            {
                Repository.DeleteWarehouse(selectedWarehouseId);
                ClearForm();
                RefreshData();
            }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void gridWarehouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = gridWarehouses.Rows[e.RowIndex];

            selectedWarehouseId = Convert.ToInt32(row.Cells["WarehouseId"].Value);
            txtCode.Text = Convert.ToString(row.Cells["Code"].Value);
            txtName.Text = Convert.ToString(row.Cells["Name"].Value);
            txtAddress.Text = Convert.ToString(row.Cells["Address"].Value);
            lblSelected.Text = "Editing: " + txtCode.Text;
        }

        private void ClearForm()
        {
            selectedWarehouseId = 0;
            txtCode.Clear();
            txtName.Clear();
            txtAddress.Clear();
            lblSelected.Text = "Tip: click a row below to edit it.";
            gridWarehouses.ClearSelection();
            txtCode.Focus();
        }
    }
}
