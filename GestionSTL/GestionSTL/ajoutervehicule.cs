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
    public partial class ajoutervehicule : Form
    {
        public ajoutervehicule()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num =Int32.Parse( textBox1.Text);
            string marque = textBox2.Text;
            string categorie = comboBox1.Text;
            string etat = comboBox2.Text;
            int nbkm = Int32.Parse(textBox4.Text);
            int nbh = Int32.Parse(textBox5.Text);
            MessageBox.Show("num ="+ num +"\t marque ="+ marque +"\t categorie = "+categorie +"\t  etat = "+etat +"\t nbkm = "+nbkm +"\t nbh ="+ nbh);
            string server = "localhost";
            string database = "stl";
            string user = "root";
            string password = " ";
            string cnnstr = "database = " + database + "; server = " + server + "; user = " + user + "; password =" + password;
            MySqlConnection cnn = new MySqlConnection(cnnstr);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert Into vahicule Values( " + num+",'" + marque +"' , '"+ categorie+"' , '" + etat +"' ,"+ nbkm+","+ nbh+");", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajout avec succes");
            cnn.Close();
            admin a = new admin();
            this.Hide();
            a.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
