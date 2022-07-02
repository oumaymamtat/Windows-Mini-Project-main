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
    public partial class modifiervehicule : Form
    {
        public modifiervehicule()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numamodifier = Int32.Parse(textBox1.Text);
            string marque = textBox3.Text;
            string categorie = comboBox1.Text;
            string etat = comboBox2.Text;
            int nbkm = Int32.Parse(textBox4.Text);
            int nbh = Int32.Parse(textBox5.Text);
            MessageBox.Show("numamodifier="+numamodifier+"\t marque =" + marque + "\t categorie = " + categorie + "\t  etat = " + etat + "\t nbkm = " + nbkm + "\t nbh =" + nbh);
            string server = "localhost";
            string database = "stl";
            string user = "root";
            string password = " ";
            string cnnstr = "database = " + database + "; server = " + server + "; user = " + user + "; password =" + password;
            MySqlConnection cnn = new MySqlConnection(cnnstr);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("Update vahicule SET marque='"+marque+"', categorie='"+categorie+"' ,etat='"+etat+"', nbkm="+nbkm+", nbh="+nbh+" where num_chassis ="+numamodifier,cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("modification avec succes");
            cnn.Close();
            admin a = new admin();
            this.Hide();
            a.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
