using System;
using System.Windows.Forms;
using WMS_Project.Data;

namespace WMS_Project
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
#if NET5_0_OR_GREATER
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Db.EnsureDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not connect to SQL Server (" + Db.Server + ").\n\n" + ex.Message +
                    "\n\nFix: open Visual Studio Installer > Modify > Individual components, " +
                    "tick \"SQL Server Express LocalDB\" and install it. " +
                    "Or change Db.Server in Data\\Db.cs to your own SQL Server.",
                    "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) return;
                }

                using (var main = new MainForm())
                {
                    main.ShowDialog();
                    if (!main.LoggedOut) return;
                }
            }
        }
    }
}
