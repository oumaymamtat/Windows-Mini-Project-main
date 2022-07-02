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
    public partial class agent : Form
    {
        public agent()
        {
            InitializeComponent();
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterclient a = new ajouterclient();
            this.Hide();
            a.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AjouterUnContratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutercontrat a = new ajoutercontrat();
            this.Hide();
            a.Show();
        }

        private void ModifierUnContratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifiercontrat m = new modifiercontrat();
            this.Hide();
            m.Show();
        }

        private void SupprimerUnContratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimercontrat s = new supprimercontrat();
            this.Hide();
            s.Show();
        }

        private void ModifierUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierclient m = new modifierclient();
            this.Hide();
            m.Show();
        }

        private void SupprimerUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerclient s = new supprimerclient();
            this.Hide();
            s.Show();
        }

        private void AjouterUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterfacture a = new ajouterfacture();
            this.Hide();
            a.Show();
        }

        private void ModifierUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierfacture m = new modifierfacture();
            this.Hide();
            m.Show();
        }

        private void SupprimerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerfacture s = new supprimerfacture();
            this.Hide();
            s.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string etat = comboBox1.Text;
            string categorie = comboBox2.Text;
            string dbd = dateTimePicker1.Text;
            string dbf = dateTimePicker2.Text;
            string acc = comboBox3.Text;
            MessageBox.Show("etat=" + etat + "\t categorie=" + categorie + "\t dbd=" + dbd + "\t dbf=" + dbf + "\t acc=" + acc);
        }
    }
}
