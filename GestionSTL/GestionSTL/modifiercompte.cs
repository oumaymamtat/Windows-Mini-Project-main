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
    public partial class modifiercompte : Form
    {
        public modifiercompte()
        {
            InitializeComponent();
        }

        private void Modifiercompte_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string mdp = textBox2.Text;
            MessageBox.Show("login =" + login + "\t mdp =" + mdp);
            string nouvlogin = textBox3.Text;
            string nouvmdp = textBox4.Text;
            MessageBox.Show("nouvlogin" + nouvlogin + "\t nouvmdp" + nouvmdp);
        }
    }
}
