namespace WMS_Project.Views
{
    partial class StockMonitoringControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.cardTotal = new System.Windows.Forms.Panel();
            this.cardTotalAccent = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.cardInStock = new System.Windows.Forms.Panel();
            this.cardInStockAccent = new System.Windows.Forms.Panel();
            this.lblInStockCaption = new System.Windows.Forms.Label();
            this.lblInStockValue = new System.Windows.Forms.Label();
            this.cardLow = new System.Windows.Forms.Panel();
            this.cardLowAccent = new System.Windows.Forms.Panel();
            this.lblLowCaption = new System.Windows.Forms.Label();
            this.lblLowValue = new System.Windows.Forms.Label();
            this.cardOut = new System.Windows.Forms.Panel();
            this.cardOutAccent = new System.Windows.Forms.Panel();
            this.lblOutCaption = new System.Windows.Forms.Label();
            this.lblOutValue = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterWarehouse = new System.Windows.Forms.Label();
            this.cboFilterWarehouse = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.colSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTotal.SuspendLayout();
            this.cardInStock.SuspendLayout();
            this.cardLow.SuspendLayout();
            this.cardOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.Controls.Add(this.cardTotalAccent);
            this.cardTotal.Controls.Add(this.lblTotalCaption);
            this.cardTotal.Controls.Add(this.lblTotalValue);
            this.cardTotal.Location = new System.Drawing.Point(20, 48);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(200, 100);
            this.cardTotal.TabIndex = 1;
            // 
            // cardTotalAccent
            // 
            this.cardTotalAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.cardTotalAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardTotalAccent.Location = new System.Drawing.Point(0, 0);
            this.cardTotalAccent.Name = "cardTotalAccent";
            this.cardTotalAccent.Size = new System.Drawing.Size(200, 4);
            this.cardTotalAccent.TabIndex = 0;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 20);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(82, 21);
            this.lblTotalCaption.TabIndex = 1;
            this.lblTotalCaption.Text = "Total SKUs";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblTotalValue.Location = new System.Drawing.Point(12, 42);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(46, 54);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "0";
            // 
            // cardInStock
            // 
            this.cardInStock.BackColor = System.Drawing.Color.White;
            this.cardInStock.Controls.Add(this.cardInStockAccent);
            this.cardInStock.Controls.Add(this.lblInStockCaption);
            this.cardInStock.Controls.Add(this.lblInStockValue);
            this.cardInStock.Location = new System.Drawing.Point(235, 48);
            this.cardInStock.Name = "cardInStock";
            this.cardInStock.Size = new System.Drawing.Size(200, 100);
            this.cardInStock.TabIndex = 2;
            // 
            // cardInStockAccent
            // 
            this.cardInStockAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.cardInStockAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardInStockAccent.Location = new System.Drawing.Point(0, 0);
            this.cardInStockAccent.Name = "cardInStockAccent";
            this.cardInStockAccent.Size = new System.Drawing.Size(200, 4);
            this.cardInStockAccent.TabIndex = 0;
            // 
            // lblInStockCaption
            // 
            this.lblInStockCaption.AutoSize = true;
            this.lblInStockCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInStockCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblInStockCaption.Location = new System.Drawing.Point(16, 20);
            this.lblInStockCaption.Name = "lblInStockCaption";
            this.lblInStockCaption.Size = new System.Drawing.Size(63, 21);
            this.lblInStockCaption.TabIndex = 1;
            this.lblInStockCaption.Text = "In stock";
            // 
            // lblInStockValue
            // 
            this.lblInStockValue.AutoSize = true;
            this.lblInStockValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblInStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblInStockValue.Location = new System.Drawing.Point(12, 42);
            this.lblInStockValue.Name = "lblInStockValue";
            this.lblInStockValue.Size = new System.Drawing.Size(46, 54);
            this.lblInStockValue.TabIndex = 2;
            this.lblInStockValue.Text = "0";
            // 
            // cardLow
            // 
            this.cardLow.BackColor = System.Drawing.Color.White;
            this.cardLow.Controls.Add(this.cardLowAccent);
            this.cardLow.Controls.Add(this.lblLowCaption);
            this.cardLow.Controls.Add(this.lblLowValue);
            this.cardLow.Location = new System.Drawing.Point(450, 48);
            this.cardLow.Name = "cardLow";
            this.cardLow.Size = new System.Drawing.Size(200, 100);
            this.cardLow.TabIndex = 3;
            // 
            // cardLowAccent
            // 
            this.cardLowAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.cardLowAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardLowAccent.Location = new System.Drawing.Point(0, 0);
            this.cardLowAccent.Name = "cardLowAccent";
            this.cardLowAccent.Size = new System.Drawing.Size(200, 4);
            this.cardLowAccent.TabIndex = 0;
            // 
            // lblLowCaption
            // 
            this.lblLowCaption.AutoSize = true;
            this.lblLowCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLowCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLowCaption.Location = new System.Drawing.Point(16, 20);
            this.lblLowCaption.Name = "lblLowCaption";
            this.lblLowCaption.Size = new System.Drawing.Size(79, 21);
            this.lblLowCaption.TabIndex = 1;
            this.lblLowCaption.Text = "Low stock";
            // 
            // lblLowValue
            // 
            this.lblLowValue.AutoSize = true;
            this.lblLowValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLowValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblLowValue.Location = new System.Drawing.Point(12, 42);
            this.lblLowValue.Name = "lblLowValue";
            this.lblLowValue.Size = new System.Drawing.Size(46, 54);
            this.lblLowValue.TabIndex = 2;
            this.lblLowValue.Text = "0";
            // 
            // cardOut
            // 
            this.cardOut.BackColor = System.Drawing.Color.White;
            this.cardOut.Controls.Add(this.cardOutAccent);
            this.cardOut.Controls.Add(this.lblOutCaption);
            this.cardOut.Controls.Add(this.lblOutValue);
            this.cardOut.Location = new System.Drawing.Point(665, 48);
            this.cardOut.Name = "cardOut";
            this.cardOut.Size = new System.Drawing.Size(200, 100);
            this.cardOut.TabIndex = 4;
            // 
            // cardOutAccent
            // 
            this.cardOutAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cardOutAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardOutAccent.Location = new System.Drawing.Point(0, 0);
            this.cardOutAccent.Name = "cardOutAccent";
            this.cardOutAccent.Size = new System.Drawing.Size(200, 4);
            this.cardOutAccent.TabIndex = 0;
            // 
            // lblOutCaption
            // 
            this.lblOutCaption.AutoSize = true;
            this.lblOutCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblOutCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblOutCaption.Location = new System.Drawing.Point(16, 20);
            this.lblOutCaption.Name = "lblOutCaption";
            this.lblOutCaption.Size = new System.Drawing.Size(94, 21);
            this.lblOutCaption.TabIndex = 1;
            this.lblOutCaption.Text = "Out of stock";
            // 
            // lblOutValue
            // 
            this.lblOutValue.AutoSize = true;
            this.lblOutValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblOutValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblOutValue.Location = new System.Drawing.Point(12, 42);
            this.lblOutValue.Name = "lblOutValue";
            this.lblOutValue.Size = new System.Drawing.Size(46, 54);
            this.lblOutValue.TabIndex = 2;
            this.lblOutValue.Text = "0";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblSearch.Location = new System.Drawing.Point(22, 172);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 21);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 168);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 30);
            this.txtSearch.TabIndex = 6;
            // 
            // lblFilterWarehouse
            // 
            this.lblFilterWarehouse.AutoSize = true;
            this.lblFilterWarehouse.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFilterWarehouse.Location = new System.Drawing.Point(275, 172);
            this.lblFilterWarehouse.Name = "lblFilterWarehouse";
            this.lblFilterWarehouse.Size = new System.Drawing.Size(95, 21);
            this.lblFilterWarehouse.TabIndex = 7;
            this.lblFilterWarehouse.Text = "Warehouse";
            // 
            // cboFilterWarehouse
            // 
            this.cboFilterWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterWarehouse.FormattingEnabled = true;
            this.cboFilterWarehouse.Location = new System.Drawing.Point(357, 168);
            this.cboFilterWarehouse.Name = "cboFilterWarehouse";
            this.cboFilterWarehouse.Size = new System.Drawing.Size(180, 31);
            this.cboFilterWarehouse.TabIndex = 8;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(552, 172);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(57, 21);
            this.lblFilterStatus.TabIndex = 9;
            this.lblFilterStatus.Text = "Status";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "All",
            "OK",
            "Low",
            "Out of stock"});
            this.cboFilterStatus.Location = new System.Drawing.Point(604, 168);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(115, 31);
            this.cboFilterStatus.TabIndex = 10;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnExport.Location = new System.Drawing.Point(760, 164);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 34);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCount.Location = new System.Drawing.Point(22, 202);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(85, 21);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "0 record(s)";
            // 
            // gridStock
            // 
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStock.BackgroundColor = System.Drawing.Color.White;
            this.gridStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSku,
            this.colItemName,
            this.colWarehouse,
            this.colOnHand,
            this.colReorderLevel,
            this.colStockLevel,
            this.colStatus,
            this.colLastMovement});
            this.gridStock.Location = new System.Drawing.Point(20, 226);
            this.gridStock.MultiSelect = false;
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.RowHeadersVisible = false;
            this.gridStock.RowHeadersWidth = 51;
            this.gridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStock.Size = new System.Drawing.Size(860, 379);
            this.gridStock.TabIndex = 13;
            // 
            // colSku
            // 
            this.colSku.HeaderText = "SKU";
            this.colSku.MinimumWidth = 6;
            this.colSku.Name = "colSku";
            this.colSku.ReadOnly = true;
            this.colSku.Width = 125;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 125;
            // 
            // colWarehouse
            // 
            this.colWarehouse.HeaderText = "Warehouse";
            this.colWarehouse.MinimumWidth = 6;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.ReadOnly = true;
            this.colWarehouse.Width = 125;
            // 
            // colOnHand
            // 
            this.colOnHand.HeaderText = "On Hand";
            this.colOnHand.MinimumWidth = 6;
            this.colOnHand.Name = "colOnHand";
            this.colOnHand.ReadOnly = true;
            this.colOnHand.Width = 125;
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.HeaderText = "Reorder Level";
            this.colReorderLevel.MinimumWidth = 6;
            this.colReorderLevel.Name = "colReorderLevel";
            this.colReorderLevel.ReadOnly = true;
            this.colReorderLevel.Width = 125;
            // 
            // colStockLevel
            // 
            this.colStockLevel.HeaderText = "Stock Level";
            this.colStockLevel.MinimumWidth = 6;
            this.colStockLevel.Name = "colStockLevel";
            this.colStockLevel.ReadOnly = true;
            this.colStockLevel.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colLastMovement
            // 
            this.colLastMovement.HeaderText = "Last Movement";
            this.colLastMovement.MinimumWidth = 6;
            this.colLastMovement.Name = "colLastMovement";
            this.colLastMovement.ReadOnly = true;
            this.colLastMovement.Width = 125;
            // 
            // StockMonitoringControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.cardInStock);
            this.Controls.Add(this.cardLow);
            this.Controls.Add(this.cardOut);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFilterWarehouse);
            this.Controls.Add(this.cboFilterWarehouse);
            this.Controls.Add(this.lblFilterStatus);
            this.Controls.Add(this.cboFilterStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gridStock);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "StockMonitoringControl";
            this.Size = new System.Drawing.Size(900, 620);
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardInStock.ResumeLayout(false);
            this.cardInStock.PerformLayout();
            this.cardLow.ResumeLayout(false);
            this.cardLow.PerformLayout();
            this.cardOut.ResumeLayout(false);
            this.cardOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel cardTotalAccent;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel cardInStock;
        private System.Windows.Forms.Panel cardInStockAccent;
        private System.Windows.Forms.Label lblInStockCaption;
        private System.Windows.Forms.Label lblInStockValue;
        private System.Windows.Forms.Panel cardLow;
        private System.Windows.Forms.Panel cardLowAccent;
        private System.Windows.Forms.Label lblLowCaption;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Panel cardOut;
        private System.Windows.Forms.Panel cardOutAccent;
        private System.Windows.Forms.Label lblOutCaption;
        private System.Windows.Forms.Label lblOutValue;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterWarehouse;
        private System.Windows.Forms.ComboBox cboFilterWarehouse;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView gridStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastMovement;
    }
}
