using System;
using System.Windows.Forms;
using WMS_Project.Data;
using WMS_Project.Helpers;

namespace WMS_Project.Views
{
    public partial class ItemsControl : UserControl, IRefreshable
    {
        private int selectedItemId;

        private bool loading;

        public ItemsControl()
        {
            InitializeComponent();
            UiHelper.StyleGrid(gridItems);
        }

        public void RefreshData()
        {
            loading = true;
            UiHelper.BindWarehouses(cboWarehouse, false);
            UiHelper.BindWarehouses(cboFilterWarehouse, true);
            loading = false;
            LoadItems();
        }

        private void LoadItems()
        {
            int filterId = UiHelper.SelectedId(cboFilterWarehouse);
            gridItems.DataSource = Repository.GetItemsTable(txtSearch.Text, filterId == 0 ? (int?)null : filterId);
            UiHelper.HideColumns(gridItems, "ItemId", "WarehouseId");
            lblCount.Text = gridItems.Rows.Count + " item(s)";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Repository.AddItem(txtSku.Text, txtName.Text, txtUnit.Text,
                    UiHelper.SelectedId(cboWarehouse), (int)numQuantity.Value, (int)numReorder.Value);
                UiHelper.ShowInfo("Item saved to the database.");
                ClearForm();
                LoadItems();
            }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                UiHelper.ShowInfo("Click an item in the list first.");
                return;
            }
            try
            {
                Repository.UpdateItem(selectedItemId, txtSku.Text, txtName.Text, txtUnit.Text,
                    UiHelper.SelectedId(cboWarehouse), (int)numQuantity.Value, (int)numReorder.Value);
                UiHelper.ShowInfo("Item updated.");
                ClearForm();
                LoadItems();
            }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                UiHelper.ShowInfo("Click an item in the list first.");
                return;
            }
            if (!UiHelper.Confirm("Delete item " + txtSku.Text + "?")) return;

            try
            {
                Repository.DeleteItem(selectedItemId);
                ClearForm();
                LoadItems();
            }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (loading) return;
            try { LoadItems(); }
            catch (Exception ex) { UiHelper.ShowError(ex); }
        }

        private void gridItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = gridItems.Rows[e.RowIndex];

            selectedItemId = Convert.ToInt32(row.Cells["ItemId"].Value);
            txtSku.Text = Convert.ToString(row.Cells["SKU"].Value);
            txtName.Text = Convert.ToString(row.Cells["Item Name"].Value);
            txtUnit.Text = Convert.ToString(row.Cells["Unit"].Value);
            cboWarehouse.SelectedValue = Convert.ToInt32(row.Cells["WarehouseId"].Value);
            numQuantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
            numReorder.Value = Convert.ToInt32(row.Cells["Reorder Level"].Value);
            btnAdd.Enabled = false;
        }

        private void gridItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UiHelper.HighlightLowStock(gridItems);
        }

        private void ClearForm()
        {
            selectedItemId = 0;
            txtSku.Clear();
            txtName.Clear();
            txtUnit.Clear();
            numQuantity.Value = 0;
            numReorder.Value = 0;
            btnAdd.Enabled = true;
            gridItems.ClearSelection();
            txtSku.Focus();
        }
    }
}
