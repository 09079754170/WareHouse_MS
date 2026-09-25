namespace WMS_Project.Views
{
    partial class TransfersControl
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlFormAccent = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFromWarehouse = new System.Windows.Forms.Label();
            this.cboFromWarehouse = new System.Windows.Forms.ComboBox();
            this.lblToWarehouse = new System.Windows.Forms.Label();
            this.cboToWarehouse = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAvailableCaption = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterWarehouse = new System.Windows.Forms.Label();
            this.cboFilterWarehouse = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.gridTransfers = new System.Windows.Forms.DataGridView();
            this.colTransferNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlFormAccent);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.lblFromWarehouse);
            this.pnlForm.Controls.Add(this.cboFromWarehouse);
            this.pnlForm.Controls.Add(this.lblToWarehouse);
            this.pnlForm.Controls.Add(this.cboToWarehouse);
            this.pnlForm.Controls.Add(this.lblDate);
            this.pnlForm.Controls.Add(this.dtpDate);
            this.pnlForm.Controls.Add(this.lblAvailableCaption);
            this.pnlForm.Controls.Add(this.lblAvailable);
            this.pnlForm.Controls.Add(this.lblSku);
            this.pnlForm.Controls.Add(this.txtSku);
            this.pnlForm.Controls.Add(this.lblQuantity);
            this.pnlForm.Controls.Add(this.numQuantity);
            this.pnlForm.Controls.Add(this.lblRemarks);
            this.pnlForm.Controls.Add(this.txtRemarks);
            this.pnlForm.Controls.Add(this.btnTransfer);
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
            this.lblFormTitle.Size = new System.Drawing.Size(192, 28);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "New stock transfer";
            // 
            // lblFromWarehouse
            // 
            this.lblFromWarehouse.AutoSize = true;
            this.lblFromWarehouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFromWarehouse.Location = new System.Drawing.Point(20, 50);
            this.lblFromWarehouse.Name = "lblFromWarehouse";
            this.lblFromWarehouse.Size = new System.Drawing.Size(137, 20);
            this.lblFromWarehouse.TabIndex = 2;
            this.lblFromWarehouse.Text = "From warehouse *";
            // 
            // cboFromWarehouse
            // 
            this.cboFromWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFromWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFromWarehouse.FormattingEnabled = true;
            this.cboFromWarehouse.Location = new System.Drawing.Point(20, 72);
            this.cboFromWarehouse.Name = "cboFromWarehouse";
            this.cboFromWarehouse.Size = new System.Drawing.Size(250, 31);
            this.cboFromWarehouse.TabIndex = 3;
            // 
            // lblToWarehouse
            // 
            this.lblToWarehouse.AutoSize = true;
            this.lblToWarehouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblToWarehouse.Location = new System.Drawing.Point(285, 50);
            this.lblToWarehouse.Name = "lblToWarehouse";
            this.lblToWarehouse.Size = new System.Drawing.Size(117, 20);
            this.lblToWarehouse.TabIndex = 4;
            this.lblToWarehouse.Text = "To warehouse *";
            // 
            // cboToWarehouse
            // 
            this.cboToWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboToWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboToWarehouse.FormattingEnabled = true;
            this.cboToWarehouse.Location = new System.Drawing.Point(285, 72);
            this.cboToWarehouse.Name = "cboToWarehouse";
            this.cboToWarehouse.Size = new System.Drawing.Size(250, 31);
            this.cboToWarehouse.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblDate.Location = new System.Drawing.Point(550, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Transfer date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(550, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 30);
            this.dtpDate.TabIndex = 7;
            // 
            // lblAvailableCaption
            // 
            this.lblAvailableCaption.AutoSize = true;
            this.lblAvailableCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblAvailableCaption.Location = new System.Drawing.Point(715, 50);
            this.lblAvailableCaption.Name = "lblAvailableCaption";
            this.lblAvailableCaption.Size = new System.Drawing.Size(141, 20);
            this.lblAvailableCaption.TabIndex = 8;
            this.lblAvailableCaption.Text = "Available at source";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAvailable.Location = new System.Drawing.Point(715, 74);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(19, 25);
            this.lblAvailable.TabIndex = 9;
            this.lblAvailable.Text = "-";
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
            this.lblQuantity.Size = new System.Drawing.Size(81, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity *";
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
            this.lblRemarks.Size = new System.Drawing.Size(132, 20);
            this.lblRemarks.TabIndex = 14;
            this.lblRemarks.Text = "Reason / remarks";
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
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(20, 164);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(160, 34);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transfer stock";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
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
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(598, 280);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(57, 21);
            this.lblFilterStatus.TabIndex = 6;
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
            "Completed",
            "In transit",
            "Cancelled"});
            this.cboFilterStatus.Location = new System.Drawing.Point(650, 276);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(140, 31);
            this.cboFilterStatus.TabIndex = 7;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCount.Location = new System.Drawing.Point(808, 280);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(85, 21);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0 record(s)";
            // 
            // gridTransfers
            // 
            this.gridTransfers.AllowUserToAddRows = false;
            this.gridTransfers.AllowUserToDeleteRows = false;
            this.gridTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransfers.BackgroundColor = System.Drawing.Color.White;
            this.gridTransfers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransfers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransferNo,
            this.colDate,
            this.colSku,
            this.colItemName,
            this.colFrom,
            this.colTo,
            this.colQuantity,
            this.colStatus,
            this.colBy});
            this.gridTransfers.Location = new System.Drawing.Point(20, 316);
            this.gridTransfers.MultiSelect = false;
            this.gridTransfers.Name = "gridTransfers";
            this.gridTransfers.ReadOnly = true;
            this.gridTransfers.RowHeadersVisible = false;
            this.gridTransfers.RowHeadersWidth = 51;
            this.gridTransfers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransfers.Size = new System.Drawing.Size(860, 289);
            this.gridTransfers.TabIndex = 9;
            // 
            // colTransferNo
            // 
            this.colTransferNo.HeaderText = "Transfer No.";
            this.colTransferNo.MinimumWidth = 6;
            this.colTransferNo.Name = "colTransferNo";
            this.colTransferNo.ReadOnly = true;
            this.colTransferNo.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
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
            // colFrom
            // 
            this.colFrom.HeaderText = "From";
            this.colFrom.MinimumWidth = 6;
            this.colFrom.Name = "colFrom";
            this.colFrom.ReadOnly = true;
            this.colFrom.Width = 125;
            // 
            // colTo
            // 
            this.colTo.HeaderText = "To";
            this.colTo.MinimumWidth = 6;
            this.colTo.Name = "colTo";
            this.colTo.ReadOnly = true;
            this.colTo.Width = 125;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colBy
            // 
            this.colBy.HeaderText = "By";
            this.colBy.MinimumWidth = 6;
            this.colBy.Name = "colBy";
            this.colBy.ReadOnly = true;
            this.colBy.Width = 125;
            // 
            // TransfersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFilterWarehouse);
            this.Controls.Add(this.cboFilterWarehouse);
            this.Controls.Add(this.lblFilterStatus);
            this.Controls.Add(this.cboFilterStatus);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gridTransfers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "TransfersControl";
            this.Size = new System.Drawing.Size(900, 620);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFormAccent;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFromWarehouse;
        private System.Windows.Forms.ComboBox cboFromWarehouse;
        private System.Windows.Forms.Label lblToWarehouse;
        private System.Windows.Forms.ComboBox cboToWarehouse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblAvailableCaption;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterWarehouse;
        private System.Windows.Forms.ComboBox cboFilterWarehouse;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView gridTransfers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBy;
    }
}
