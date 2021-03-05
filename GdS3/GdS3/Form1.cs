using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Windows.Input;

namespace GdS3
{
    public partial class Form1 : Form
    {
        string truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT="+ ConfigurationManager.AppSettings["port"] + 
            ";DATABASE="+ ConfigurationManager.AppSettings["bdnom"] + ";UID="+ ConfigurationManager.AppSettings["uid"] + 
            ";PASSWORD="+ ConfigurationManager.AppSettings["motDePasse"];
        bool connect = false;
        int idApp = 00;
        bool checkBase = false;
        bool ok = false;
        string disfoncBase = "";
        public List<string> marqueActiv = new List<string> { };
        public List<string> modelparMarque = new List<string> { };
        public List<int> margeMod = new List<int> { };
        


        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bAjout.Enabled)
            {
                if(!verif())
                    ajout();
            }
            rTableau();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lanceconnect();
            comboBoxTablType.Text = (string)comboBoxTablType.Items[0];
            comboBoxFonc.Text = (string)comboBoxFonc.Items[0];
            comboBoxDisfonctionment.Text = (string)comboBoxDisfonctionment.Items[0];
            rTableau();
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void bAjout_Click(object sender, EventArgs e)
        {
           
            if(!verif())
            { 
                ajout();
            }
            
            
            rTableau();
        }

