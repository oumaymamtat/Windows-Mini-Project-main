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
    public partial class modifiercontrat : Form
    {
        public modifiercontrat()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            string numamodifier = textBox1.Text;
            string num = textBox10.Text;
            string code = textBox7.Text;
            string tarif = textBox6.Text;
            string numch = textBox5.Text;
            string ma = textBox3.Text;
            string del = dateTimePicker1.Text;
            string vc = textBox4.Text;
            string dr = dateTimePicker2.Text;
            string vcr = textBox8.Text;
            string ach = comboBox1.Text;
            MessageBox.Show("numamodifier ="+ numamodifier+"\t num =" + num + "\t code=" + code + "\t tarif=" + tarif + "\t numch=" + numch + "\t ma=" + ma + "\t del=" + del + "\t vc=" + vc + "\t dr=" + dr + "\t vcr=" + vcr + "\t ach=" + ach);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
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

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
