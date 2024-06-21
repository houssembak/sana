using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Assurez-vous d'importer le bon namespace pour les types MySQL

namespace gestionstock3
{
    public partial class AjoutArticle : Form

    {

        public AjoutArticle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AjoutArticle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtreference.Text) ||
                string.IsNullOrEmpty(txtdesignation.Text) || 
                 string.IsNullOrEmpty(textBox1.Text))




            {
                // Afficher un message d'erreur si un champ est vide
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Arrêter l'exécution de la méthode
            }
            // Récupérer les valeurs des champs de texte
            string reference = txtreference.Text;
              string designation = txtdesignation.Text;
          
              string productionhoraire = textBox1.Text;
         

              string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Requête d'insertion SQL
            string query = "INSERT INTO articles (reference, designation,productionhoraires) " +
             "VALUES (@reference, @designation,@productionhoraires )";

            // Création de la commande SQL avec paramètres
            using (MySqlConnection connection = new MySqlConnection(connectionString))

              {
                  using (MySqlCommand command = new MySqlCommand(query, connection))
                  {
                      // Ouvrir la connexion
                      connection.Open();
                      command.Parameters.AddWithValue("@reference", reference);
                      command.Parameters.AddWithValue("@designation", designation);
                
                      command.Parameters.AddWithValue("@productionhoraires", productionhoraire);
            
                      // Exécuter la commande
                      command.ExecuteNonQuery();

                      // Fermer la connexion
                      connection.Close();
                    // Afficher un message ou effectuer une action après l'insertion des données
                    MessageBox.Show("Article ajouté avec succès.");
                    txtreference.Text="";
                    txtdesignation.Text = "";
               
                    textBox1.Text = "";
                 


                }
              }
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
    }
}
    

