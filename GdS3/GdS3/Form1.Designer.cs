
namespace GdS3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listMarque = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lpdc = new System.Windows.Forms.LinkLabel();
            this.bAjout = new System.Windows.Forms.Button();
            this.bRech = new System.Windows.Forms.Button();
            this.btransf = new System.Windows.Forms.Button();
            this.bSupp = new System.Windows.Forms.Button();
            this.checkBoxEtat = new System.Windows.Forms.CheckBox();
            this.buttonRafraichir = new System.Windows.Forms.Button();
            this.comboBoxDisfonctionment = new System.Windows.Forms.ComboBox();
            this.labeldisfonc = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderdate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNSeri = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMarque = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMod = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEtat = new System.Windows.Forms.ColumnHeader();
            this.comboBoxTablType = new System.Windows.Forms.ComboBox();
            this.comboBoxFonc = new System.Windows.Forms.ComboBox();
            this.buttonRafTabl = new System.Windows.Forms.Button();
            this.checkBoxAffichage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // listMarque
            // 
            this.listMarque.FormattingEnabled = true;
            this.listMarque.Location = new System.Drawing.Point(122, 84);
            this.listMarque.Name = "listMarque";
            this.listMarque.Size = new System.Drawing.Size(146, 23);
            this.listMarque.TabIndex = 1;
            this.listMarque.SelectedIndexChanged += new System.EventHandler(this.listMarque_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(122, 113);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(146, 23);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type de matériel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modèle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numéro de série";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lpdc
            // 
            this.Lpdc.AutoSize = true;
            this.Lpdc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lpdc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lpdc.Location = new System.Drawing.Point(281, 199);
            this.Lpdc.Name = "Lpdc";
            this.Lpdc.Size = new System.Drawing.Size(63, 13);
            this.Lpdc.TabIndex = 10;
            this.Lpdc.TabStop = true;
            this.Lpdc.Text = "Paramètres";
            this.Lpdc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lpdc_LinkClicked);
            // 
            // bAjout
            // 
            this.bAjout.Enabled = false;
            this.bAjout.Location = new System.Drawing.Point(29, 232);
            this.bAjout.Name = "bAjout";
            this.bAjout.Size = new System.Drawing.Size(105, 23);
            this.bAjout.TabIndex = 11;
            this.bAjout.Text = "Ajouter";
            this.bAjout.UseVisualStyleBackColor = true;
            this.bAjout.Click += new System.EventHandler(this.bAjout_Click);
            // 
            // bRech
            // 
            this.bRech.Location = new System.Drawing.Point(269, 25);
            this.bRech.Name = "bRech";
            this.bRech.Size = new System.Drawing.Size(75, 23);
            this.bRech.TabIndex = 12;
            this.bRech.Text = "Recherche";
            this.bRech.UseVisualStyleBackColor = true;
            this.bRech.Click += new System.EventHandler(this.bRech_Click);
            // 
            // btransf
            // 
            this.btransf.Enabled = false;
            this.btransf.Location = new System.Drawing.Point(140, 232);
            this.btransf.Name = "btransf";
            this.btransf.Size = new System.Drawing.Size(123, 23);
            this.btransf.TabIndex = 13;
            this.btransf.Text = "Transférer/Modifier";
            this.btransf.UseVisualStyleBackColor = true;
            this.btransf.Click += new System.EventHandler(this.btransf_Click);
            // 
            // bSupp
            // 
            this.bSupp.Enabled = false;
            this.bSupp.Location = new System.Drawing.Point(269, 232);
            this.bSupp.Name = "bSupp";
            this.bSupp.Size = new System.Drawing.Size(75, 23);
            this.bSupp.TabIndex = 14;
            this.bSupp.Text = "Supprimer";
            this.bSupp.UseVisualStyleBackColor = true;
            this.bSupp.Click += new System.EventHandler(this.bSupp_Click);
            // 
            // checkBoxEtat
            // 
            this.checkBoxEtat.AutoSize = true;
            this.checkBoxEtat.Location = new System.Drawing.Point(69, 142);
            this.checkBoxEtat.Name = "checkBoxEtat";
            this.checkBoxEtat.Size = new System.Drawing.Size(89, 19);
            this.checkBoxEtat.TabIndex = 16;
            this.checkBoxEtat.Text = "Fonctionnel";
            this.checkBoxEtat.UseVisualStyleBackColor = true;
            this.checkBoxEtat.CheckedChanged += new System.EventHandler(this.checkBoxEtat_CheckedChanged);
            // 
            // buttonRafraichir
            // 
            this.buttonRafraichir.Location = new System.Drawing.Point(29, 261);
            this.buttonRafraichir.Name = "buttonRafraichir";
            this.buttonRafraichir.Size = new System.Drawing.Size(154, 23);
            this.buttonRafraichir.TabIndex = 17;
            this.buttonRafraichir.Text = "Rafraichir";
            this.buttonRafraichir.UseVisualStyleBackColor = true;
            this.buttonRafraichir.Click += new System.EventHandler(this.buttonRafraichir_Click);
            // 
            // comboBoxDisfonctionment
            // 
            this.comboBoxDisfonctionment.FormattingEnabled = true;
            this.comboBoxDisfonctionment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxDisfonctionment.Items.AddRange(new object[] {
            "Non identifier",
            "Affichage",
            "Alimentation",
            "Disque dur",
            "lecteur CD",
            "RAM"});
            this.comboBoxDisfonctionment.Location = new System.Drawing.Point(122, 167);
            this.comboBoxDisfonctionment.Name = "comboBoxDisfonctionment";
            this.comboBoxDisfonctionment.Size = new System.Drawing.Size(146, 23);
            this.comboBoxDisfonctionment.TabIndex = 18;
            // 
            // labeldisfonc
            // 
            this.labeldisfonc.AutoSize = true;
            this.labeldisfonc.Location = new System.Drawing.Point(7, 170);
            this.labeldisfonc.Name = "labeldisfonc";
            this.labeldisfonc.Size = new System.Drawing.Size(112, 15);
            this.labeldisfonc.TabIndex = 19;
            this.labeldisfonc.Text = "Dysfonctionnement";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderdate,
            this.columnHeaderNSeri,
            this.columnHeaderMarque,
            this.columnHeaderMod,
            this.columnHeaderEtat});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(383, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 238);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "id";
            this.columnHeaderID.Width = 50;
            // 
            // columnHeaderdate
            // 
            this.columnHeaderdate.Text = "Date";
            this.columnHeaderdate.Width = 100;
            // 
            // columnHeaderNSeri
            // 
            this.columnHeaderNSeri.Text = "Numéros de série";
            this.columnHeaderNSeri.Width = 100;
            // 
            // columnHeaderMarque
            // 
            this.columnHeaderMarque.Text = "Marque";
            this.columnHeaderMarque.Width = 80;
            // 
            // columnHeaderMod
            // 
            this.columnHeaderMod.Text = "Modèle";
            this.columnHeaderMod.Width = 80;
            // 
            // columnHeaderEtat
            // 
            this.columnHeaderEtat.Text = "Dysfonctionnement";
            this.columnHeaderEtat.Width = 120;
            // 
            // comboBoxTablType
            // 
            this.comboBoxTablType.FormattingEnabled = true;
            this.comboBoxTablType.Items.AddRange(new object[] {
            "UC",
            "Clavier",
            "Ecran",
            "Sourie"});
            this.comboBoxTablType.Location = new System.Drawing.Point(383, 25);
            this.comboBoxTablType.Name = "comboBoxTablType";
            this.comboBoxTablType.Size = new System.Drawing.Size(117, 23);
            this.comboBoxTablType.TabIndex = 21;
            // 
            // comboBoxFonc
            // 
            this.comboBoxFonc.FormattingEnabled = true;
            this.comboBoxFonc.Items.AddRange(new object[] {
            "Fonctionnel",
            "Dysfonctionnel"});
            this.comboBoxFonc.Location = new System.Drawing.Point(506, 25);
            this.comboBoxFonc.Name = "comboBoxFonc";
            this.comboBoxFonc.Size = new System.Drawing.Size(94, 23);
            this.comboBoxFonc.TabIndex = 22;
            // 
            // buttonRafTabl
            // 
            this.buttonRafTabl.Location = new System.Drawing.Point(696, 26);
            this.buttonRafTabl.Name = "buttonRafTabl";
            this.buttonRafTabl.Size = new System.Drawing.Size(100, 23);
            this.buttonRafTabl.TabIndex = 23;
            this.buttonRafTabl.Text = "Rafraichir";
            this.buttonRafTabl.UseVisualStyleBackColor = true;
            this.buttonRafTabl.Click += new System.EventHandler(this.buttonRafTabl_Click);
            // 
            // checkBoxAffichage
            // 
            this.checkBoxAffichage.AutoSize = true;
            this.checkBoxAffichage.Location = new System.Drawing.Point(802, 29);
            this.checkBoxAffichage.Name = "checkBoxAffichage";
            this.checkBoxAffichage.Size = new System.Drawing.Size(93, 19);
            this.checkBoxAffichage.TabIndex = 24;
            this.checkBoxAffichage.Text = "Afficher tout";
            this.checkBoxAffichage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 305);
            this.Controls.Add(this.checkBoxAffichage);
            this.Controls.Add(this.buttonRafTabl);
            this.Controls.Add(this.comboBoxFonc);
            this.Controls.Add(this.comboBoxTablType);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labeldisfonc);
            this.Controls.Add(this.comboBoxDisfonctionment);
            this.Controls.Add(this.buttonRafraichir);
            this.Controls.Add(this.checkBoxEtat);
            this.Controls.Add(this.bSupp);
            this.Controls.Add(this.btransf);
            this.Controls.Add(this.bRech);
            this.Controls.Add(this.bAjout);
            this.Controls.Add(this.Lpdc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.listMarque);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox listMarque;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Lpdc;
        private System.Windows.Forms.Button bAjout;
        private System.Windows.Forms.Button bRech;
        private System.Windows.Forms.Button btransf;
        private System.Windows.Forms.Button bSupp;
        private System.Windows.Forms.CheckBox checkBoxEtat;
        private System.Windows.Forms.Button buttonRafraichir;
        private System.Windows.Forms.ComboBox comboBoxDisfonctionment;
        private System.Windows.Forms.Label labeldisfonc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNSeri;
        private System.Windows.Forms.ColumnHeader columnHeaderMarque;
        private System.Windows.Forms.ColumnHeader columnHeaderMod;
        private System.Windows.Forms.ColumnHeader columnHeaderEtat;
        private System.Windows.Forms.ComboBox comboBoxTablType;
        private System.Windows.Forms.ComboBox comboBoxFonc;
        private System.Windows.Forms.ColumnHeader columnHeaderdate;
        private System.Windows.Forms.Button buttonRafTabl;
        private System.Windows.Forms.CheckBox checkBoxAffichage;
    }
}

