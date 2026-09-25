namespace WMS_Project.Views
{
    partial class DispatchControl
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
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.cboCarrier = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTracking = new System.Windows.Forms.Label();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.gridDispatches = new System.Windows.Forms.DataGridView();
            this.colDispatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrackingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDispatched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDispatches)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlFormAccent);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.lblOrderNo);
            this.pnlForm.Controls.Add(this.cboOrder);
            this.pnlForm.Controls.Add(this.lblCustomer);
            this.pnlForm.Controls.Add(this.txtCustomer);
            this.pnlForm.Controls.Add(this.lblCarrier);
            this.pnlForm.Controls.Add(this.cboCarrier);
            this.pnlForm.Controls.Add(this.lblDate);
            this.pnlForm.Controls.Add(this.dtpDate);
            this.pnlForm.Controls.Add(this.lblTracking);
            this.pnlForm.Controls.Add(this.txtTracking);
            this.pnlForm.Controls.Add(this.lblPlate);
            this.pnlForm.Controls.Add(this.txtPlate);
            this.pnlForm.Controls.Add(this.lblDriver);
            this.pnlForm.Controls.Add(this.txtDriver);
            this.pnlForm.Controls.Add(this.btnDispatch);
            this.pnlForm.Controls.Add(this.btnPrint);
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
            this.lblFormTitle.Size = new System.Drawing.Size(189, 28);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Dispatch shipment";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblOrderNo.Location = new System.Drawing.Point(20, 50);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(111, 20);
            this.lblOrderNo.TabIndex = 2;
            this.lblOrderNo.Text = "Packed order *";
            // 
            // cboOrder
            // 
            this.cboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboOrder.FormattingEnabled = true;
            this.cboOrder.Location = new System.Drawing.Point(20, 72);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(200, 31);
            this.cboOrder.TabIndex = 3;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblCustomer.Location = new System.Drawing.Point(235, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(77, 20);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomer.Location = new System.Drawing.Point(235, 72);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(220, 30);
            this.txtCustomer.TabIndex = 5;
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarrier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblCarrier.Location = new System.Drawing.Point(470, 50);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(67, 20);
            this.lblCarrier.TabIndex = 6;
            this.lblCarrier.Text = "Carrier *";
            // 
            // cboCarrier
            // 
            this.cboCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCarrier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCarrier.FormattingEnabled = true;
            this.cboCarrier.Items.AddRange(new object[] {
            "Own delivery truck",
            "Courier",
            "Third-party logistics",
            "Customer pick-up"});
            this.cboCarrier.Location = new System.Drawing.Point(470, 72);
            this.cboCarrier.Name = "cboCarrier";
            this.cboCarrier.Size = new System.Drawing.Size(180, 31);
            this.cboCarrier.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblDate.Location = new System.Drawing.Point(665, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Dispatch date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(665, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(175, 30);
            this.dtpDate.TabIndex = 9;
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblTracking.Location = new System.Drawing.Point(20, 104);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(158, 20);
            this.lblTracking.TabIndex = 10;
            this.lblTracking.Text = "Tracking / waybill no.";
            // 
            // txtTracking
            // 
            this.txtTracking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTracking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTracking.Location = new System.Drawing.Point(20, 126);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(200, 30);
            this.txtTracking.TabIndex = 11;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblPlate.Location = new System.Drawing.Point(235, 104);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(123, 20);
            this.lblPlate.TabIndex = 12;
            this.lblPlate.Text = "Vehicle plate no.";
            // 
            // txtPlate
            // 
            this.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlate.Location = new System.Drawing.Point(235, 126);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(140, 30);
            this.txtPlate.TabIndex = 13;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblDriver.Location = new System.Drawing.Point(390, 104);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(159, 20);
            this.lblDriver.TabIndex = 14;
            this.lblDriver.Text = "Driver / courier name";
            // 
            // txtDriver
            // 
            this.txtDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDriver.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDriver.Location = new System.Drawing.Point(390, 126);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(260, 30);
            this.txtDriver.TabIndex = 15;
            // 
            // btnDispatch
            // 
            this.btnDispatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnDispatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispatch.FlatAppearance.BorderSize = 0;
            this.btnDispatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDispatch.ForeColor = System.Drawing.Color.White;
            this.btnDispatch.Location = new System.Drawing.Point(20, 164);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(160, 34);
            this.btnDispatch.TabIndex = 16;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = false;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnPrint.Location = new System.Drawing.Point(190, 164);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 34);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print delivery note";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnClear.Location = new System.Drawing.Point(370, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 34);
            this.btnClear.TabIndex = 18;
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
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(298, 280);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(57, 21);
            this.lblFilterStatus.TabIndex = 4;
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
            "Ready",
            "Dispatched",
            "Delivered",
            "Returned"});
            this.cboFilterStatus.Location = new System.Drawing.Point(350, 276);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(140, 31);
            this.cboFilterStatus.TabIndex = 5;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCount.Location = new System.Drawing.Point(508, 280);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(85, 21);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "0 record(s)";
            // 
            // gridDispatches
            // 
            this.gridDispatches.AllowUserToAddRows = false;
            this.gridDispatches.AllowUserToDeleteRows = false;
            this.gridDispatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDispatches.BackgroundColor = System.Drawing.Color.White;
            this.gridDispatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDispatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDispatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDispatchNo,
            this.colOrderNo,
            this.colCustomer,
            this.colCarrier,
            this.colTrackingNo,
            this.colPlateNo,
            this.colDriver,
            this.colDispatched,
            this.colStatus});
            this.gridDispatches.Location = new System.Drawing.Point(20, 316);
            this.gridDispatches.MultiSelect = false;
            this.gridDispatches.Name = "gridDispatches";
            this.gridDispatches.ReadOnly = true;
            this.gridDispatches.RowHeadersVisible = false;
            this.gridDispatches.RowHeadersWidth = 51;
            this.gridDispatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDispatches.Size = new System.Drawing.Size(860, 289);
            this.gridDispatches.TabIndex = 7;
            // 
            // colDispatchNo
            // 
            this.colDispatchNo.HeaderText = "Dispatch No.";
            this.colDispatchNo.MinimumWidth = 6;
            this.colDispatchNo.Name = "colDispatchNo";
            this.colDispatchNo.ReadOnly = true;
            this.colDispatchNo.Width = 125;
            // 
            // colOrderNo
            // 
            this.colOrderNo.HeaderText = "Order No.";
            this.colOrderNo.MinimumWidth = 6;
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.ReadOnly = true;
            this.colOrderNo.Width = 125;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Width = 125;
            // 
            // colCarrier
            // 
            this.colCarrier.HeaderText = "Carrier";
            this.colCarrier.MinimumWidth = 6;
            this.colCarrier.Name = "colCarrier";
            this.colCarrier.ReadOnly = true;
            this.colCarrier.Width = 125;
            // 
            // colTrackingNo
            // 
            this.colTrackingNo.HeaderText = "Tracking No.";
            this.colTrackingNo.MinimumWidth = 6;
            this.colTrackingNo.Name = "colTrackingNo";
            this.colTrackingNo.ReadOnly = true;
            this.colTrackingNo.Width = 125;
            // 
            // colPlateNo
            // 
            this.colPlateNo.HeaderText = "Plate No.";
            this.colPlateNo.MinimumWidth = 6;
            this.colPlateNo.Name = "colPlateNo";
            this.colPlateNo.ReadOnly = true;
            this.colPlateNo.Width = 125;
            // 
            // colDriver
            // 
            this.colDriver.HeaderText = "Driver";
            this.colDriver.MinimumWidth = 6;
            this.colDriver.Name = "colDriver";
            this.colDriver.ReadOnly = true;
            this.colDriver.Width = 125;
            // 
            // colDispatched
            // 
            this.colDispatched.HeaderText = "Dispatched";
            this.colDispatched.MinimumWidth = 6;
            this.colDispatched.Name = "colDispatched";
            this.colDispatched.ReadOnly = true;
            this.colDispatched.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // DispatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFilterStatus);
            this.Controls.Add(this.cboFilterStatus);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gridDispatches);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "DispatchControl";
            this.Size = new System.Drawing.Size(900, 620);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDispatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFormAccent;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.ComboBox cboOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.ComboBox cboCarrier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView gridDispatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispatched;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
