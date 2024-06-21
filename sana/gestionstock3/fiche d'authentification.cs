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
using System.Security.Cryptography;

namespace gestionstock3
{
    public partial class Form1 : Form
    {
        /* ligne de configuration de la base de données */
        MySqlConnection connexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=devnet");

        private bool passwordVisible = false; // Variable pour suivre l'état de visibilité du mot de passe

        public Form1()
        {
            InitializeComponent();
            temotdepasse.PasswordChar = '*'; // Configurer le champ de mot de passe pour afficher des *
                                             // Configurer l'image de la PictureBox au départ
            pictureBoxPassword.Size = new Size(41, 40); // Définir la taille de la PictureBox
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage; // Définir le mode de taille de l'image
            pictureBoxPassword.Image = Properties.Resources.eye; // Utiliser l'image de l'œil fermé par défaut

            // Ajouter l'événement de clic
            pictureBoxPassword.Click += new EventHandler(pictureBoxPassword_Click);

        }
        private void pictureBoxPassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible; // Inverser l'état de visibilité du mot de passe

            if (passwordVisible)
            {
                temotdepasse.PasswordChar = '\0'; // Afficher le texte du mot de passe
                pictureBoxPassword.Image = Properties.Resources.eye; // Changer l'icône pour l'œil ouvert
            }
            else
            {
                temotdepasse.PasswordChar = '*'; // Masquer le texte du mot de passe
                pictureBoxPassword.Image = Properties.Resources.eye; // Changer l'icône pour l'œil fermé
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                // Si l'utilisateur clique sur "Oui", fermer l'interface
                this.Close();
            }
            // Si l'utilisateur clique sur "Non", ne rien faire (rester sur l'interface)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        /* Connexion avec l'utilisateur et son mot de passe */
        private void button1_Click(object sender, EventArgs e)
        {
            connexion.Open(); /* Ouvrir la base de données */
            /* Sélectionner les utilisateurs et leurs mots de passe pour l'authentification */
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE user='" + textuser.Text + "'AND password='" + temotdepasse.Text + "'", connexion);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            connexion.Close();

            if (dt.Rows[0][0].ToString() == "1")
            {
                /* Si l'utilisateur et le mot de passe sont corrects, afficher le message */
                MessageBox.Show("Vous faites partie du système", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ouvrir l'interface MDIParent
                MDIParent1 mdiParent = new MDIParent1();

                this.Hide(); // Cacher la fenêtre de connexion
                mdiParent.Show(); // Afficher la fenêtre MDIParent
            }
            else
            {
                /* Si l'utilisateur ou le mot de passe est incorrect, afficher le message */
                MessageBox.Show("Mot de passe ou nom d'utilisateur incorrect", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

    }
}
