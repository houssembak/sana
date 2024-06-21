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
    public partial class TRSMachines : Form
    {
        public TRSMachines()
        {
            InitializeComponent();
            RemplirComboBox();
            RemplirComboBox1();
            RemplirComboBox12();
            RemplirComboBox123();
            RemplirComboBox1234();

        }
        private void RemplirComboBox()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT code FROM tisserands";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["code"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox1()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT code FROM parcmachine";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["code"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox12()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT OF FROM commande";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["OF"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox123()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT designation FROM commande";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox4.Items.Add(reader["designation"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox1234()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT reference FROM articles";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox5.Items.Add(reader["reference"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrEmpty(textBox13.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox12.Text, out decimal valeur1) && decimal.TryParse(textBox13.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 / valeur2;

                    // Afficher le résultat dans textBox3
                    textBox8.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox13.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox10.Text, out decimal valeur1) && decimal.TryParse(textBox13.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 / valeur2;

                    // Afficher le résultat dans textBox3
                    textBox9.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

                // Assurez-vous que les TextBox ne sont pas vides
                if (!string.IsNullOrEmpty(textTt.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    // Essayer de convertir les textes en nombres
                    if (decimal.TryParse(textTt.Text, out decimal valeur1) && decimal.TryParse(textBox2.Text, out decimal valeur2))
                    {
                        // Effectuer la soustraction
                        decimal resultat = valeur1 - valeur2;

                        // Afficher le résultat dans textBox3
                        textBox3.Text = resultat.ToString("F2");
                    }
                    else
                    {
                        // Afficher un message d'erreur si la conversion échoue
                        MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Afficher un message d'erreur si les TextBox sont vides
                    MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Assurez-vous que les TextBox ne sont pas vides
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox7.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox3.Text, out decimal valeur1) && decimal.TryParse(textBox7.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 - valeur2;

                    // Afficher le résultat dans textBox3
                    textBox4.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox11.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox10.Text, out decimal valeur1) && decimal.TryParse(textBox11.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 - valeur2;

                    // Afficher le résultat dans textBox3
                    textBox12.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrEmpty(textBox9.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox8.Text, out decimal valeur1) && decimal.TryParse(textBox9.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = (valeur1 / valeur2) * 100;

                    // Afficher le résultat dans textBox3
                    textBox6.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TRSMachines_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox4.Text, out decimal valeur1) && decimal.TryParse(textBox3.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = (valeur1 / valeur2) * 100;

                    // Afficher le résultat dans textBox3
                    textBox14.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox9.Text, out decimal valeur1) && decimal.TryParse(textBox4.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = (valeur1 / valeur2) * 100;

                    // Afficher le résultat dans textBox3
                    textBox15.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Récupérer les valeurs des contrôles
            string date_jour = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string nom_machine = comboBox2.SelectedItem.ToString();
            string nom_tisserand = comboBox1.SelectedItem.ToString();
            string tt = textTt.Text;
            string tprevu = textBox2.Text;
            string tr = textBox3.Text;
            string timprevu = textBox7.Text;
            string tf = textBox4.Text;
            string Msorti = textBox10.Text;
            string MNonconfirme = textBox11.Text;
            string Mconforme = textBox12.Text;
            string Vprocess = textBox13.Text;
            string OF = comboBox3.SelectedItem.ToString();
            string designation = comboBox4.SelectedItem.ToString();
            string reference = comboBox5.SelectedItem.ToString();
            string tb = textBox9.Text;
            string tu = textBox8.Text;
            string do_ = textBox14.Text; // do est un mot réservé en C#, utilisez do_
            string tp = textBox15.Text;
            string tq = textBox6.Text;
            string trs = textBox1.Text;

            string query = "INSERT INTO trs (date_jour, nom_machine, nom_tisserand, tt, tprevu, tr, timprevu, tf, Msorti, MNonconfirme, Mconforme, Vprocess, OF, designation, reference, tb, tu, do, tp, tq, trs) " +
                           "VALUES (@date_jour, @nom_machine, @nom_tisserand, @tt, @tprevu, @tr, @timprevu, @tf, @Msorti, @MNonconfirme, @Mconforme, @Vprocess, @OF, @designation, @reference, @tb, @tu, @do, @tp, @tq, @trs)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Ajouter les paramètres
                    cmd.Parameters.AddWithValue("@date_jour", date_jour);
                    cmd.Parameters.AddWithValue("@nom_machine", nom_machine);
                    cmd.Parameters.AddWithValue("@nom_tisserand", nom_tisserand);
                    cmd.Parameters.AddWithValue("@tt", tt);
                    cmd.Parameters.AddWithValue("@tprevu", tprevu);
                    cmd.Parameters.AddWithValue("@tr", tr);
                    cmd.Parameters.AddWithValue("@timprevu", timprevu);
                    cmd.Parameters.AddWithValue("@tf", tf);
                    cmd.Parameters.AddWithValue("@Msorti", Msorti);
                    cmd.Parameters.AddWithValue("@MNonconfirme", MNonconfirme);
                    cmd.Parameters.AddWithValue("@Mconforme", Mconforme);
                    cmd.Parameters.AddWithValue("@Vprocess", Vprocess);
                    cmd.Parameters.AddWithValue("@OF", OF);
                    cmd.Parameters.AddWithValue("@designation", designation);
                    cmd.Parameters.AddWithValue("@reference", reference);
                    cmd.Parameters.AddWithValue("@tb", tb);
                    cmd.Parameters.AddWithValue("@tu", tu);
                    cmd.Parameters.AddWithValue("@do", do_);
                    cmd.Parameters.AddWithValue("@tp", tp);
                    cmd.Parameters.AddWithValue("@tq", tq);
                    cmd.Parameters.AddWithValue("@trs", trs);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Données insérées avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox8.Text, out decimal valeur1) && decimal.TryParse(textBox3.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 / valeur2;

                    // Afficher le résultat dans textBox3
                    textBox1.Text = resultat.ToString();
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
