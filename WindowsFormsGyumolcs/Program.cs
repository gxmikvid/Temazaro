using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsGyumolcs {
    internal static class Program {
        public static bool modify = false;
        public static AUForm AUF = new AUForm();
        public static Nyito nyito = new Nyito();
        private static MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=gyumolcsok;port=3306;password=");
        public static void DBHandler(string command, Action<MySqlCommand> Method)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(command, conn);
                Method(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(nyito);
        }
    }
}
