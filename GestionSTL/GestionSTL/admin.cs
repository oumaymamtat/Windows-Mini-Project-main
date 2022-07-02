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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void visiterTousLesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void modifierUnParcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifiervehicule m = new modifiervehicule();
            this.Hide();
            m.Show();
        }

        private void supprimerUnParcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimervehicule s = new supprimervehicule();
            this.Hide();
            s.Show();
        }

        private void AjouterUnParcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutervehicule a = new ajoutervehicule();
            this.Hide();
            a.Show();
        }

        private void AjouterUnTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutertarif a = new ajoutertarif();
            this.Hide();
            a.Show();
        }

        private void ModifierUnTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifiertarif m = new modifiertarif();
            this.Hide();
            m.Show();
        }

        private void SupprimerUnTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimertarif s = new supprimertarif();
            this.Hide();
            s.Show();
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutercompte a = new ajoutercompte();
            this.Hide();
            a.Show();
        }

        private void ModifierUnCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifiercompte m = new modifiercompte();
            this.Hide();
            m.Show();
        }

        private void SupprimerUnCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimercompte s = new supprimercompte();
            this.Hide();
            s.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string etat = comboBox1.Text;
            string categorie = comboBox2.Text;
            string dbd = dateTimePicker1.Text;
            string dbf = dateTimePicker2.Text;
            string  acc =comboBox3.Text;
            MessageBox.Show("etat=" + etat+ "\t categorie=" + categorie+ "\t dbd=" + dbd+ "\t dbf=" + dbf+ "\t acc=" + acc);
            string server = "localhost";
            string database = "stl";
            string user = "root";
            string password = " ";
            string cnnstr = "database = " + database + "; server = " + server + "; user = " + user + "; password =" + password;
            MySqlConnection cnn = new MySqlConnection(cnnstr);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("select vahicule.num_chassis , marque , categorie , etat , nbkm , nbh from vahicule , contrat where vahicule.num_chassis=contrat.num_chassis and vahicule.etat ='" + etat + "' and vahicule.categorie= '" + categorie + "' and contrat.datedeb_loc = '" + dbd + "' and contrat.date_retour = '" + dbf + "' and contrat.chauffeur = '" + acc+"' ;",cnn);
            MySqlDataReader r = cmd.ExecuteReader();
            MessageBox.Show("commande execute");
            if (r != null)
            {
                MessageBox.Show("vehicule existe");
               
                while (r.Read())
                {
                    MessageBox.Show("informations du vehicule cherche \n num_chassis = " + r["num_chassis"] + "\t marque = " + r["marque"] + "\t categorie=" + r["categorie"] + " etat =" + r["etat"] + "\t nbkm =" + r["nbkm"] + "\t nbh =" + r["nbh"]);
                }
                r.Close();
             }
            else
                MessageBox.Show("vehicule n'existe pas");

            cnn.Close();
            MessageBox.Show("nouvelle recherche !");

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
