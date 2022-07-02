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
    public partial class supprimercompte : Form
    {
        public supprimercompte()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string mdp = textBox2.Text;
            MessageBox.Show("login =" + login + "\t mdp =" + mdp);
        }
    }
}
