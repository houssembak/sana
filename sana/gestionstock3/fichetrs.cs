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
    public partial class fichetrs : Form
    {
        public fichetrs()
        {
            InitializeComponent();
        }

        private void fichetrs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chaîne de connexion à la base de données
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            // Charger les codes de planification dans le ComboBox
            System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
            string query = "SELECT nom_machine FROM trs";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["nom_machine"].ToString());
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

            // Nouvelle requête pour récupérer les données du nom_machine sélectionné
            string querySelectedMachine = "SELECT date_jour, nom_machine, nom_tisserand, OF, designation, reference, trs FROM trs WHERE nom_machine = @nom_machine";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(querySelectedMachine, connection);
                    cmd.Parameters.AddWithValue("@nom_machine", input);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();

                    // Afficher les données dans le DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la récupération des données : " + ex.Message);
                }
            }
        }

        private void ConfigurerDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("date", "date de jour");
            dataGridView1.Columns.Add("quantite_produite_journaliere", "quantité produite journalière");
            dataGridView1.Columns.Add("quantite_restante", "quantité restante");
            dataGridView1.Columns.Add("date_livraison_es", "date livraison théorique");
            dataGridView1.Columns.Add("date_livraison_reele", "date livraison pratique");
            dataGridView1.Columns.Add("rendement", "rendement en %");
            dataGridView1.Columns.Add("machine", "machine");
            dataGridView1.Columns.Add("avancement", "avancement en %");

        }
    }
}
