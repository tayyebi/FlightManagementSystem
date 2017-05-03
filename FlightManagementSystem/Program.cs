using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagementSystem
{
    public static class Program
    {
        public enum Modes
        {
            Insert,
            Update,
            Delete,
            Details
        }

        [STAThread]
        static void Main()
        {
            Application.ThreadException += (sender, args) => MyException(sender, args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => MyException(sender, args.ExceptionObject as Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheMain());
        }

        private static void MyException(object sender, Exception e)
        {
            MessageBox.Show($"There was an error: \r\n{e.Message}");
        }
    }
}