        private void listMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            triMod(listMarque.Text);
            comboBox4.Enabled = true;
        }

        private void Lpdc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT=" + ConfigurationManager.AppSettings["port"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["bdnom"] + ";UID=" + ConfigurationManager.AppSettings["uid"] +
            ";PASSWORD=" + ConfigurationManager.AppSettings["motDePasse"];
            listMarque.Items.Clear();
            comboBox1.Items.Clear();
            lanceconnect();
            rTableau();
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonRafraichir_Click(object sender, EventArgs e)
        {
            listMarque.Items.Clear();
            comboBox1.Items.Clear();
            comboBox4.Items.Clear();
            lanceconnect();
            rTableau();
        }

        public void lanceconnect()
        {
            MySqlConnection conn = new MySqlConnection(truc);

            try
            {
                conn.Open();
                connect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                connect = false;

            }
            if (connect)
            {
                MySqlCommand lireBddM = new MySqlCommand("SELECT * FROM " + ConfigurationManager.AppSettings["listMarqT"], conn);
                

                MySqlCommand lireBdd = new MySqlCommand("SELECT * FROM type", conn);


                MySqlDataReader dataR = lireBdd.ExecuteReader();
                while (dataR.Read())
                {

                    comboBox1.Items.Add(dataR["mtype"]);
                }

                conn.Close();
                conn.Open();
                dataR = lireBddM.ExecuteReader();
                while (dataR.Read())
                {
                    listMarque.Items.Add(dataR[ConfigurationManager.AppSettings["listMarqC"]]);
                }

                conn.Close();
                

            }
            
        }

        private void checkBoxEtat_CheckedChanged(object sender, EventArgs e)
        {
            affDiss();
        }
        private void affDiss()
        {
            comboBoxDisfonctionment.Enabled = !checkBoxEtat.Checked;
            labeldisfonc.Enabled = !checkBoxEtat.Checked;
        }

        private void bRech_Click(object sender, EventArgs e)
        {
            bool trouver = false;
            int numRech = 0;
            MySqlConnection conn = new MySqlConnection(truc);
            List<string> listTable = new List<string> { "UC", "Sourie", "clavier", "ecran", "disUC", "disSourie", "disclavier", "disecran"};
            List<string> listType = new List<string> { "UC", "Sourie", "clavier", "ecran","UC", "Sourie", "clavier", "ecran" };
            MySqlCommand lireNS;


            MySqlDataReader dataR;
            
            while(!trouver)
            { 
                
                conn.Open();
                lireNS = new MySqlCommand("select * from "+ listTable[numRech], conn);
                dataR = lireNS.ExecuteReader();
                while (dataR.Read())
                {
                    if (textBox1.Text == (string)dataR["numSeri"])
                    {
                        MessageBox.Show("apparail trouvé");
                        comboBox1.Text = listType[numRech];
                        listMarque.Text = (string)dataR["marque"];
                        comboBox4.Text = (string)dataR["model"];
                        idApp = (int)dataR["id"];
                        
                        trouver = true;
                        
                        if(numRech>3)
                        {
                            checkBoxEtat.Checked = false;
                            checkBase = false;
                            comboBoxDisfonctionment.Text = (string)dataR["etat"];
                            disfoncBase = (string)dataR["etat"];
                        }
                        if(numRech <= 3)
                        {
                            checkBoxEtat.Checked = true;
                            checkBase = true;
                        }
                        comboBox1.Enabled = false;
                        listMarque.Enabled = false;
                        comboBox4.Enabled = false;
                        bAjout.Enabled = false;
                        
                        btransf.Enabled = true;
                        bSupp.Enabled = true;

                        break;
                    }


                }
               

                conn.Close();
                numRech++;
                if (trouver || numRech >= listTable.Count)
                    break;
                
            }
            if (!trouver)
                MessageBox.Show("Numéro de séri invalide");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            btransf.Enabled = false;
            bSupp.Enabled = false;
            comboBox1.Enabled = true;
            listMarque.Enabled = true;
            
            bAjout.Enabled = true;
            

        }

        private void btransf_Click(object sender, EventArgs e)
        {
            ok = false;
            if(checkBase != checkBoxEtat.Checked)
            { 
                suppr();
                if(ok)
                    ajout();
            }
            if (!checkBase && !checkBoxEtat.Checked && comboBoxDisfonctionment.Text != disfoncBase)
            {
                modif();
            }
        }

        private void bSupp_Click(object sender, EventArgs e)
        {
            suppr();
            rTableau();
        }

        private void suppr()
        {
            string nTable = "";

            MySqlConnection conn = new MySqlConnection(truc);
            try
            {
                conn.Open();
                nTable = comboBox1.Text;

                if (!checkBase)
                    nTable = "dis" + nTable;

                MySqlCommand suppApp = new MySqlCommand("DELETE FROM " + nTable + " WHERE id = " + idApp, conn);
                suppApp.ExecuteNonQuery();

                MessageBox.Show("suppression réussi");

                ok = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Echec de la suppression\n"+ex.Message);
            }
            conn.Close();
        }
        private void ajout()
        {
            MySqlConnection conn = new MySqlConnection(truc);

            try
            {
                conn.Open();
                connect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de connection\n" + ex.Message );
                connect = false;

            }

            if (checkBoxEtat.Checked)
            {
                try
                {
                    MySqlCommand ajapp = new MySqlCommand("INSERT INTO " + comboBox1.Text +
                        "(Date,numSeri,model,marque) values(@Date,@numSeri,@model,@marque)", conn);
                    ajapp.Parameters.AddWithValue("@marque", listMarque.Text);
                    ajapp.Parameters.AddWithValue("@numSeri", textBox1.Text);
                    ajapp.Parameters.AddWithValue("@model", comboBox4.Text);
                    ajapp.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    ajapp.ExecuteNonQuery();
                    ajapp.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Echec de l'ajout\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlCommand ajapp = new MySqlCommand("INSERT INTO dis" + comboBox1.Text +
                        "(Date,numSeri,model,marque,etat) values(@Date,@numSeri,@model,@marque,@etat)", conn);
                    ajapp.Parameters.AddWithValue("@marque", listMarque.Text);
                    ajapp.Parameters.AddWithValue("@numSeri", textBox1.Text);
                    ajapp.Parameters.AddWithValue("@model", comboBox4.Text);
                    ajapp.Parameters.AddWithValue("@etat", comboBoxDisfonctionment.Text);
                    ajapp.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    ajapp.ExecuteNonQuery();
                    ajapp.Parameters.Clear();
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBox1.Clear();
            
        }
        private void rTableau()
        {
            string limite = "";
            string TEtat = "";
            string TType = comboBoxTablType.Text;
            if (comboBoxFonc.Text == "Dysfonctionnel")
                TEtat = "dis";
            if (!checkBoxAffichage.Checked)
                limite = "LIMIT 0,9";
            
            MySqlConnection conn = new MySqlConnection(truc);
            try
            {
                listView1.Items.Clear();
                conn.Open();
                MySqlCommand readTable = new MySqlCommand("SELECT * FROM " + TEtat + TType+" ORDER BY id DESC "+ limite, conn);
                MySqlDataReader lec = readTable.ExecuteReader();
                while(lec.Read())
                {
                    
                    string etat = "";
                    string id = lec["id"].ToString();
                    string date = lec["Date"].ToString();
                    string Nseri = lec["numSeri"].ToString();
                    string Marq = lec["marque"].ToString();
                    string Mod = lec["model"].ToString();
                    if (TEtat == "dis")
                    { 
                        etat = lec["etat"].ToString();
                        
                    }
                    listView1.Items.Add(new ListViewItem(new[] { id, date, Nseri, Marq, Mod, etat }));
                        
                }
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRafTabl_Click(object sender, EventArgs e)
        {
            rTableau();
        }
        private void modif()
        {
            
            MySqlConnection conn = new MySqlConnection(truc);
            conn.Open();

            try 
            {
                MySqlCommand modiffer = new MySqlCommand("UPDATE dis" + comboBox1.Text + " SET etat=@etat  WHERE ID =" + idApp, conn);
                modiffer.Parameters.AddWithValue("@etat", comboBoxDisfonctionment.Text );
                modiffer.ExecuteNonQuery();
                MessageBox.Show("Modification réussi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Echec modification\n" + ex.Message);
            }
            conn.Close();
        }
        private bool verif()
        {
            bool trouver = false;
            int conteur = 0;
            string dis = "";
            MySqlConnection conn = new MySqlConnection(truc); 
            MySqlCommand lireNS;
            MySqlDataReader dataR;

            while(!trouver)
            { 
                conn.Open();
                if (conteur == 1)
                    dis = "dis";
                lireNS = new MySqlCommand("select * from " + dis+ comboBox1.Text, conn);
                dataR = lireNS.ExecuteReader();
                while(dataR.Read())
                {
                    if((string)dataR["numSeri"] == textBox1.Text)
                    {
                        trouver = true;
                        MessageBox.Show("Ce numéro de série existe déja");
                        break;
                    }
                }
                conteur++;
                conn.Close();
                if (conteur == 2)
                    break;
                
            }
            return trouver;

                
        }

        private void triMod(string marque)
        {


            bool trouver = false;
            int numRech = 0;
            MySqlConnection conn = new MySqlConnection(truc);
            
            MySqlCommand lireListMod;


            MySqlDataReader dataR;

           

            conn.Open();
            lireListMod = new MySqlCommand("select * from  model" , conn);
            dataR = lireListMod.ExecuteReader();
            while (dataR.Read())
            {
                if (marque == (string)dataR["marque"])
                {

                    comboBox4.Items.Add(dataR["nummod"]);
                    comboBox4.Enabled = true;
                    trouver = true;

                        
                }


            }
            if (!trouver)
                MessageBox.Show("Auncun modèle de correspont cette marque");


            conn.Close();
            numRech++;
                

            
           


        }
        private void _addList()
        {
            modelparMarque.Clear();
            marqueActiv.Clear();
            margeMod.Clear();
            MySqlConnection conn = new MySqlConnection(truc);
            MySqlCommand lireBddM = new MySqlCommand("SELECT * FROM " + ConfigurationManager.AppSettings["listMarqT"], conn);
            MySqlCommand lireBLMo = new MySqlCommand("SELECT * FROM " + ConfigurationManager.AppSettings["listModT"], conn);

            MySqlCommand lireBdd = new MySqlCommand("SELECT * FROM marque", conn);
            conn.Open();

            MySqlDataReader dataR = lireBdd.ExecuteReader();
            while (dataR.Read())
            {
                marqueActiv.Add((string)dataR["nmarque"]);
            }

            conn.Close();



            
            
            for(int conteur=0; conteur<marqueActiv.Count; conteur++)
            { conn.Open();
                dataR = lireBLMo.ExecuteReader();

                while(dataR.Read())
                {
                        if ((string)dataR["marque"] == marqueActiv[conteur])
                            modelparMarque.Add((string)dataR["nummod"]);
                        else
                            margeMod.Add(modelparMarque.Count);
                       
                }
                conn.Close();

            }
            
        }

       
    }
}
