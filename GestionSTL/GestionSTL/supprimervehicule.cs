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

namespace GestionSTL
{
    public partial class supprimervehicule : Form
    {
        public supprimervehicule()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string numero = textBox1.Text;
            MessageBox.Show("numero =" + numero);
            string server = "localhost";
            string database = "stl";
            string user = "root";
            string password = " ";
            string cnnstr = "database = " + database + "; server = " + server + "; user = " + user + "; password =" + password;
            MySqlConnection cnn = new MySqlConnection(cnnstr);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete from vahicule where  num_chassis = " + numero, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("suppression reussite!");
            cnn.Close();
            admin a = new admin();
            this.Hide();
            a.Show();

        }
    }
}
