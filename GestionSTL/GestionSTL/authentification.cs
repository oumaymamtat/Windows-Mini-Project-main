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
    public partial class authentification : Form
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string mdp = textBox2.Text;
            MessageBox.Show("login =" + login + "\t mdp =" + mdp);
            string server = "localhost";
            string database = "stl";
            string user = "root";
            string password = " ";
            string cnnstr = "database = " + database + "; server = " + server + "; user = " + user + "; password =" + password;   
            MySqlConnection cnn = new MySqlConnection(cnnstr);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("select type from compte where login = '" + login +"' and password = '" +mdp+"';",cnn);
             MySqlDataReader r = cmd.ExecuteReader();
            r.Read();
            string type = (string)r["type"];
            if (type == "admin")
            {
                this.Hide();
                admin a = new admin();
                a.Show();
            }
            else
            {
                if (type =="agent")
                {
                    agent a = new agent();
                    this.Hide();
                    a.Show();
                }
            }

            cnn.Close();
       }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienvenue b = new Bienvenue();
            b.Show();
          

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
