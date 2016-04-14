using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        string idDvd;
        string titreDvd;
        string dureeDvd;
        string idgenreDVD;
        string genreDvd;
        
       
        public Form1()
        {
            InitializeComponent();

            // Connexion a la base de donnees.
            string chaineConnexion = "server=localhost;user id=root;database=bdddvd;PASSWORD=";
            ConnexionSql crs = new ConnexionSql(chaineConnexion);
            ConnexionSql crs2 = new ConnexionSql(chaineConnexion);
            ConnexionSql crs3 = new ConnexionSql(chaineConnexion);

            // ************ Affichage Titre film dans la listeBox ************ //
            // Requete sql.
            crs.reqSelect("select * from dvd");
       

            // Boucle tant que.
            while (!crs.fin())
            {
                // Affichge de chaque titre de film.
                this.LstDvd.Items.Add((crs.champ("NUMDVD")).ToString());
                // On passe a la ligne suivante.
                crs.suivant();
            }
            // Fermeture de la connexion.
            crs.close();

            // ************ Affichage Nom Acteur dans comboBox ************ //
            crs2.reqSelect("select nom from acteur");

            // Boucle tant que.
            while (!crs2.fin())
            {
                // Affichge de chaque titre de film.
                this.cboActeur.Items.Add((crs2.champ("nom")).ToString());
                // On passe a la ligne suivante.
                crs2.suivant();
            }
            // Fermeture de la connexion.
            crs2.close();

            // ************ Affichage Type Genre dans comboBox ************ //
            crs3.reqSelect("select libelle from genre");
            // Boucle tant que.
            while (!crs3.fin())
            {
                // Affichge de chaque titre de film.
                this.cboGenre.Items.Add((crs3.champ("libelle")).ToString());
                // On passe a la ligne suivante.
                crs3.suivant();
            }
            // Fermeture de la connexion.
            crs3.close();


    }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ************ Gestion d'affichage des informations d'un film ************ //
            if (this.LstDvd.SelectedItem != null)
            {

                // Reset des valeurs.
                this.idDvd = "";
                this.titreDvd = "";
                this.dureeDvd = "";
                this.idgenreDVD = "";
                this.genreDvd = "";

                // Vide la liste pour chaque appel.
                lstActeur.Items.Clear();

                // Chaine de connexion
                string chaineConnexion = "server=localhost;user id=root;database=bdddvd;PASSWORD=";
                // Nouvelles instances.
                ConnexionSql crs4 = new ConnexionSql(chaineConnexion);
                ConnexionSql crs5 = new ConnexionSql(chaineConnexion);
                ConnexionSql crs6 = new ConnexionSql(chaineConnexion);

                // Requete pour le titre et la duree.
                crs4.reqSelect("SELECT * FROM dvd WHERE NUMDVD = '" + ((string)LstDvd.SelectedItem) + "'");
                // Requete pour le libelle
                crs6.reqSelect("SELECT * FROM genre WHERE numgenre = (SELECT numgenre FROM dvd WHERE numdvd = '" + ((string)LstDvd.SelectedItem) + "')");
                // Requette pour les noms des acteurs
                crs5.reqSelect("SELECT * FROM acteur WHERE numacteur IN (SELECT numacteur FROM acteur_DVD WHERE numdvd = '" + ((string)LstDvd.SelectedItem) + "')");

                // Je remets les valeurs pour les elements.
                this.idDvd = ((string)LstDvd.SelectedItem);
                this.titreDvd = crs4.champ("titre").ToString();
                this.dureeDvd = crs4.champ("duree").ToString();
                this.genreDvd = crs6.champ("libelle").ToString();
                this.idgenreDVD = crs6.champ("numgenre").ToString();

                // Je passe les valeurs aux differents elements
                txtTitre.Text = titreDvd;
                txtDuree.Text = dureeDvd;
                cboGenre.Text = genreDvd;

                // Boule tant que pour la liste des acteurs.
                while (!crs5.fin())
                {
                    // Affichge de chaque titre de film.
                    this.lstActeur.Items.Add((crs5.champ("nom")).ToString());
                    // On passe a la ligne suivante.
                    crs5.suivant();
                }

                // Fermeture de la connexion.
                crs6.close();
                crs5.close();
                crs4.close();
            }
        }

        public void btnModifDvd_Click(object sender, EventArgs e)
        {
            if (this.LstDvd.SelectedItem != null)
            {
                string chaineConnexion = "server=localhost;user id=root;database=bdddvd;PASSWORD=";
                ConnexionSql crs = new ConnexionSql(chaineConnexion);
                crs.reqUpdate("UPDATE dvd SET numgenre = '" + idgenreDVD  + "', titre = '" + txtTitre.Text + "', duree = '" + txtDuree.Text + "' WHERE numdvd =  '" + idDvd + "'");
                crs.close();
                MessageBox.Show("Les modifications ont ete effectuees", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun film selectionne","Erreur",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }

        private void btnSupprDvd_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {


        }

        private void cboActeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.genreDvd = cboGenre.Text;

            string chaineConnexion = "server=localhost;user id=root;database=bdddvd;PASSWORD=";
            ConnexionSql crs = new ConnexionSql(chaineConnexion);

            crs.reqSelect("SELECT libelle FROM genre WHERE numgenre = (SELECT numgenre FROM genre WHERE numdvd = '" + genreDvd + "')");

            this.genreDvd = crs.champ("numgenre").ToString();

            crs.close();
        }

        private void lstActeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutDvd_Click(object sender, EventArgs e)
        {
        }
    }
}
