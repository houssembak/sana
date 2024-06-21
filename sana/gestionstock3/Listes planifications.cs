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
    public partial class Listes_planifications : Form
    {
        public Listes_planifications()
        {
            InitializeComponent();
            // Configuration initiale du DataGridView
            ConfigurerDataGridView();

            // Remplir le DataGridView avec les données des articles
            RemplirDataGridView();
        }
        private void ConfigurerDataGridView()
        {
            // Ajout des colonnes au DataGridView
            dataGridView1.Columns.Add("code_planification", "code_planification");
            dataGridView1.Columns.Add("code_article", "code_article");
            dataGridView1.Columns.Add("qte_produire", "qte_produire");
            dataGridView1.Columns.Add("production_horaire", "production_horaire");
            dataGridView1.Columns.Add("Nb_jour_estimé", "Nb_jour_estimé");
            dataGridView1.Columns.Add("Production_journalier", "Production_journalier");
            dataGridView1.Columns.Add("nombre_de_bande", "nombre_de_bande");
            dataGridView1.Columns.Add("machines", "machines");
            dataGridView1.Columns.Add("Date_commence", "Date_commence");
            dataGridView1.Columns.Add("OF", "OF");



            // Réglez les propriétés supplémentaires des colonnes si nécessaire
            // Exemple : dataGridView1.Columns["reference"].Width = 100;
        }
        private void RemplirDataGridView()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            // Assurez-vous que cette requête correspond aux noms de colonnes dans votre base de données
            string query = "SELECT `code_planification`, `code_article`, `qte_produire`, `production_horaire`, `Nb_jour_estimé`, `Production_journalier`, `nombre_de_bande`,`machines`,`Date_commence`,`OF`  FROM productionplanification";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["code_planification"].ToString(),
                                reader["code_article"].ToString(),
                                reader["qte_produire"].ToString(),
                                reader["production_horaire"].ToString(),
                                reader["Nb_jour_estimé"].ToString(),
                                 reader["Production_journalier"].ToString(),
                                reader["nombre_de_bande"].ToString(),
                                reader["machines"].ToString(),
                                 reader["Date_commence"].ToString(),
                                  reader["OF"].ToString()
                                  

                            );
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
