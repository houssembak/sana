using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionstock3
{
    public partial class ModifierArticles : Form
    {
        public ModifierArticles()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string reference = Microsoft.VisualBasic.Interaction.InputBox("Entrez la référence  de votre Article  :", "Réference Article", "");

            // Vérifier si l'utilisateur a saisi une valeur
            if (!string.IsNullOrEmpty(reference))
            {

                ChargerDonnees(reference);
            }
            else
            {
                MessageBox.Show("Vous devez entrer un ID de planification.");
            }
        }
        public void ChargerDonnees(string reference)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, reference, designation, largeur,productionhoraires FROM articles WHERE reference = @reference";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@reference", reference);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["id"].ToString();
                                txtreference.Text = reader["reference"].ToString();
                                txtdesignation.Text = reader["designation"].ToString();
                                txtlargeur.Text = reader["largeur"].ToString();
                                txtepaisseur.Text = reader["productionhoraires"].ToString();
                           
                            }
                            else
                            {
                                MessageBox.Show("Aucune donnée trouvée pour la référence spécifiée.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de la connexion à la base de données : {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmez-vous la modification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
                    string updateQuery = "UPDATE articles SET id=@id,reference=@reference, designation=@designation, largeur=@largeur, productionhoraires=@productionhoraires  WHERE id = @id";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", textBox1.Text);
                            command.Parameters.AddWithValue("@reference", txtreference.Text);
                            command.Parameters.AddWithValue("@designation", txtdesignation.Text);
                            command.Parameters.AddWithValue("@largeur", txtlargeur.Text);
                            command.Parameters.AddWithValue("@productionhoraires", textBox1.Text);


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Modification enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Aucune modification n'a été enregistrée.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de l'enregistrement de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur générale est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtmetragefilretenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttiragefiltrame_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmetragefilchaine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmetragefiltrame_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlargeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtepaisseur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttiragefilchaine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtallongement_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtreference_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttiragefilretenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ModifierArticles_Load(object sender, EventArgs e)
        {

        }
    }
}
