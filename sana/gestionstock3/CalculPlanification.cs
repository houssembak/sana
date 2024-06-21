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
using Microsoft.VisualBasic;
using WinForms = System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestionstock3
{
    public partial class CalculPlanification : Form
    {
        private MySqlConnection connection;
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
        public CalculPlanification()
        {
            InitializeComponent();
            RemplirComboBox12();
        }
        private void RemplirComboBox12()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT code_planification FROM productionplanification";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtcodeplanification.Items.Add(reader["code_planification"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        public void ChargerDonnees(string idPlanification)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Production_journalier, nombre_de_bande,qte_produire,Nb_jour_estimé,machines FROM productionplanification WHERE id_planification=@idPlanification"; // Remplacez 'votreCondition' par une condition réelle si nécessaire

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idPlanification", idPlanification);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de la connexion à la base de données : {ex.Message}");
                }
            }
        }
        private string idPlanificationGlobal;
        private void button1_Click(object sender, EventArgs e)
        {
            string idPlanification = Microsoft.VisualBasic.Interaction.InputBox("Entrez l'ID de planification :", "ID de Planification", "");

            // Vérifier si l'utilisateur a saisi une valeur
            if (!string.IsNullOrEmpty(idPlanification))
            {
                idPlanificationGlobal = idPlanification;
                ChargerDonnees(idPlanification);
            }
            else
            {
                MessageBox.Show("Vous devez entrer un ID de planification.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir les valeurs des TextBox1, TextBox2, TextBox5 et TextBox8 en entiers
                if (int.TryParse(textBox8.Text, out int valeurTextBox8Int) &&
                    int.TryParse(textBox1.Text, out int valeurTextBox1Int) &&
                    int.TryParse(textBox5.Text, out int valeurTextBox5Int) &&
                    int.TryParse(textBox2.Text, out int valeurTextBox2Int))
                {
                    // Vérifier si textBox1 est égal à 0
                    if (valeurTextBox1Int == 0)
                    {
                        MessageBox.Show("Vous avez produit toute la quantité");
                        textBoxQTé.Text = "0";
                    }
                    else
                    {
                        // Vérifier si textBox2 est supérieur à textBox1
                        if (valeurTextBox2Int > valeurTextBox1Int)
                        {
                            textBoxQTé.Text = "0";
                        }
                        else
                        {
                            // Calcul pour textBoxQTé
                            int resultatCalculInt = valeurTextBox1Int - valeurTextBox2Int;
                            textBoxQTé.Text = resultatCalculInt.ToString();
                        }

                        // Calcul pour textBoxNBdayREST
                        int nbDayRestInt = (valeurTextBox8Int / valeurTextBox5Int);

                        // Vérifier et parser le contenu de textBox9 comme une date
                        if (DateTime.TryParseExact(textBox9.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime baseDate))
                        {
                            // Ajouter nbDayRestInt à la date baseDate
                            DateTime dateResultat = baseDate.AddDays(nbDayRestInt);
                            textBoxNBdayREST.Text = dateResultat.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            MessageBox.Show("Veuillez entrer une date valide au format aaaa-mm-jj dans textBox9.");
                        }
                    }

                    // Calcul pour textBox10
                    if (double.TryParse(textBox7.Text, out double valeurTextBox7Double))
                    {
                        if (valeurTextBox7Double == 0)
                        {
                            if (double.TryParse(textBox2.Text, out double valeurTextBox2Double) && int.TryParse(textBox8.Text, out int valeurTextBox18Int))
                            {
                                if (valeurTextBox8Int != 0)
                                {
                                    double resultatTextBox10Double = valeurTextBox2Double / valeurTextBox18Int;
                                    textBox10.Text = resultatTextBox10Double.ToString("F2"); // Formatage à 2 décimales
                                }
                                else
                                {
                                    MessageBox.Show("La valeur de textBox8 ne peut pas être zéro pour le calcul de textBox10.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Valeurs invalides dans textBox2 ou textBox8.");
                            }
                        }
                        else
                        {
                            if (int.TryParse(textBox8.Text, out int valeurTextBox18Int))
                            {
                                if (valeurTextBox8Int != 0)
                                {
                                    double resultatTextBox10Double = (valeurTextBox7Double / valeurTextBox18Int) * 100;
                                    textBox10.Text = resultatTextBox10Double.ToString("F2"); // Formatage à 2 décimales
                                }
                                else
                                {
                                    MessageBox.Show("La valeur de textBox8 ne peut pas être zéro pour le calcul de textBox10.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Valeur invalide dans textBox8.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valeur invalide dans textBox7.");
                    }


                }
                else
                {
                    MessageBox.Show("Les valeurs entrées dans textBox1, textBox2, textBox5 et textBox8 doivent être des entiers valides.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides dans les champs concernés.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CalculPlanification_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string qteproduction = textBoxQTé.Text;
            string datejour = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string productionjournalier = textBox2.Text;
            string dayrestant = textBoxNBdayREST.Text;
            string productionrestante = textBoxQTé.Text;
            String code_planification = txtcodeplanification.Text;
            string rendement = textBox3.Text;
            string avancement = textBox10.Text;

            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Requête d'insertion SQL
            string query = "INSERT INTO calculplanification (qte_Aproduire, date_jour, qte_produit, qte_Restantes, date_livraison,Rendement,code_planification,avancement) " +
                           "VALUES (@qte_Aproduire, @datejour, @qteproduit, @qterestantes, @datelivraison,@Rendement,@code_planification,@avancement)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Insertion dans la table calculplanification
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@qte_Aproduire", qteproduction);
                    command.Parameters.AddWithValue("@datejour", datejour);
                    command.Parameters.AddWithValue("@qteproduit", productionjournalier);
                    command.Parameters.AddWithValue("@qterestantes", productionrestante);
                    command.Parameters.AddWithValue("@datelivraison", dayrestant);
                    command.Parameters.AddWithValue("@Rendement", rendement);
                    command.Parameters.AddWithValue("@code_planification", code_planification);
                    command.Parameters.AddWithValue("@avancement", avancement);

                    command.ExecuteNonQuery();
                }
                // Requête d'insertion SQL pour la table parcmachine
                string queryParcMachine = "UPDATE parcmachine SET date_disponibilite = @dateDisponibilite WHERE Etat = @Etat";
                using (MySqlCommand commandParcMachine = new MySqlCommand(queryParcMachine, connection))
                {
                    commandParcMachine.Parameters.AddWithValue("@dateDisponibilite", dayrestant);
               // Utiliser la date actuelle
                    commandParcMachine.Parameters.AddWithValue("@Etat", "machine encore utilisée");
                    commandParcMachine.ExecuteNonQuery();
                }

                // Vérification si la machine est utilisée dans la table productionplanification
                string queryVerification = "SELECT COUNT(*) FROM productionplanification WHERE machines = @Etat "; // Ajoutez ici d'autres conditions nécessaires
                using (MySqlCommand commandVerification = new MySqlCommand(queryVerification, connection))
                {
                    commandVerification.Parameters.AddWithValue("@Etat", "valeur_de_la_machine_utilisée");
                    int count = Convert.ToInt32(commandVerification.ExecuteScalar());

                    if (count > 0)
                    {
                        // Mise à jour de la table parcmachine si la machine est utilisée
                        using (MySqlCommand commandParcMachine = new MySqlCommand(queryParcMachine, connection))
                        {
                            commandParcMachine.Parameters.AddWithValue("@dateDisponibilite", dayrestant);
                            commandParcMachine.Parameters.AddWithValue("@Etat", "machine encore utilisée");
                            commandParcMachine.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La machine n'est pas utilisée dans la productionplanification.");
                    }
                }

                connection.Close();
            }

            // Réinitialisation des champs après l'insertion
            textBoxQTé.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxNBdayREST.Text = "";
            textBox3.Text = "";
            txtcodeplanification.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";

            MessageBox.Show("Calcul planification ajouté avec succès.");
        }

        private bool premiereImportation = true;
        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Charger les codes de planification dans le ComboBox
            System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
            string query = "SELECT code_planification FROM productionplanification";

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

            if (form.ShowDialog() == DialogResult.OK)
            {
                string selectedCodePlanification = comboBox.SelectedItem.ToString();

                // Afficher un message demandant si c'est le premier suivi de production
                DialogResult result = MessageBox.Show("Vous faites votre premier suivi de production ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Récupérer les valeurs de qte_produire, Production_journalier, Nb_jour_estimé et Date_commence de la table productionplanification
                    string queryQteProduire = "SELECT qte_produire, Production_journalier, Date_commence FROM productionplanification WHERE code_planification = @code_planification";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand(queryQteProduire, connection);
                            cmd.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                // Lire et assigner les valeurs aux textboxes
                                textBox1.Text = reader["qte_produire"].ToString();
                                textBox4.Text = reader["Production_journalier"].ToString();

                                // Récupérer et assigner la valeur de qte_produire à textBox8
                                textBox8.Text = reader["qte_produire"].ToString();

                                // Récupérer les valeurs de Nb_jour_estimé et Date_commence
                                DateTime dateCommence = Convert.ToDateTime(reader["Date_commence"]);

                                // Initialiser textBox7 et textBox6 à zéro
                                textBox7.Text = "0";
                                textBox6.Text = "0";

                                // Assigner la valeur de Date_commence à textBox9
                                textBox9.Text = dateCommence.ToString("yyyy-MM-dd"); // Format de date approprié

                            }
                            else
                            {
                                MessageBox.Show("Quantités introuvables.", "Erreur");
                            }

                            reader.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Une erreur est survenue lors de la récupération des quantités : " + ex.Message);
                        }
                    }
                }


                else if (result == DialogResult.No)
                {
                    // Récupérer les valeurs de qte_Aproduire, qte_Restantes, Production_journalier, date_livraison, et qte_produit
                    string queryQteAProduire = "SELECT qte_Restantes FROM calculplanification WHERE code_planification = @code_planification";
                    string queryLastQteProduire = "SELECT qte_Restantes FROM calculplanification WHERE code_planification = @code_planification ORDER BY id DESC LIMIT 1";
                    string queryProductionJournalier = "SELECT Production_journalier FROM productionplanification WHERE code_planification = @code_planification";
                    string queryQteProduit = "SELECT COUNT(qte_produit) FROM calculplanification WHERE code_planification = @code_planification ORDER BY id DESC LIMIT 1";
                    string querySumQteProduit = "SELECT SUM(qte_produit) FROM calculplanification WHERE code_planification = @code_planification";
                    string qtetotale = "SELECT qte_produire FROM productionplanification WHERE code_planification = @code_planification";
                    string datecommence = "SELECT Date_commence FROM productionplanification WHERE code_planification = @code_planification";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Récupérer la valeur de qte_Restantes
                            MySqlCommand cmd = new MySqlCommand(queryLastQteProduire, connection);
                            cmd.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            object qte_Restantes = cmd.ExecuteScalar();

                            if (qte_Restantes != null)
                            {
                                textBox1.Text = qte_Restantes.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Quantité à produire introuvable.", "Erreur");
                            }

                            // Récupérer la valeur de qte_produire
                            MySqlCommand cmdQteProduire = new MySqlCommand(qtetotale, connection);
                            cmdQteProduire.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            object qteProduire = cmdQteProduire.ExecuteScalar();

                            if (qteProduire != null)
                            {
                                textBox8.Text = qteProduire.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Quantité à produire introuvable.", "Erreur");
                            }
                            // Récupérer la valeur de date  de lancement
                            MySqlCommand cmddatecommence = new MySqlCommand(datecommence, connection);
                            cmddatecommence.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            object datecommences = cmddatecommence.ExecuteScalar();
                            if (datecommences != null)
                            {
                                textBox9.Text = datecommences.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Date de  commence   introuvable.", "Erreur");
                            }
                            // Récupérer la valeur de Production_journalier
                            MySqlCommand cmdProdJournalier = new MySqlCommand(queryProductionJournalier, connection);
                            cmdProdJournalier.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            object productionJournalier = cmdProdJournalier.ExecuteScalar();

                            if (productionJournalier != null)
                            {
                                textBox4.Text = productionJournalier.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Production journalière introuvable.", "Erreur");
                            }

                          

                            // Récupérer la valeur de qte_produit
                            MySqlCommand cmdQteProduit = new MySqlCommand(queryQteProduit, connection);
                            cmdQteProduit.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            object qteProduit = cmdQteProduit.ExecuteScalar();

                            if (qteProduit != null)
                            {
                                textBox6.Text = qteProduit.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Quantité produite introuvable.", "Erreur");
                            }
                            // Récupérer la somme des valeurs de qte_produit
                            MySqlCommand cmdSumQteProduit = new MySqlCommand(querySumQteProduit, connection);
                            cmdSumQteProduit.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                            object sumQteProduit = cmdSumQteProduit.ExecuteScalar();

                            if (sumQteProduit != null)
                            {
                                textBox7.Text = sumQteProduit.ToString();
                            }
                            else
                            {
                                MessageBox.Show("La somme des quantités produites est introuvable.", "Erreur");
                            }

                            if (textBox1.Text == "0")
                            {
                                MessageBox.Show("Vous avez produit toute la quantité", "Erreur");
                                button4.Enabled = false;

                                // Mettre à jour l'attribut Utilisée dans la table parcmachine
                                string updateParcMachine = "UPDATE parcmachine " +
                                                           "SET Utilisée = 0 " +
                                                           "WHERE code = (SELECT machines FROM productionplanification WHERE code_planification = @code_planification LIMIT 1)";

                                try
                                {
                                    MySqlCommand updateCmd = new MySqlCommand(updateParcMachine, connection);
                                    updateCmd.Parameters.AddWithValue("@code_planification", selectedCodePlanification);
                                    updateCmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Une erreur est survenue lors de la mise à jour de l'attribut Utilisée : " + ex.Message);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Une erreur est survenue lors de la récupération des données : " + ex.Message);
                        }
                    }
                }

            }
        }
        private bool QuantiteAProduireEstNulle()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT qte_Aproduire FROM calculplanification WHERE qte_Aproduire = 0";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int qteAProduire;
                        if (int.TryParse(result.ToString(), out qteAProduire))
                        {
                            // Vérifie si la quantité à produire est nulle
                            return qteAProduire == 0;
                        }
                    }
                }
            }
            return false;
        }
        private void SaisirQuantiteAProduire()
        {
            // Afficher une boîte de dialogue pour saisir la quantité à produire
            string quantiteAProduire = Microsoft.VisualBasic.Interaction.InputBox("Entrez la quantité à produire :", "Quantité à produire", "");

            // Vérifier si l'utilisateur a saisi une valeur
            if (!string.IsNullOrEmpty(quantiteAProduire))
            {
                // Mettre à jour le textBox1 avec la quantité à produire saisie
                textBox1.Text = quantiteAProduire;
            }
            else
            {
                MessageBox.Show("Vous devez entrer une quantité à produire.");
            }
        }

        private void SaisirDerniereQuantiteProduite()
        {
            // Récupérer la dernière quantité produite depuis le tableau calculplanification
            string derniereQuantiteProduite = GetDerniereQuantiteProduiteFromCalculPlanification();

            // Afficher une boîte de dialogue pour saisir la dernière quantité produite
            string quantiteProduite = Microsoft.VisualBasic.Interaction.InputBox("Entrez la dernière quantité produite :", "Dernière quantité produite", derniereQuantiteProduite);

            // Vérifier si l'utilisateur a saisi une valeur
            if (!string.IsNullOrEmpty(quantiteProduite))
            {
                // Mettre à jour le textBox1 avec la dernière quantité produite saisie
                textBox1.Text = quantiteProduite;
            }
            else
            {
                MessageBox.Show("Vous devez entrer une dernière quantité produite.");
            }
        }

        private string GetDerniereQuantiteProduiteFromCalculPlanification()
        {
            string derniereQuantiteProduite = string.Empty;

            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT qte_Aproduire FROM calculplanification ORDER BY id DESC LIMIT 1";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            derniereQuantiteProduite = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aucune donnée trouvée dans la table calculplanification.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de la connexion à la base de données : {ex.Message}");
                }
            }

            return derniereQuantiteProduite;
        }




        public void ChargerDonnees2(string idPlanificationGlobal)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT qte_Restantes FROM calculplanification ORDER BY id DESC LIMIT 1";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["qte_Restantes"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Aucune donnée trouvée pour l'id_planification sélectionné.");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNBdayREST_TextChanged(object sender, EventArgs e)
        {

        }
        private int nombreCalculsEffectues = 0;
        private decimal sommeResultats = 0;


        private void button1_Click_2(object sender, EventArgs e)
        {
            // Appeler la méthode textBoxQTé_TextChanged pour effectuer les calculs nécessaires
            textBoxQTé_TextChanged(sender, e);

            // Appeler la méthode AfficherDateLivraison pour afficher la date de livraison
            AfficherDateLivraison();
        }

        private void textBoxQTé_TextChanged(object sender, EventArgs e)
        {
            // Récupérer la valeur de qte_produire à partir de la base de données ou d'où vous stockez ces données
            decimal produceQuantity = GetProductionQuantityFromDatabase(); // Assurez-vous d'implémenter cette méthode
            decimal nombrejour = GetNBjourFromDatabase();

            // Vérifier si la TextBox textBoxQTé contient une valeur valide
            if (decimal.TryParse(textBoxQTé.Text, out decimal totalQTé))
            {
                // Calculer le nombre de jours de production nécessaire
                decimal joursRestants = totalQTé / produceQuantity;

                // Arrondir le résultat à l'entier supérieur
                int joursArrondis = (int)Math.Ceiling(joursRestants);

                // Ajouter le nombre de jours supplémentaires
                joursArrondis += (int)nombrejour;
            }

        }
        private decimal GetProductionJournalierFromDatabase()
        {
            // Chaîne de connexion à votre base de données MySQL
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Variable pour stocker la valeur de qte_produire
            decimal productionnjournalier = 0;

            // Requête SQL pour récupérer la valeur de qte_produire depuis la table productionplanification
            string query = "SELECT Production_journalier  FROM productionplanification";

            // Création de la connexion à la base de données et exécution de la requête
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Exécutez la commande et récupérez la valeur de qte_produire
                        object result = command.ExecuteScalar();

                        // Vérifiez si le résultat n'est pas nul et peut être converti en décimal
                        if (result != null && decimal.TryParse(result.ToString(), out productionnjournalier))
                        {
                            // Vous pouvez également ajouter d'autres logiques de traitement ici si nécessaire
                        }
                        else
                        {
                            // Gérez le cas où la valeur de qte_produire n'a pas pu être récupérée
                            Console.WriteLine("La valeur de qte_produire n'a pas pu être récupérée.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Gérez les exceptions qui pourraient survenir lors de la récupération des données depuis la base de données
                        Console.WriteLine("Une erreur est survenue lors de la récupération de la valeur de qte_produire : " + ex.Message);
                    }
                }
            }

            // Retourne la valeur de qte_produire récupérée depuis la base de données
            return productionnjournalier;
        }
        private decimal GetProductionQuantityFromDatabase()
        {
            // Chaîne de connexion à votre base de données MySQL
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Variable pour stocker la valeur de qte_produire
            decimal produceQuantity = 0;

            // Requête SQL pour récupérer la valeur de qte_produire depuis la table productionplanification
            string query = "SELECT qte_produire  FROM productionplanification";

            // Création de la connexion à la base de données et exécution de la requête
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Exécutez la commande et récupérez la valeur de qte_produire
                        object result = command.ExecuteScalar();

                        // Vérifiez si le résultat n'est pas nul et peut être converti en décimal
                        if (result != null && decimal.TryParse(result.ToString(), out produceQuantity))
                        {
                            // Vous pouvez également ajouter d'autres logiques de traitement ici si nécessaire
                        }
                        else
                        {
                            // Gérez le cas où la valeur de qte_produire n'a pas pu être récupérée
                            Console.WriteLine("La valeur de qte_produire n'a pas pu être récupérée.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Gérez les exceptions qui pourraient survenir lors de la récupération des données depuis la base de données
                        Console.WriteLine("Une erreur est survenue lors de la récupération de la valeur de qte_produire : " + ex.Message);
                    }
                }
            }

            // Retourne la valeur de qte_produire récupérée depuis la base de données
            return produceQuantity;
        }
        private decimal GetNBjourFromDatabase()
        {
            // Chaîne de connexion à votre base de données MySQL
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Variable pour stocker la valeur de qte_produire
            decimal nombrejour = 0;

            // Requête SQL pour récupérer la valeur de nombre de jour depuis la table productionplanification
            string query = "SELECT Nb_jour_estimé  FROM productionplanification";

            // Création de la connexion à la base de données et exécution de la requête
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Exécutez la commande et récupérez la valeur de qte_produire
                        object result = command.ExecuteScalar();

                        // Vérifiez si le résultat n'est pas nul et peut être converti en décimal
                        if (result != null && decimal.TryParse(result.ToString(), out nombrejour))
                        {
                            // Vous pouvez également ajouter d'autres logiques de traitement ici si nécessaire
                        }
                        else
                        {
                            // Gérez le cas où la valeur de qte_produire n'a pas pu être récupérée
                            Console.WriteLine("La valeur de date de jour n'a pas pu être récupérée.");
                        }
                    }

                    catch (Exception ex)
                    {
                        // Gérez les exceptions qui pourraient survenir lors de la récupération des données depuis la base de données
                        Console.WriteLine("Une erreur est survenue lors de la récupération de la valeur de qte_produire : " + ex.Message);
                    }
                }
            }

            // Retourne la valeur de qte_produire récupérée depuis la base de données
            return nombrejour;
        }
        private void AfficherDateLivraison()
        {
            // Récupérer le nombre de jours depuis textBoxNBdayREST
            if (int.TryParse(textBoxNBdayREST.Text, out int jours))
            {
                // Obtenir la date de référence
                DateTime dateReference = DateTime.Now; // Vous pouvez utiliser une autre date de référence si nécessaire

                // Ajouter le nombre de jours à la date de référence pour obtenir la date de livraison
                DateTime dateLivraison = dateReference.AddDays(jours);

                // Afficher la date de livraison dans textBoxNBdayREST sous forme de chaîne formatée
                textBoxNBdayREST.Text = dateLivraison.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide de jours.");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            // Convertir le texte du textbox en entier, ajouter 1, puis reconvertir en chaîne
            DateTime dayRestant;
            if (DateTime.TryParse(textBoxNBdayREST.Text, out dayRestant))
            {
                dayRestant = dayRestant.AddDays(1);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide dans le champ NB day REST.");
                return;
            }

            string dayRestantStr = dayRestant.ToString("dd/MM/yyyy");
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Query to update date_livraison in calculplanification
            string queryUpdateCalculPlanification = @"
        UPDATE calculplanification 
        SET date_livraison = @dateLivraison 
        WHERE code_planification IN (
            SELECT code_planification 
            FROM productionplanification
            WHERE code_planification = calculplanification.code_planification
        )";

            // Query to update date_disponibilite in parcmachine
            string queryUpdateParcmachine = @"
        UPDATE parcmachine 
        SET date_disponibilite = @dateDisponibilite 
        WHERE code IN (
            SELECT machines 
            FROM productionplanification 
            WHERE code_planification IN (
                SELECT code_planification 
                FROM calculplanification
                WHERE code_planification = productionplanification.code_planification
            )
        )";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Update date_livraison in calculplanification
                    using (MySqlCommand command = new MySqlCommand(queryUpdateCalculPlanification, connection))
                    {
                        command.Parameters.AddWithValue("@dateLivraison", textBoxNBdayREST.Text);
                        command.ExecuteNonQuery();
                    }

                    // Update date_disponibilite in parcmachine
                    using (MySqlCommand command = new MySqlCommand(queryUpdateParcmachine, connection))
                    {
                        command.Parameters.AddWithValue("@dateDisponibilite", dayRestantStr);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Les dates ont été mises à jour avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la mise à jour : " + ex.Message);
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Récupérer la valeur de Production_journalier depuis textBox4
            string productionJournalierInput = textBox4.Text;
            // Vérifier si l'utilisateur a saisi une valeur
            if (!string.IsNullOrEmpty(productionJournalierInput))
            {
                double productionJournalier;
                // Vérifier si la valeur saisie peut être convertie en double
                if (double.TryParse(productionJournalierInput, out productionJournalier))
                {
                    // Connexion à la base de données
                    string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Requête SQL pour vérifier si la Production_journalier est présente dans la table
                            string query = "SELECT COUNT(*) FROM productionplanification WHERE Production_journalier = @productionJournalier";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@productionJournalier", productionJournalier);
                                int count = Convert.ToInt32(command.ExecuteScalar());

                                if (count > 0)
                                {
                                    // Calcul du rendement en utilisant la valeur saisie
                                    double rendement = (Convert.ToDouble(textBox2.Text) / productionJournalier) * 100;

                                    // Récupération de la partie entière du rendement
                                    int partieEntiere = (int)rendement;

                                    // Récupération de la partie décimale du rendement
                                    double partieDecimale = rendement - partieEntiere;

                                    // Si la partie décimale est supérieure à 0.5, ajouter 1 à la partie entière
                                    if (partieDecimale > 0.5)
                                    {
                                        partieEntiere++;
                                    }

                                    textBox3.Text = partieEntiere.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("La valeur de Production_journalier n'est pas présente dans la table productionplanification.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la vérification de la présence de Production_journalier dans la base de données : " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La valeur saisie n'est pas valide. Veuillez entrer un nombre valide.");
                }
            }
            else
            {
                MessageBox.Show("Vous devez entrer une valeur de Production_journalier.");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Remplir le ComboBox avec les codes de planification
            FillComboBoxWithCodePlanification();

            // Afficher le formulaire de sélection du code de planification
            // Une fois un code sélectionné, le textBox4 sera automatiquement mis à jour
            ShowCodePlanificationSelectionForm();

            // Mettre à jour textBox4 avec la valeur de Production_journalier correspondant au code de planification
           /* if (!string.IsNullOrEmpty(codePlanification))
            {
                // Utilisez votre logique pour récupérer la valeur de Production_journalier en fonction du code de planification
                string productionJournalier = GetProductionJournalierFromCodePlanification(codePlanification);

                // Mettre à jour textBox4 avec la valeur de Production_journalier
                textBox4.Text = productionJournalier;
            }*/
        }
        private void ShowCodePlanificationSelectionForm()
        {
            // Création d'un formulaire pour sélectionner le code de planification
            WinForms.Form codeSelectionForm = new WinForms.Form();
            codeSelectionForm.Text = "Sélectionner le code de planification";
            codeSelectionForm.Size = new System.Drawing.Size(300, 200);

            // Création d'un ComboBox pour afficher les codes de planification
            WinForms.ComboBox comboBox = new WinForms.ComboBox();
            comboBox.DropDownStyle = WinForms.ComboBoxStyle.DropDownList; // Pour empêcher la saisie manuelle
            comboBox.Dock = WinForms.DockStyle.Fill;
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                // Lorsque l'utilisateur sélectionne un élément dans le ComboBox, mettre à jour textBox4
                string selectedCode = comboBox.SelectedItem.ToString();
                textBox4.Text = GetProductionJournalierFromCodePlanification(selectedCode);
            };

            // Remplir le ComboBox avec les codes de planification
            FillComboBoxWithCodePlanification();

            // Ajouter le ComboBox au formulaire
            codeSelectionForm.Controls.Add(comboBox);

            // Afficher le formulaire en tant que boîte de dialogue modale
            codeSelectionForm.ShowDialog();
        }
        private void FillComboBoxWithCodePlanification()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT code_planification FROM productionplanification";

                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Ajouter chaque code de planification au ComboBox
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Gérer les exceptions selon votre besoin
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private string GetProductionJournalierFromCodePlanification(string codePlanification)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            string productionJournalier = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Production_journalier FROM productionplanification WHERE code_planification = @codePlanification";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@codePlanification", codePlanification);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Récupérer la valeur de Production_journalier depuis le résultat de la requête
                        productionJournalier = reader["Production_journalier"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Gérer les exceptions selon votre besoin
                    Console.WriteLine(ex.Message);
                }
            }

            return productionJournalier;
        }

        private void txtcodeplanification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Récupérer et convertir les valeurs des TextBox
                int nombreSaisie = int.Parse(textBox6.Text) + 1;
                int sommetotalSaisie = int.Parse(textBox7.Text) + int.Parse(textBox2.Text);

                // Calculer le résultat pour textBox5
                int resultat = sommetotalSaisie / nombreSaisie;

                // Afficher le résultat dans textBox5
                textBox5.Text = resultat.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides dans les champs concernés.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Le nombre saisi ne peut pas être zéro.", "Erreur de division", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    
    
   
