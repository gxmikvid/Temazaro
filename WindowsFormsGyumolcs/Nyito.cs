using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsGyumolcs
    {
    public partial class Nyito : Form
    {
        #region dbStuff
        void UpdateList(MySqlCommand cmd)
        {
            MySqlDataReader dr = cmd.ExecuteReader();
            gyumolcsList.Items.Clear();
            while (dr.Read())
            {
                Gyumolcs gyumolcs = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                gyumolcsList.Items.Add(gyumolcs);
            }
        }

        void SQLDelete(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id", ((Gyumolcs)gyumolcsList.SelectedItem).Id);
            cmd.ExecuteNonQuery();
        }
        #endregion 

        public Nyito()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.DBHandler("SELECT * FROM gyumolcsok", UpdateList);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Program.modify = false;
            Program.AUF.ShowDialog();
            Program.DBHandler("SELECT * FROM gyumolcsok", UpdateList);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (gyumolcsList.SelectedIndex != -1)
            {
                Program.DBHandler("DELETE FROM gyumolcsok WHERE id = @id", SQLDelete);
                Program.DBHandler("SELECT * FROM gyumolcsok", UpdateList);
            }
            if (gyumolcsList.Items.Count != 0)
            {
                gyumolcsList.SelectedIndex = 0;
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (gyumolcsList.SelectedIndex != -1)
            {
                Program.modify = true;
                Program.AUF.ShowDialog();
                Program.DBHandler("SELECT * FROM gyumolcsok", UpdateList);
            }
        }
    }
}
