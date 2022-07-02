using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSTL
{
    public partial class ajouterclient : Form
    {
        public ajouterclient()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            string adresse = textBox2.Text;
            string cin = textBox3.Text;
            string nom = textBox4.Text;
            string prenom = textBox5.Text;
            string npss = textBox6.Text;
            string po = textBox7.Text;
            string nom1 = textBox8.Text;
            string prenom1 = textBox9.Text;
            string cdfis = textBox10.Text;
            string rsoc = textBox11.Text;
            MessageBox.Show("code=" + code + "\t adresse=" + adresse + "\t cin=" + cin + "\t nom=" + nom + "\t prenom=" + prenom + "\t npss=" + npss + "\t po=" + po + "\t nom1=" + nom1 + "\t prenom1=" + prenom1 + "\t cdfis=" + cdfis + "\t rsoc=" + rsoc);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
