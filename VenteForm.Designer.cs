namespace QualiTech
{
    partial class VenteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenteForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabFacture = new System.Windows.Forms.TabPage();
            this.btnValide = new System.Windows.Forms.Button();
            this.NumFacture = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridBL = new System.Windows.Forms.DataGridView();
            this.dateSortie = new System.Windows.Forms.DateTimePicker();
            this.btnFacture = new System.Windows.Forms.Button();
            this.comboClt = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EffVente = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboDes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrixU = new System.Windows.Forms.Label();
            this.lblQteS = new System.Windows.Forms.Label();
            this.lblPrixT = new System.Windows.Forms.Label();
            this.lblFacture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.numericQteD = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddOtherArt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRef = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVente = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboArticle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ListeVente = new System.Windows.Forms.TabPage();
            this.btnActualise = new System.Windows.Forms.Button();
            this.dataListV = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1.SuspendLayout();
            this.TabFacture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBL)).BeginInit();
            this.EffVente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQteD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVente)).BeginInit();
            this.ListeVente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabFacture);
            this.tabControl1.Controls.Add(this.EffVente);
            this.tabControl1.Controls.Add(this.ListeVente);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 536);
            this.tabControl1.TabIndex = 2;
            // 
            // TabFacture
            // 
            this.TabFacture.BackColor = System.Drawing.Color.AliceBlue;
            this.TabFacture.Controls.Add(this.btnValide);
            this.TabFacture.Controls.Add(this.NumFacture);
            this.TabFacture.Controls.Add(this.comboUser);
            this.TabFacture.Controls.Add(this.label28);
            this.TabFacture.Controls.Add(this.btnRefresh);
            this.TabFacture.Controls.Add(this.dataGridBL);
            this.TabFacture.Controls.Add(this.dateSortie);
            this.TabFacture.Controls.Add(this.btnFacture);
            this.TabFacture.Controls.Add(this.comboClt);
            this.TabFacture.Controls.Add(this.btnReturn);
            this.TabFacture.Controls.Add(this.label6);
            this.TabFacture.Controls.Add(this.label11);
            this.TabFacture.Controls.Add(this.label16);
            this.TabFacture.Location = new System.Drawing.Point(4, 22);
            this.TabFacture.Name = "TabFacture";
            this.TabFacture.Size = new System.Drawing.Size(787, 510);
            this.TabFacture.TabIndex = 2;
            this.TabFacture.Text = "Facture ";
            // 
            // btnValide
            // 
            this.btnValide.AutoSize = true;
            this.btnValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnValide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValide.ForeColor = System.Drawing.Color.White;
            this.btnValide.Location = new System.Drawing.Point(602, 469);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(184, 38);
            this.btnValide.TabIndex = 156;
            this.btnValide.Text = "Valider la modification ";
            this.btnValide.UseVisualStyleBackColor = false;
            // 
            // NumFacture
            // 
            this.NumFacture.AutoSize = true;
            this.NumFacture.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.NumFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.NumFacture.Location = new System.Drawing.Point(193, 21);
            this.NumFacture.Name = "NumFacture";
            this.NumFacture.Size = new System.Drawing.Size(183, 38);
            this.NumFacture.TabIndex = 154;
            this.NumFacture.Text = "............../2024";
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(165, 108);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(200, 21);
            this.comboUser.TabIndex = 153;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.label28.Location = new System.Drawing.Point(64, 108);
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
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(742, 135);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 38);
            this.btnRefresh.TabIndex = 112;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridBL
            // 
            this.dataGridBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBL.Location = new System.Drawing.Point(7, 179);
            this.dataGridBL.Name = "dataGridBL";
            this.dataGridBL.Size = new System.Drawing.Size(776, 284);
            this.dataGridBL.TabIndex = 111;
            this.dataGridBL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBL_CellClick);
            // 
            // dateSortie
            // 
            this.dateSortie.Location = new System.Drawing.Point(165, 80);
            this.dateSortie.Name = "dateSortie";
            this.dateSortie.Size = new System.Drawing.Size(200, 20);
            this.dateSortie.TabIndex = 108;
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacture.ForeColor = System.Drawing.Color.White;
            this.btnFacture.Location = new System.Drawing.Point(3, 469);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(176, 38);
            this.btnFacture.TabIndex = 106;
            this.btnFacture.Text = "Effectuer une Vente";
            this.btnFacture.UseVisualStyleBackColor = false;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            // 
            // comboClt
            // 
            this.comboClt.FormattingEnabled = true;
            this.comboClt.Location = new System.Drawing.Point(165, 135);
            this.comboClt.Name = "comboClt";
            this.comboClt.Size = new System.Drawing.Size(200, 21);
            this.comboClt.TabIndex = 105;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReturn.BackgroundImage = global::QualiTech.Properties.Resources.icons8_home_32;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(742, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(45, 38);
            this.btnReturn.TabIndex = 101;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(64, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Client :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(64, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 96;
            this.label11.Text = "Date Vente :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label16.Location = new System.Drawing.Point(45, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 38);
            this.label16.TabIndex = 93;
            this.label16.Text = "Facture N° ";
            // 
            // EffVente
            // 
            this.EffVente.BackColor = System.Drawing.Color.AliceBlue;
            this.EffVente.Controls.Add(this.btnDelete);
            this.EffVente.Controls.Add(this.comboDes);
            this.EffVente.Controls.Add(this.label12);
            this.EffVente.Controls.Add(this.lblPrixU);
            this.EffVente.Controls.Add(this.lblQteS);
            this.EffVente.Controls.Add(this.lblPrixT);
            this.EffVente.Controls.Add(this.lblFacture);
            this.EffVente.Controls.Add(this.label3);
            this.EffVente.Controls.Add(this.label24);
            this.EffVente.Controls.Add(this.numericQteD);
            this.EffVente.Controls.Add(this.label25);
            this.EffVente.Controls.Add(this.label9);
            this.EffVente.Controls.Add(this.btnAddOtherArt);
            this.EffVente.Controls.Add(this.label4);
            this.EffVente.Controls.Add(this.comboRef);
            this.EffVente.Controls.Add(this.label2);
            this.EffVente.Controls.Add(this.label1);
            this.EffVente.Controls.Add(this.dataGridVente);
            this.EffVente.Controls.Add(this.btnPrint);
            this.EffVente.Controls.Add(this.btnSave);
            this.EffVente.Controls.Add(this.comboArticle);
            this.EffVente.Controls.Add(this.label10);
            this.EffVente.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.EffVente.Location = new System.Drawing.Point(4, 22);
            this.EffVente.Name = "EffVente";
            this.EffVente.Padding = new System.Windows.Forms.Padding(3);
            this.EffVente.Size = new System.Drawing.Size(787, 510);
            this.EffVente.TabIndex = 0;
            this.EffVente.Text = "Effectuer une Vente";
            this.EffVente.Click += new System.EventHandler(this.EffVente_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(327, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 38);
            this.btnDelete.TabIndex = 181;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboDes
            // 
            this.comboDes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.comboDes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboDes.FormattingEnabled = true;
            this.comboDes.Location = new System.Drawing.Point(144, 129);
            this.comboDes.Name = "comboDes";
            this.comboDes.Size = new System.Drawing.Size(201, 25);
            this.comboDes.TabIndex = 180;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(55, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 179;
            this.label12.Text = "Designation :";
            // 
            // lblPrixU
            // 
            this.lblPrixU.AutoSize = true;
            this.lblPrixU.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrixU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.lblPrixU.Location = new System.Drawing.Point(183, 196);
            this.lblPrixU.Name = "lblPrixU";
            this.lblPrixU.Size = new System.Drawing.Size(79, 21);
            this.lblPrixU.TabIndex = 178;
            this.lblPrixU.Text = " 00,00 Dhs";
            // 
            // lblQteS
            // 
            this.lblQteS.AutoSize = true;
            this.lblQteS.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblQteS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.lblQteS.Location = new System.Drawing.Point(267, 172);
            this.lblQteS.Name = "lblQteS";
            this.lblQteS.Size = new System.Drawing.Size(38, 18);
            this.lblQteS.TabIndex = 172;
            this.lblQteS.Text = "..........";
            // 
            // lblPrixT
            // 
            this.lblPrixT.AutoSize = true;
            this.lblPrixT.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrixT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.lblPrixT.Location = new System.Drawing.Point(603, 196);
            this.lblPrixT.Name = "lblPrixT";
            this.lblPrixT.Size = new System.Drawing.Size(75, 21);
            this.lblPrixT.TabIndex = 171;
            this.lblPrixT.Text = "00,00 Dhs";
            // 
            // lblFacture
            // 
            this.lblFacture.AutoSize = true;
            this.lblFacture.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.lblFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.lblFacture.Location = new System.Drawing.Point(139, 62);
            this.lblFacture.Name = "lblFacture";
            this.lblFacture.Size = new System.Drawing.Size(78, 18);
            this.lblFacture.TabIndex = 170;
            this.lblFacture.Text = "............./2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(64, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 169;
            this.label3.Text = "Facture N°";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label24.Location = new System.Drawing.Point(121, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 18);
            this.label24.TabIndex = 167;
            this.label24.Text = "Qantité de stock :";
            // 
            // numericQteD
            // 
            this.numericQteD.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.numericQteD.Location = new System.Drawing.Point(522, 128);
            this.numericQteD.Name = "numericQteD";
            this.numericQteD.Size = new System.Drawing.Size(200, 25);
            this.numericQteD.TabIndex = 166;
            this.numericQteD.ValueChanged += new System.EventHandler(this.numericQteD_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label25.Location = new System.Drawing.Point(373, 134);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 18);
            this.label25.TabIndex = 163;
            this.label25.Text = "Qantité de Demandée :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(45, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 38);
            this.label9.TabIndex = 160;
            this.label9.Text = "Articles à Vendre  ";
            // 
            // btnAddOtherArt
            // 
            this.btnAddOtherArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnAddOtherArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOtherArt.ForeColor = System.Drawing.Color.White;
            this.btnAddOtherArt.Location = new System.Drawing.Point(476, 469);
            this.btnAddOtherArt.Name = "btnAddOtherArt";
            this.btnAddOtherArt.Size = new System.Drawing.Size(134, 38);
            this.btnAddOtherArt.TabIndex = 157;
            this.btnAddOtherArt.Text = "Nouvel Article";
            this.btnAddOtherArt.UseVisualStyleBackColor = false;
            this.btnAddOtherArt.Click += new System.EventHandler(this.btnAddOtherArt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(504, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 155;
            this.label4.Text = "Prix Total HT ";
            // 
            // comboRef
            // 
            this.comboRef.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.comboRef.FormattingEnabled = true;
            this.comboRef.Location = new System.Drawing.Point(522, 90);
            this.comboRef.Name = "comboRef";
            this.comboRef.Size = new System.Drawing.Size(200, 25);
            this.comboRef.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(373, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 153;
            this.label2.Text = "Reference :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(87, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 149;
            this.label1.Text = "Prix Unitaire";
            // 
            // dataGridVente
            // 
            this.dataGridVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVente.Location = new System.Drawing.Point(6, 242);
            this.dataGridVente.Name = "dataGridVente";
            this.dataGridVente.Size = new System.Drawing.Size(777, 221);
            this.dataGridVente.TabIndex = 148;
            this.dataGridVente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVente_CellClick);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnPrint.Location = new System.Drawing.Point(6, 469);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 38);
            this.btnPrint.TabIndex = 144;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(626, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 38);
            this.btnSave.TabIndex = 143;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboArticle
            // 
            this.comboArticle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.comboArticle.FormattingEnabled = true;
            this.comboArticle.Location = new System.Drawing.Point(145, 95);
            this.comboArticle.Name = "comboArticle";
            this.comboArticle.Size = new System.Drawing.Size(200, 25);
            this.comboArticle.TabIndex = 135;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(55, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 134;
            this.label10.Text = "Article Type :";
            // 
            // ListeVente
            // 
            this.ListeVente.BackColor = System.Drawing.Color.AliceBlue;
            this.ListeVente.Controls.Add(this.btnActualise);
            this.ListeVente.Controls.Add(this.dataListV);
            this.ListeVente.Controls.Add(this.label14);
            this.ListeVente.Location = new System.Drawing.Point(4, 22);
            this.ListeVente.Name = "ListeVente";
            this.ListeVente.Padding = new System.Windows.Forms.Padding(3);
            this.ListeVente.Size = new System.Drawing.Size(787, 510);
            this.ListeVente.TabIndex = 1;
            this.ListeVente.Text = "Liste des Ventes";
            // 
            // btnActualise
            // 
            this.btnActualise.BackColor = System.Drawing.Color.AliceBlue;
            this.btnActualise.BackgroundImage = global::QualiTech.Properties.Resources.icons8_refresh_20;
            this.btnActualise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualise.ForeColor = System.Drawing.Color.White;
            this.btnActualise.Location = new System.Drawing.Point(744, 37);
            this.btnActualise.Name = "btnActualise";
            this.btnActualise.Size = new System.Drawing.Size(39, 38);
            this.btnActualise.TabIndex = 87;
            this.btnActualise.UseVisualStyleBackColor = false;
            this.btnActualise.Click += new System.EventHandler(this.btnActualise_Click);
            // 
            // dataListV
            // 
            this.dataListV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListV.Location = new System.Drawing.Point(6, 79);
            this.dataListV.Name = "dataListV";
            this.dataListV.Size = new System.Drawing.Size(777, 426);
            this.dataListV.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(45, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 38);
            this.label14.TabIndex = 85;
            this.label14.Text = "Liste des Ventes";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // VenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 540);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VenteForm";
            this.Text = "Gestion des Ventes";
            this.Load += new System.EventHandler(this.VenteForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabFacture.ResumeLayout(false);
            this.TabFacture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBL)).EndInit();
            this.EffVente.ResumeLayout(false);
            this.EffVente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQteD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVente)).EndInit();
            this.ListeVente.ResumeLayout(false);
            this.ListeVente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabFacture;
        private System.Windows.Forms.Label NumFacture;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridBL;
        private System.Windows.Forms.DateTimePicker dateSortie;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.ComboBox comboClt;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage EffVente;
        private System.Windows.Forms.Label lblQteS;
        private System.Windows.Forms.Label lblPrixT;
        private System.Windows.Forms.Label lblFacture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numericQteD;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddOtherArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVente;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboArticle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage ListeVente;
        private System.Windows.Forms.Button btnActualise;
        private System.Windows.Forms.DataGridView dataListV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Label lblPrixU;
        private System.Windows.Forms.ComboBox comboDes;
        private System.Windows.Forms.Label label12;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnDelete;
    }
}