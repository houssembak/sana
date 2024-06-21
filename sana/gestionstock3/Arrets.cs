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

namespace gestionstock3
{
    public partial class Arrets : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

        public Arrets()
        {
            InitializeComponent();
        }

        private void ChargerDataGridView()
        {
            try
            {
                // Vider le DataGridView avant de charger les nouvelles données
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, Arret, Machines, temps, causes, Remède,frequence FROM arret";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Masquer la colonne ID
                        dataGridView1.Columns["id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private bool LigneExisteDeja(MySqlConnection conn, DataGridViewRow row)
        {
            string query = "SELECT COUNT(*) FROM arret WHERE Arret = @Arret AND Machines = @Machines AND temps = @temps AND causes = @causes AND Remède = @Remède AND frequence=@frequence";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Arret", row.Cells["Arret"].Value);
                cmd.Parameters.AddWithValue("@Machines", row.Cells["Machines"].Value);
                cmd.Parameters.AddWithValue("@temps", row.Cells["temps"].Value);
                cmd.Parameters.AddWithValue("@causes", row.Cells["causes"].Value);
                cmd.Parameters.AddWithValue("@Remède", row.Cells["Remède"].Value);
                cmd.Parameters.AddWithValue("@frequence", row.Cells["frequence"].Value);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            if (!LigneExisteDeja(conn, row))
                            {
                                string query = "INSERT INTO arret (Arret, Machines, temps, causes, Remède,frequence) VALUES (@Arret, @Machines, @temps, @causes, @Remède,@frequence)";
                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Arret", row.Cells["Arret"].Value);
                                    cmd.Parameters.AddWithValue("@Machines", row.Cells["Machines"].Value);
                                    cmd.Parameters.AddWithValue("@temps", row.Cells["temps"].Value);
                                    cmd.Parameters.AddWithValue("@causes", row.Cells["causes"].Value);
                                    cmd.Parameters.AddWithValue("@Remède", row.Cells["Remède"].Value);
                                    cmd.Parameters.AddWithValue("@frequence", row.Cells["frequence"].Value);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Les nouvelles données ont été insérées avec succès.");
                ChargerDataGridView(); // Recharge les données après insertion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void Arrets_Load(object sender, EventArgs e)
        {
            ChargerDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
