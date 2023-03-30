using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarieSelbyProject
{
    public static class Globals
    {
        public const string connectionString = "Data Source=AJ-DESKTOP;Initial Catalog=MS_GARDENS;Integrated Security=True";
        public const string assetsFolder = "..\\..\\Assets\\";
        public const string exhibitsFolder = "Exhibits\\";
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
