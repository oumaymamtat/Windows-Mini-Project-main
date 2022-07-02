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
    public partial class supprimertarif : Form
    {
        public supprimertarif()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string categorie = comboBox2.Text;
            string tkm = textBox1.Text;
            string tlj = textBox7.Text;
            string tht = textBox6.Text;
            string tch = textBox5.Text;
            MessageBox.Show("categorie=" + categorie + "\t tkm=" + tkm + "\t tlj=" + tlj + "\t tht=" + tht + "\t tch=" + tch);
        }
    }
}
