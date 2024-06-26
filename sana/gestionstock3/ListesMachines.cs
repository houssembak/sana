﻿using MySql.Data.MySqlClient;
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
    public partial class ListesMachines : Form
    {
        public ListesMachines()
        {
            InitializeComponent();
        }

        private void ListesMachines_Load(object sender, EventArgs e)
        {
            // Configuration initiale du DataGridView
            ConfigurerDataGridView();

            // Remplir le DataGridView avec les données des articles
            RemplirDataGridView();
        }
        private void ConfigurerDataGridView()
        {
            // Ajout des colonnes au DataGridView
            dataGridView1.Columns.Add("code", "code");
            dataGridView1.Columns.Add("marque", "marque");
            dataGridView1.Columns.Add("tisserand", "tisserand");
            dataGridView1.Columns.Add("nbreesouples", "nbreesouples");
            dataGridView1.Columns.Add("Etat", "Etat");
            dataGridView1.Columns.Add("Date_commence", "Date_commence");
            dataGridView1.Columns.Add("date_disponibilite", "date_disponibilite");
           

            // Réglez les propriétés supplémentaires des colonnes si nécessaire
            // Exemple : dataGridView1.Columns["reference"].Width = 100;
        }
        private void RemplirDataGridView()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT `code`, `marque`, `tisserand`, `nbreesouples`, `Etat`, `date_disponibilite`, `Date_commence` FROM parcmachine";

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
                            string dateDisponibilite = reader["date_disponibilite"].ToString(); // Récupération de la valeur de l'attribut date_disponibilite

                            // Vérification de la valeur de l'attribut date_disponibilite et attribution du texte approprié à Etat
                            string etatAffiche = string.IsNullOrEmpty(dateDisponibilite) ? "En arrêt" : "En marche";

                            // Ajout de la ligne dans le DataGridView avec le texte approprié pour l'attribut Etat
                            dataGridView1.Rows.Add(
                                reader["code"].ToString(),
                                reader["marque"].ToString(),
                                reader["tisserand"].ToString(),
                                reader["nbreesouples"].ToString(),
                                etatAffiche, // Utilisation du texte approprié basé sur la valeur de l'attribut date_disponibilite
                                reader["Date_commence"].ToString(),
                                dateDisponibilite
                            );
                        }
                    }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Ajoutez ce champ de classe pour stocker le code de la machine filtré





    }
}