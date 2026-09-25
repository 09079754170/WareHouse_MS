using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMS_Project.Data;
using WMS_Project.Helpers;
using WMS_Project.Views;

namespace WMS_Project
{
    public partial class MainForm : Form
    {
        private static readonly Color ActiveNavColor = Color.FromArgb(30, 136, 229);

        private readonly Dictionary<Button, UserControl> createdViews = new Dictionary<Button, UserControl>();

        private Color normalNavColor;

        public bool LoggedOut { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            normalNavColor = btnDashboard.BackColor;

            if (Repository.CurrentUser != null)
            {
                lblUserName.Text = Repository.CurrentUser.FullName;
                lblUserRole.Text = Repository.CurrentUser.Role;
            }

            ShowView(btnDashboard);
        }

        private void Nav_Click(object sender, EventArgs e)
        {
            ShowView((Button)sender);
        }

        private void ShowView(Button button)
        {
            UserControl view;
            if (!createdViews.TryGetValue(button, out view))
            {
                view = CreateView(button);
                view.Dock = DockStyle.Fill;
                createdViews[button] = view;
                pnlContent.Controls.Add(view);
            }

            foreach (var pair in createdViews)
            {
                pair.Value.Visible = pair.Value == view;
                pair.Key.BackColor = pair.Key == button ? ActiveNavColor : normalNavColor;
            }
            view.BringToFront();

            var titleAndSubtitle = (string[])view.Tag;
            lblPageTitle.Text = titleAndSubtitle[0];
            lblPageSubtitle.Text = titleAndSubtitle[1];

            try
            {
                var refreshable = view as IRefreshable;
                if (refreshable != null) refreshable.RefreshData();
            }
            catch (Exception ex)
            {
                UiHelper.ShowError(ex);
            }
        }

        private UserControl CreateView(Button button)
        {
            UserControl view;
            string subtitle;

            if (button == btnDashboard)
            {
                view = new DashboardControl();
                subtitle = "A live snapshot of stock across all warehouses.";
            }
            else if (button == btnWarehouses)
            {
                view = new WarehousesControl();
                subtitle = "Add, edit and remove warehouses. Saved to the SQL Server database.";
            }
            else if (button == btnItems)
            {
                view = new ItemsControl();
                subtitle = "Save items (SKUs) and their quantity in each warehouse.";
            }
            else if (button == btnReceiving)
            {
                view = new ReceivingControl();
                subtitle = "Record goods received from suppliers into a warehouse.";
            }
            else if (button == btnTransfers)
            {
                view = new TransfersControl();
                subtitle = "Move stock from one warehouse to another.";
            }
            else if (button == btnPicking)
            {
                view = new PickingControl();
                subtitle = "Create pick lists for customer orders and track picking and packing.";
            }
            else if (button == btnDispatch)
            {
                view = new DispatchControl();
                subtitle = "Ship packed orders and record carrier and tracking details.";
            }
            else if (button == btnStock)
            {
                view = new StockMonitoringControl();
                subtitle = "Watch stock levels and spot low or out-of-stock items.";
            }
            else if (button == btnHistory)
            {
                view = new MovementHistoryControl();
                subtitle = "Every stock movement: receipts, transfers, picks and dispatches.";
            }
            else
            {
                view = new BlankSectionControl();
                subtitle = "";
            }

            view.Tag = new[] { button.Text, subtitle };
            return view;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!UiHelper.Confirm("Log out of the Warehouse Management System?")) return;

            try { Repository.Logout(); }
            catch (Exception ex) { UiHelper.ShowError(ex); }

            LoggedOut = true;
            Close();
        }
    }
}
