namespace QualiTech
{
    partial class EntrerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabBC = new System.Windows.Forms.TabPage();
            this.btnValide = new System.Windows.Forms.Button();
            this.NumBC = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataBC = new System.Windows.Forms.DataGridView();
            this.dateSortie = new System.Windows.Forms.DateTimePicker();
            this.btnBC = new System.Windows.Forms.Button();
            this.comboFrs = new System.Windows.Forms.ComboBox();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EffAchat = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataDAchat = new System.Windows.Forms.DataGridView();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblPrixT = new System.Windows.Forms.Label();
            this.lblBonC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericQteD = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericPrix = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboArticle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ListeAchat = new System.Windows.Forms.TabPage();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBC)).BeginInit();
            this.EffAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQteD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrix)).BeginInit();
            this.ListeAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabBC);
            this.tabControl1.Controls.Add(this.EffAchat);
            this.tabControl1.Controls.Add(this.ListeAchat);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 536);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabBC
            // 
            this.TabBC.BackColor = System.Drawing.Color.AliceBlue;
            this.TabBC.Controls.Add(this.btnValide);
            this.TabBC.Controls.Add(this.NumBC);
            this.TabBC.Controls.Add(this.comboUser);
            this.TabBC.Controls.Add(this.label28);
            this.TabBC.Controls.Add(this.btnRefresh);
            this.TabBC.Controls.Add(this.dataBC);
            this.TabBC.Controls.Add(this.dateSortie);
            this.TabBC.Controls.Add(this.btnBC);
            this.TabBC.Controls.Add(this.comboFrs);
            this.TabBC.Controls.Add(this.btnAccueil);
            this.TabBC.Controls.Add(this.label6);
            this.TabBC.Controls.Add(this.label11);
            this.TabBC.Controls.Add(this.label16);
            this.TabBC.Location = new System.Drawing.Point(4, 22);
            this.TabBC.Name = "TabBC";
            this.TabBC.Size = new System.Drawing.Size(787, 510);
            this.TabBC.TabIndex = 2;
            this.TabBC.Text = "Bonne de Commande";
            // 
            // btnValide
            // 
            this.btnValide.AutoSize = true;
            this.btnValide.BackColor = System.Drawing.Color.AliceBlue;
            this.btnValide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnValide.Location = new System.Drawing.Point(6, 469);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(131, 38);
            this.btnValide.TabIndex = 155;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = false;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // NumBC
            // 
            this.NumBC.AutoSize = true;
            this.NumBC.Font = new System.Drawing.Font("Mongolian Baiti", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.NumBC.Location = new System.Drawing.Point(394, 11);
            this.NumBC.Name = "NumBC";
            this.NumBC.Size = new System.Drawing.Size(0, 36);
            this.NumBC.TabIndex = 154;
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(167, 107);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(200, 21);
            this.comboUser.TabIndex = 153;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label28.Location = new System.Drawing.Point(64, 110);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 18);
            this.label28.TabIndex = 152;
            this.label28.Text = "Utilisateur :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRefresh.BackgroundImage = global::QualiTech.Properties.Resources.icons8_refresh_20;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnRefresh.Location = new System.Drawing.Point(738, 134);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 38);
            this.btnRefresh.TabIndex = 112;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataBC
            // 
            this.dataBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBC.Location = new System.Drawing.Point(6, 178);
            this.dataBC.Name = "dataBC";
            this.dataBC.Size = new System.Drawing.Size(772, 287);
            this.dataBC.TabIndex = 111;
            this.dataBC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBC_CellClick);
            // 
            // dateSortie
            // 
            this.dateSortie.Location = new System.Drawing.Point(167, 80);
            this.dateSortie.Name = "dateSortie";
            this.dateSortie.Size = new System.Drawing.Size(200, 20);
            this.dateSortie.TabIndex = 108;
            // 
            // btnBC
            // 
            this.btnBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBC.ForeColor = System.Drawing.Color.White;
            this.btnBC.Location = new System.Drawing.Point(647, 469);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(137, 38);
            this.btnBC.TabIndex = 106;
            this.btnBC.Text = "Commander";
            this.btnBC.UseVisualStyleBackColor = false;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // comboFrs
            // 
            this.comboFrs.FormattingEnabled = true;
            this.comboFrs.Location = new System.Drawing.Point(167, 134);
            this.comboFrs.Name = "comboFrs";
            this.comboFrs.Size = new System.Drawing.Size(200, 21);
            this.comboFrs.TabIndex = 105;
            // 
            // btnAccueil
            // 
            this.btnAccueil.AutoSize = true;
            this.btnAccueil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAccueil.BackgroundImage = global::QualiTech.Properties.Resources.icons8_home_32;
            this.btnAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAccueil.Location = new System.Drawing.Point(736, 3);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(49, 38);
            this.btnAccueil.TabIndex = 101;
            this.btnAccueil.UseVisualStyleBackColor = false;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(64, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Fournisseur :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(65, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 96;
            this.label11.Text = "Date Achat :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label16.Location = new System.Drawing.Point(45, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(330, 38);
            this.label16.TabIndex = 93;
            this.label16.Text = "Bon de Commande : N° ";
            // 
            // EffAchat
            // 
            this.EffAchat.BackColor = System.Drawing.Color.AliceBlue;
            this.EffAchat.Controls.Add(this.btnUpdate);
            this.EffAchat.Controls.Add(this.dataDAchat);
            this.EffAchat.Controls.Add(this.txtRef);
            this.EffAchat.Controls.Add(this.txtDes);
            this.EffAchat.Controls.Add(this.lblPrixT);
            this.EffAchat.Controls.Add(this.lblBonC);
            this.EffAchat.Controls.Add(this.label3);
            this.EffAchat.Controls.Add(this.numericQteD);
            this.EffAchat.Controls.Add(this.label25);
            this.EffAchat.Controls.Add(this.label9);
            this.EffAchat.Controls.Add(this.btnAdd);
            this.EffAchat.Controls.Add(this.label4);
            this.EffAchat.Controls.Add(this.label2);
            this.EffAchat.Controls.Add(this.numericPrix);
            this.EffAchat.Controls.Add(this.label1);
            this.EffAchat.Controls.Add(this.btnclse);
            this.EffAchat.Controls.Add(this.btnSave);
            this.EffAchat.Controls.Add(this.label12);
            this.EffAchat.Controls.Add(this.comboArticle);
            this.EffAchat.Controls.Add(this.label10);
            this.EffAchat.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.EffAchat.Location = new System.Drawing.Point(4, 22);
            this.EffAchat.Name = "EffAchat";
            this.EffAchat.Padding = new System.Windows.Forms.Padding(3);
            this.EffAchat.Size = new System.Drawing.Size(787, 510);
            this.EffAchat.TabIndex = 0;
            this.EffAchat.Text = "Effectuer un Achat";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnUpdate.Location = new System.Drawing.Point(633, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 38);
            this.btnUpdate.TabIndex = 176;
            this.btnUpdate.Text = "Modifier Achat";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataDAchat
            // 
            this.dataDAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDAchat.Location = new System.Drawing.Point(6, 230);
            this.dataDAchat.Name = "dataDAchat";
            this.dataDAchat.Size = new System.Drawing.Size(775, 233);
            this.dataDAchat.TabIndex = 175;
            this.dataDAchat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDAchat_CellClick);
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtRef.Location = new System.Drawing.Point(195, 119);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(201, 23);
            this.txtRef.TabIndex = 174;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.txtDes.Location = new System.Drawing.Point(542, 86);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(201, 23);
            this.txtDes.TabIndex = 173;
            // 
            // lblPrixT
            // 
            this.lblPrixT.AutoSize = true;
            this.lblPrixT.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrixT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.lblPrixT.Location = new System.Drawing.Point(567, 155);
            this.lblPrixT.Name = "lblPrixT";
            this.lblPrixT.Size = new System.Drawing.Size(142, 19);
            this.lblPrixT.TabIndex = 171;
            this.lblPrixT.Text = "..........................Dhs";
            // 
            // lblBonC
            // 
            this.lblBonC.AutoSize = true;
            this.lblBonC.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblBonC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.lblBonC.Location = new System.Drawing.Point(220, 59);
            this.lblBonC.Name = "lblBonC";
            this.lblBonC.Size = new System.Drawing.Size(78, 18);
            this.lblBonC.TabIndex = 170;
            this.lblBonC.Text = "............./2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(99, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 169;
            this.label3.Text = "Numero BC :";
            // 
            // numericQteD
            // 
            this.numericQteD.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.numericQteD.Location = new System.Drawing.Point(195, 150);
            this.numericQteD.Name = "numericQteD";
            this.numericQteD.Size = new System.Drawing.Size(200, 23);
            this.numericQteD.TabIndex = 166;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label25.Location = new System.Drawing.Point(65, 155);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 18);
            this.label25.TabIndex = 163;
            this.label25.Text = "Qantité Demandée :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(45, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 38);
            this.label9.TabIndex = 160;
            this.label9.Text = "Articles Commandés : ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnAdd.Location = new System.Drawing.Point(3, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 38);
            this.btnAdd.TabIndex = 157;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(440, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 155;
            this.label4.Text = "Prix Total HT :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 153;
            this.label2.Text = "Reference :";
            // 
            // numericPrix
            // 
            this.numericPrix.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.numericPrix.Location = new System.Drawing.Point(543, 117);
            this.numericPrix.Name = "numericPrix";
            this.numericPrix.Size = new System.Drawing.Size(200, 23);
            this.numericPrix.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(441, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 149;
            this.label1.Text = "Prix Unitaire :";
            // 
            // btnclse
            // 
            this.btnclse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnclse.BackgroundImage = global::QualiTech.Properties.Resources.icons8_home_32;
            this.btnclse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclse.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnclse.Location = new System.Drawing.Point(731, 3);
            this.btnclse.Name = "btnclse";
            this.btnclse.Size = new System.Drawing.Size(50, 38);
            this.btnclse.TabIndex = 144;
            this.btnclse.UseVisualStyleBackColor = false;
            this.btnclse.Click += new System.EventHandler(this.btnclse_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(650, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 38);
            this.btnSave.TabIndex = 143;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(441, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 136;
            this.label12.Text = "Designation :";
            // 
            // comboArticle
            // 
            this.comboArticle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.comboArticle.FormattingEnabled = true;
            this.comboArticle.Location = new System.Drawing.Point(195, 87);
            this.comboArticle.Name = "comboArticle";
            this.comboArticle.Size = new System.Drawing.Size(200, 25);
            this.comboArticle.TabIndex = 135;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(65, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 134;
            this.label10.Text = "Article Type :";
            // 
            // ListeAchat
            // 
            this.ListeAchat.BackColor = System.Drawing.Color.AliceBlue;
            this.ListeAchat.Controls.Add(this.btnActualiser);
            this.ListeAchat.Controls.Add(this.dataList);
            this.ListeAchat.Controls.Add(this.label14);
            this.ListeAchat.Location = new System.Drawing.Point(4, 22);
            this.ListeAchat.Name = "ListeAchat";
            this.ListeAchat.Padding = new System.Windows.Forms.Padding(3);
            this.ListeAchat.Size = new System.Drawing.Size(787, 510);
            this.ListeAchat.TabIndex = 1;
            this.ListeAchat.Text = "Liste des Achats";
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.AliceBlue;
            this.btnActualiser.BackgroundImage = global::QualiTech.Properties.Resources.icons8_refresh_20;
            this.btnActualiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnActualiser.Location = new System.Drawing.Point(738, 54);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(43, 38);
            this.btnActualiser.TabIndex = 87;
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // dataList
            // 
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Location = new System.Drawing.Point(3, 98);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(778, 406);
            this.dataList.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(31, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 38);
            this.label14.TabIndex = 85;
            this.label14.Text = "Liste des Achats";
            // 
            // EntrerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 537);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntrerForm";
            this.Text = "Gestion des Achats";
            this.Load += new System.EventHandler(this.EntrerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabBC.ResumeLayout(false);
            this.TabBC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBC)).EndInit();
            this.EffAchat.ResumeLayout(false);
            this.EffAchat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQteD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrix)).EndInit();
            this.ListeAchat.ResumeLayout(false);
            this.ListeAchat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EffAchat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage ListeAchat;
        private System.Windows.Forms.TabPage TabBC;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataBC;
        private System.Windows.Forms.DateTimePicker dateSortie;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.ComboBox comboFrs;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericQteD;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label NumBC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBonC;
        private System.Windows.Forms.Label lblPrixT;
        private System.Windows.Forms.ComboBox comboArticle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.DataGridView dataDAchat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnValide;
    }
}