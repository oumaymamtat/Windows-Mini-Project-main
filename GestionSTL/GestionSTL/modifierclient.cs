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
    public partial class modifierclient : Form
    {
        public modifierclient()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string codemod = textBox1.Text;
            string code = textBox2.Text;
            string adresse = textBox3.Text;
            string cin = textBox4.Text;
            string nom = textBox5.Text;
            string prenom = textBox6.Text;
            string npss = textBox7.Text;
            string po = textBox8.Text;
            string nom1 = textBox9.Text;
            string prenom1 = textBox10.Text;
            string cdfis = textBox11.Text;
            string rsoc = textBox12.Text;
            MessageBox.Show("code a modifier =" + codemod + "\t code=" + code + "\t adresse=" + adresse + "\t cin=" + cin + "\t nom=" + nom + "\t prenom=" + prenom + "\t npss=" + npss + "\t po=" + po + "\t nom1=" + nom1 + "\t prenom1=" + prenom1 + "\t cdfis=" + cdfis);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
