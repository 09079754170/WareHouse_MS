namespace WMS_Project.Views
{
    partial class ReceivingControl
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

        #region Component Designer

        private void InitializeComponent()
        {
            this.lblPreviewNotice = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlFormAccent = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterWarehouse = new System.Windows.Forms.Label();
            this.cboFilterWarehouse = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.gridReceipts = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreviewNotice
            // 
            this.lblPreviewNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviewNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblPreviewNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPreviewNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblPreviewNotice.Location = new System.Drawing.Point(20, 10);
            this.lblPreviewNotice.Name = "lblPreviewNotice";
            this.lblPreviewNotice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPreviewNotice.Size = new System.Drawing.Size(860, 30);
            this.lblPreviewNotice.TabIndex = 0;
            this.lblPreviewNotice.Text = "UI preview - this screen is designed but not yet connected to the database.";
            this.lblPreviewNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPreviewNotice.Click += new System.EventHandler(this.lblPreviewNotice_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlFormAccent);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.lblReference);
            this.pnlForm.Controls.Add(this.txtReference);
            this.pnlForm.Controls.Add(this.lblSupplier);
            this.pnlForm.Controls.Add(this.txtSupplier);
            this.pnlForm.Controls.Add(this.lblWarehouse);
            this.pnlForm.Controls.Add(this.cboWarehouse);
            this.pnlForm.Controls.Add(this.lblDate);
            this.pnlForm.Controls.Add(this.dtpDate);
            this.pnlForm.Controls.Add(this.lblSku);
            this.pnlForm.Controls.Add(this.txtSku);
            this.pnlForm.Controls.Add(this.lblQuantity);
            this.pnlForm.Controls.Add(this.numQuantity);
            this.pnlForm.Controls.Add(this.lblRemarks);
            this.pnlForm.Controls.Add(this.txtRemarks);
            this.pnlForm.Controls.Add(this.btnReceive);
            this.pnlForm.Controls.Add(this.btnClear);
            this.pnlForm.Location = new System.Drawing.Point(20, 48);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(860, 212);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlFormAccent
            // 
            this.pnlFormAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.pnlFormAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlFormAccent.Name = "pnlFormAccent";
            this.pnlFormAccent.Size = new System.Drawing.Size(860, 4);
            this.pnlFormAccent.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(190, 28);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "New goods receipt";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblReference.Location = new System.Drawing.Point(20, 50);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(151, 20);
            this.lblReference.TabIndex = 2;
            this.lblReference.Text = "Reference / PO no. *";
            // 
            // txtReference
            // 
            this.txtReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReference.Location = new System.Drawing.Point(20, 72);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(150, 30);
            this.txtReference.TabIndex = 3;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblSupplier.Location = new System.Drawing.Point(185, 50);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(77, 20);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier *";
            // 
            // txtSupplier
            // 
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSupplier.Location = new System.Drawing.Point(185, 72);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(220, 30);
            this.txtSupplier.TabIndex = 5;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblWarehouse.Location = new System.Drawing.Point(420, 50);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(98, 20);
            this.lblWarehouse.TabIndex = 6;
            this.lblWarehouse.Text = "Warehouse *";
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(420, 72);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(220, 31);
            this.cboWarehouse.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblDate.Location = new System.Drawing.Point(655, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date received";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(655, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 30);
            this.dtpDate.TabIndex = 9;
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblSku.Location = new System.Drawing.Point(20, 104);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(49, 20);
            this.lblSku.TabIndex = 10;
            this.lblSku.Text = "SKU *";
            // 
            // txtSku
            // 
            this.txtSku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSku.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSku.Location = new System.Drawing.Point(20, 126);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(150, 30);
            this.txtSku.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblQuantity.Location = new System.Drawing.Point(185, 104);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(143, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity received *";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numQuantity.Location = new System.Drawing.Point(185, 126);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(130, 30);
            this.numQuantity.TabIndex = 13;
            this.numQuantity.ThousandsSeparator = true;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblRemarks.Location = new System.Drawing.Point(330, 104);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(70, 20);
            this.lblRemarks.TabIndex = 14;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemarks.Location = new System.Drawing.Point(330, 126);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(510, 30);
            this.txtRemarks.TabIndex = 15;
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReceive.ForeColor = System.Drawing.Color.White;
            this.btnReceive.Location = new System.Drawing.Point(20, 164);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(160, 34);
            this.btnReceive.TabIndex = 16;
            this.btnReceive.Text = "+ Receive stock";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(190, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 34);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblSearch.Location = new System.Drawing.Point(22, 280);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 21);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 276);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 30);
            this.txtSearch.TabIndex = 3;
            // 
            // lblFilterWarehouse
            // 
            this.lblFilterWarehouse.AutoSize = true;
            this.lblFilterWarehouse.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFilterWarehouse.Location = new System.Drawing.Point(298, 280);
            this.lblFilterWarehouse.Name = "lblFilterWarehouse";
            this.lblFilterWarehouse.Size = new System.Drawing.Size(95, 21);
            this.lblFilterWarehouse.TabIndex = 4;
            this.lblFilterWarehouse.Text = "Warehouse";
            // 
            // cboFilterWarehouse
            // 
            this.cboFilterWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterWarehouse.FormattingEnabled = true;
            this.cboFilterWarehouse.Location = new System.Drawing.Point(380, 276);
            this.cboFilterWarehouse.Name = "cboFilterWarehouse";
            this.cboFilterWarehouse.Size = new System.Drawing.Size(200, 31);
            this.cboFilterWarehouse.TabIndex = 5;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCount.Location = new System.Drawing.Point(598, 280);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(85, 21);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "0 record(s)";
            // 
            // gridReceipts
            // 
            this.gridReceipts.AllowUserToAddRows = false;
            this.gridReceipts.AllowUserToDeleteRows = false;
            this.gridReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReceipts.BackgroundColor = System.Drawing.Color.White;
            this.gridReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colDate,
            this.colSupplier,
            this.colWarehouse,
            this.colSku,
            this.colItemName,
            this.colQuantity,
            this.colReceivedBy});
            this.gridReceipts.Location = new System.Drawing.Point(20, 316);
            this.gridReceipts.MultiSelect = false;
            this.gridReceipts.Name = "gridReceipts";
            this.gridReceipts.ReadOnly = true;
            this.gridReceipts.RowHeadersVisible = false;
            this.gridReceipts.RowHeadersWidth = 51;
            this.gridReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReceipts.Size = new System.Drawing.Size(860, 289);
            this.gridReceipts.TabIndex = 7;
            // 
            // colReference
            // 
            this.colReference.HeaderText = "Reference";
            this.colReference.MinimumWidth = 6;
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            this.colReference.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colSupplier
            // 
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.MinimumWidth = 6;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            this.colSupplier.Width = 125;
            // 
            // colWarehouse
            // 
            this.colWarehouse.HeaderText = "Warehouse";
            this.colWarehouse.MinimumWidth = 6;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.ReadOnly = true;
            this.colWarehouse.Width = 125;
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
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 125;
            // 
            // colReceivedBy
            // 
            this.colReceivedBy.HeaderText = "Received By";
            this.colReceivedBy.MinimumWidth = 6;
            this.colReceivedBy.Name = "colReceivedBy";
            this.colReceivedBy.ReadOnly = true;
            this.colReceivedBy.Width = 125;
            // 
            // ReceivingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lblPreviewNotice);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFilterWarehouse);
            this.Controls.Add(this.cboFilterWarehouse);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gridReceipts);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ReceivingControl";
            this.Size = new System.Drawing.Size(900, 620);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviewNotice;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFormAccent;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterWarehouse;
        private System.Windows.Forms.ComboBox cboFilterWarehouse;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView gridReceipts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedBy;
    }
}
