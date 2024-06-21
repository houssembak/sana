using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionstock3
{
    public partial class FichePlanification : Form
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

        public FichePlanification()
        {
            InitializeComponent();
       
        }



        private void FichePlanification_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Chaîne de connexion à la base de données
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            // Charger les codes de planification dans le ComboBox
            System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
            string query = "SELECT code_planification FROM calculplanification";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["code_planification"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la récupération des codes de planification : " + ex.Message);
                    return;
                }
            }

            // Afficher le ComboBox dans une MessageBox
            Form form = new Form();
            form.Text = "Sélectionner un code de planification";
            form.Width = 300;
            form.Height = 150;
            comboBox.Dock = DockStyle.Fill;
            form.Controls.Add(comboBox);

            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            buttonOk.Text = "OK";
            buttonOk.Dock = DockStyle.Bottom;
            buttonOk.DialogResult = DialogResult.OK;
            form.Controls.Add(buttonOk);
            form.AcceptButton = buttonOk;
            if (form.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            // Récupérer la valeur sélectionnée dans le ComboBox
            string input = comboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Le code planification est obligatoire pour continuer.");
                return;
            }

            // Requête pour vérifier si le code article existe dans la table productionplanification
            string queryProductionPlanification = @"
                  SELECT 
                      code_article, 
                          qte_produire, 
                         Date_commence, 
                             OF
                                 FROM 
                            productionplanification 
                                         WHERE 
                                    code_planification = @code_planification";

                                     string queryCalculPlanification = @"
                                      SELECT 
                                                 code_planification 
                                                   FROM 
                                                    calculplanification 
                                      WHERE 
                                      code_planification = @code_planification";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Validate the code_planification
                    using (MySqlCommand cmd = new MySqlCommand(queryCalculPlanification, connection))
                    {
                        cmd.Parameters.AddWithValue("@code_planification", input);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Code planification non trouvé dans la base de données.");
                                return;
                            }
                        }
                    }

                    // Première requête - Fetch production planification details
                    using (MySqlCommand cmd = new MySqlCommand(queryProductionPlanification, connection))
                    {
                        cmd.Parameters.AddWithValue("@code_planification", input);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox2.Text = reader["code_article"].ToString();
                                txtQuantiteAProduire.Text = reader["qte_produire"].ToString();
                                textBox3.Text = reader["Date_commence"].ToString();
                                textBox1.Text = reader["OF"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Code article non trouvé dans la base de données.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
                }
            }

            // Configuration initiale du DataGridView
            ConfigurerDataGridView();
            RemplirDataGridView(input);
        }

        private void ConfigurerDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("date", "date de saisie");
            dataGridView1.Columns.Add("quantite_produite_journaliere", "quantité produite journalière");
            dataGridView1.Columns.Add("quantite_restante", "quantité restante");
            dataGridView1.Columns.Add("date_livraison_es", "date livraison théorique");
            dataGridView1.Columns.Add("date_livraison_reele", "date livraison pratique");
            dataGridView1.Columns.Add("rendement", "rendement en %");
            dataGridView1.Columns.Add("machine", "machine");
            dataGridView1.Columns.Add("avancement", "avancement en %");

        }
        private void RemplirDataGridView(string codePlanification)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = @"
SELECT 
    cp.date_jour, 
    cp.qte_produit, 
    cp.qte_Restantes, 
    cp.date_livraison,
    cp.Rendement, 
    cp.code_planification,
    cp.avancement,  -- Ajout de l'attribut avancement
    pp.Nb_jour_estimé,
    pp.Date_commence,
    pp.machines
FROM 
    calculplanification cp
JOIN 
    productionplanification pp ON cp.code_planification = pp.code_planification
