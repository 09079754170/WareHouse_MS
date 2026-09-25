using System;
using System.Windows.Forms;
using WMS_Project.Data;

namespace WMS_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = "Please enter your username and password.";
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                var user = Repository.Login(txtUsername.Text, txtPassword.Text);
                if (user == null)
                {
                    lblError.Text = "Incorrect username or password.";
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Database error: " + ex.Message;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
