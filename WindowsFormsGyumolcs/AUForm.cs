using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsGyumolcs {
    public partial class AUForm : Form {
        public AUForm()
        {
            InitializeComponent();
        }

        #region dbStuff
        void Fill(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id", ((Gyumolcs)Program.nyito.gyumolcsList.SelectedItem).Id);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            idCont.Value = dr.GetInt32("id");
            nameCont.Text = dr.GetString("nev");
            egysegarCont.Text = dr.GetString("egysegar");
            mennyisegCont.Text = dr.GetString("mennyiseg");
        }

        void SQLModify(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nev", nameCont.Text);
            cmd.Parameters.AddWithValue("@egysegar", egysegarCont.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", mennyisegCont.Text);
            cmd.Parameters.AddWithValue("@id", idCont.Value);
            cmd.ExecuteNonQuery();
        }

        void SQLUpload(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nev", nameCont.Text);
            cmd.Parameters.AddWithValue("@egysegar", egysegarCont.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", mennyisegCont.Text);
            cmd.ExecuteNonQuery();
        }
        #endregion

        private void AUMForm_Load(object sender, EventArgs e)
        {
            if (Program.modify)
            {
                Program.DBHandler("SELECT * FROM gyumolcsok WHERE id = @id", Fill);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (Program.modify)
            {
                Program.DBHandler("UPDATE gyumolcsok SET nev = @nev, egysegar = @egysegar, mennyiseg = @mennyiseg WHERE gyumolcsok.id = @id", SQLModify);
                Program.AUF.Close();
            }
            else
            {
                Program.DBHandler("INSERT INTO gyumolcsok (id, nev, egysegar, mennyiseg) VALUES (NULL, @nev, @egysegar, @mennyiseg)", SQLUpload);
                Program.AUF.Close();
            }
        }
    }
}
