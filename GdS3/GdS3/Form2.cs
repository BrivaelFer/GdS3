using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace GdS3
{
    public partial class Form2 : Form
    {
       
        string mmm = ConfigurationManager.AppSettings["test"];
        Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        string truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT=" + ConfigurationManager.AppSettings["port"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["bdnom"] + ";UID=" + ConfigurationManager.AppSettings["uid"] +
            ";PASSWORD=" + ConfigurationManager.AppSettings["motDePasse"];
        


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxAdServ.Text = ConfigurationManager.AppSettings["adServ"];
            textBoxBdNom.Text = ConfigurationManager.AppSettings["bdnom"];
            textBoxPasseword.Text = ConfigurationManager.AppSettings["motDePasse"];
            textBoxPort.Text = ConfigurationManager.AppSettings["port"];
            textBoxUID.Text = ConfigurationManager.AppSettings["uid"];
            _ListerMarque();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mmm);
            conf.AppSettings.Settings.Remove("adServ");
            conf.AppSettings.Settings.Add("adServ", textBoxAdServ.Text);
            conf.AppSettings.Settings.Remove("motDePasse");
            conf.AppSettings.Settings.Add("motDePasse", textBoxPasseword.Text);
            conf.AppSettings.Settings.Remove("bdnom");
            conf.AppSettings.Settings.Add("bdnom", textBoxBdNom.Text);
            conf.AppSettings.Settings.Remove("uid");
            conf.AppSettings.Settings.Add("uid", textBoxUID.Text);
            conf.AppSettings.Settings.Remove("port");
            conf.AppSettings.Settings.Add("port", textBoxPort.Text);
            conf.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show(mmm);
            
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void bouttonAjMarque_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(truc);

            try
            {
                conn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                
            }
            MySqlCommand ajoutMarque = new MySqlCommand("insert into marque(nmarque) values(@nmarque)", conn);
            ajoutMarque.Parameters.AddWithValue("@nmarque", textBoxMM.Text);
            ajoutMarque.ExecuteNonQuery();
            ajoutMarque.Parameters.Clear();
            textBoxMM.Clear();
            _ListerMarque();

        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(truc);

            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");

            }
            MySqlCommand ajoutModel = new MySqlCommand("insert into model(nummod,marque) values(@nummod,@marque)", conn);
            ajoutModel.Parameters.AddWithValue("@nummod", textBoxAddMod.Text);
            ajoutModel.Parameters.AddWithValue("@marque", comboBoxModMarque.Text);
            ajoutModel.ExecuteNonQuery();
            ajoutModel.Parameters.Clear();
            textBoxAddMod.Clear();
        }
        private void _ListerMarque()
        {
            comboBoxModMarque.Items.Clear();
            MySqlConnection conn = new MySqlConnection(truc);
            MySqlCommand lireBdd = new MySqlCommand("SELECT * FROM marque", conn);

            conn.Open();
            MySqlDataReader dataR = lireBdd.ExecuteReader();
            while (dataR.Read())
            {
                comboBoxModMarque.Items.Add(dataR["nmarque"]);
            }

            conn.Close();
        }

        private void comboBoxModMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAddMod.Enabled = true;
        }

        private void textBoxAddMod_TextChanged(object sender, EventArgs e)
        {
            buttonAddModel.Enabled = true;
        }
    }
    
}
