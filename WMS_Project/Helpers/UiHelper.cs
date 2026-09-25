using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMS_Project.Data;
using WMS_Project.Models;

namespace WMS_Project.Helpers
{
    public interface IRefreshable
    {
        void RefreshData();
    }

    public static class UiHelper
    {
        public static readonly Color HeaderBlue = Color.FromArgb(21, 101, 192);
        public static readonly Color SelectionBlue = Color.FromArgb(214, 230, 251);
        public static readonly Color AltRowBlue = Color.FromArgb(245, 249, 255);
        public static readonly Color GridLineBlue = Color.FromArgb(225, 233, 245);
        public static readonly Color TextDark = Color.FromArgb(33, 43, 54);
        public static readonly Color LowStockBack = Color.FromArgb(255, 235, 238);
        public static readonly Color LowStockText = Color.FromArgb(183, 28, 28);

        public static void StyleGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.RowHeadersVisible = false;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = GridLineBlue;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderBlue;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderBlue;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            grid.RowTemplate.Height = 32;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = TextDark;
            grid.DefaultCellStyle.SelectionBackColor = SelectionBlue;
            grid.DefaultCellStyle.SelectionForeColor = TextDark;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            grid.AlternatingRowsDefaultCellStyle.BackColor = AltRowBlue;
        }

        public static void HideColumns(DataGridView grid, params string[] columnNames)
        {
            foreach (string name in columnNames)
            {
                if (grid.Columns.Contains(name)) grid.Columns[name].Visible = false;
            }
        }

        public static void HighlightLowStock(DataGridView grid)
        {
            if (!grid.Columns.Contains("Status")) return;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (Convert.ToString(row.Cells["Status"].Value) == "Low")
                {
                    row.DefaultCellStyle.BackColor = LowStockBack;
                    row.DefaultCellStyle.ForeColor = LowStockText;
                }
            }
        }

        public static void BindWarehouses(ComboBox combo, bool includeAll)
        {
            object previouslySelected = combo.SelectedValue;

            var list = new List<Warehouse>();
            if (includeAll) list.Add(new Warehouse { WarehouseId = 0, Name = "All warehouses" });
            list.AddRange(Repository.GetWarehouses());

            combo.DataSource = null;
            combo.DisplayMember = "DisplayName";
            combo.ValueMember = "WarehouseId";
            combo.DataSource = list;

            if (previouslySelected != null) combo.SelectedValue = previouslySelected;
            if (combo.SelectedIndex < 0 && combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        public static int SelectedId(ComboBox combo)
        {
            return combo.SelectedValue is int ? (int)combo.SelectedValue : 0;
        }

        public static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Warehouse Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Warehouse Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowNotConnected(string feature)
        {
            MessageBox.Show(feature + " is not connected to the database yet.\n\n" +
                "This screen is a UI preview. The function will be added in a later version.",
                "Coming soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SelectFirst(params ComboBox[] combos)
        {
            foreach (ComboBox combo in combos)
            {
                if (combo.Items.Count > 0 && combo.SelectedIndex < 0) combo.SelectedIndex = 0;
            }
        }

        public static bool Confirm(string message)
        {
            return MessageBox.Show(message, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
