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
    public partial class modifiertarif : Form
    {
        public modifiertarif()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string categorie = comboBox2.Text;
            string tkm = textBox1.Text;
            string tlj = textBox7.Text;
            string tht = textBox6.Text;
            string tch = textBox5.Text;
            
            string nouvcategorie = comboBox1.Text;
            string nouvtkm = textBox8.Text;
            string nouvtlj = textBox2.Text;
            string nouvtht = textBox3.Text;
            string nouvtch = textBox4.Text;
            MessageBox.Show("categorie=" + categorie + "\t tkm=" + tkm + "\t tlj=" + tlj + "\t tht=" + tht + "\t tch=" + tch);
            MessageBox.Show("nouvcategorie=" + nouvcategorie + "\t nouvtkm=" + nouvtkm + "\t nouvtlj=" + nouvtlj + "\t nouvtht=" + nouvtht + "\t nouvtch=" + nouvtch);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