WHERE 
    cp.code_planification = @codePlanification";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Exécute la requête
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codePlanification", codePlanification);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();

                        while (reader.Read())
                        {
                            // Récupère Nb_jour_estimé et décrémente de 1 pour obtenir R
                            int nbJourEstime = int.Parse(reader["Nb_jour_estimé"].ToString());
                            int R = nbJourEstime - 1;

                            // Récupère Date_commence
                            string dateCommenceString = reader["Date_commence"].ToString();
                            DateTime dateCommence;
                            if (!DateTime.TryParseExact(dateCommenceString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateCommence))
                            {
                                throw new FormatException($"La chaîne '{dateCommenceString}' n'a pas été reconnue en tant que DateTime valide.");
                            }

                            // Calcule DateCalcul
                            DateTime dateCalcul = dateCommence.AddDays(R);

                            // Format des dates
                            string dateJourFormatted = DateTime.Parse(reader["date_jour"].ToString()).ToString("dd-MM-yyyy");
                            string dateLivraisonFormatted = DateTime.Parse(reader["date_livraison"].ToString()).ToString("dd-MM-yyyy");
                            string dateCalculFormatted = dateCalcul.ToString("dd-MM-yyyy");

                            dataGridView1.Rows.Add(
                                dateJourFormatted,
                                reader["qte_produit"].ToString(),
                                reader["qte_Restantes"].ToString(),
                                dateCalculFormatted,
                                dateLivraisonFormatted,
                                reader["Rendement"].ToString(),
                                reader["machines"].ToString(),
                                reader["avancement"].ToString());
                        }
                    }
                }

                // Ferme la connexion après avoir terminé toutes les opérations avec la base de données
                conn.Close();
            }
        }


        /*   private void RemplirDataGridView(string codePlanification)
           {
               string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
               string query = @"
                SELECT 
                    DATE_FORMAT(cp.date_jour, '%Y-%m-%d') AS date_jour, 
                    cp.qte_produit, 
                     cp.qte_Restantes, 
                     DATE_FORMAT(cp.date_livraison, '%Y-%m-%d') AS date_livraison,
                     cp.Rendement, 
                         cp.code_planification,
                         pp.Nb_jour_estimé,
                         DATE_FORMAT(pp.Date_commence, '%Y-%m-%d') AS Date_commence,
                     pp.machines
                       FROM 
                               calculplanification cp
                            JOIN 
                        productionplanification pp ON cp.code_planification = pp.code_planification
                           WHERE 
                             cp.code_planification = @codePlanification";

               using (MySqlConnection conn = new MySqlConnection(connectionString))
               {
                   conn.Open();

                   // Exécute la requête
                   using (MySqlCommand cmd = new MySqlCommand(query, conn))
                   {
                       cmd.Parameters.AddWithValue("@codePlanification", codePlanification);

                       using (MySqlDataReader reader = cmd.ExecuteReader())
                       {
                           dataGridView1.Rows.Clear();

                           while (reader.Read())
                           {
                               // Récupère Nb_jour_estimé et décrémente de 1 pour obtenir R
                               int nbJourEstime = int.Parse(reader["Nb_jour_estimé"].ToString());
                               int R = nbJourEstime - 1;

                               // Récupère Date_commence
                               string dateCommenceString = reader["Date_commence"].ToString();
                               DateTime dateCommence;
                               if (!DateTime.TryParseExact(dateCommenceString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateCommence))
                               {
                                   throw new FormatException($"La chaîne '{dateCommenceString}' n'a pas été reconnue en tant que DateTime valide.");
                               }

                               // Calcule DateCalcul
                               DateTime dateCalcul = dateCommence.AddDays(R);

                               string DateCalcul = dateCalcul.ToString("yyyy-MM-dd");

                               dataGridView1.Rows.Add(
                                   reader["date_jour"].ToString(),
                                   reader["qte_produit"].ToString(),
                                   reader["qte_Restantes"].ToString(),
                                   DateCalcul,
                                   reader["date_livraison"].ToString(),
                                   reader["Rendement"].ToString(),
                                   reader["machines"].ToString());
                           }
                       }
                   }

                   // Ferme la connexion après avoir terminé toutes les opérations avec la base de données
                   conn.Close();
               }
           }
           */







        private void txtProductionHoraire_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
