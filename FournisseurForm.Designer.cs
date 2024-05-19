namespace QualiTech
{
    partial class FournisseurForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UpdateFournisseurs = new System.Windows.Forms.TabPage();
            this.btnNew = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelette = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSte = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListeFourniseurs = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.UpdateFournisseurs.SuspendLayout();
            this.ListeFourniseurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UpdateFournisseurs);
            this.tabControl1.Controls.Add(this.ListeFourniseurs);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 513);
            this.tabControl1.TabIndex = 1;
            // 
            // UpdateFournisseurs
            // 
            this.UpdateFournisseurs.Controls.Add(this.btnHome);
            this.UpdateFournisseurs.Controls.Add(this.btnNew);
            this.UpdateFournisseurs.Controls.Add(this.comboType);
            this.UpdateFournisseurs.Controls.Add(this.label15);
            this.UpdateFournisseurs.Controls.Add(this.btnReturn);
            this.UpdateFournisseurs.Controls.Add(this.txtVille);
            this.UpdateFournisseurs.Controls.Add(this.label7);
            this.UpdateFournisseurs.Controls.Add(this.btnUpdate);
            this.UpdateFournisseurs.Controls.Add(this.btnDelette);
            this.UpdateFournisseurs.Controls.Add(this.btnAdd);
            this.UpdateFournisseurs.Controls.Add(this.btnSearch);
            this.UpdateFournisseurs.Controls.Add(this.label9);
            this.UpdateFournisseurs.Controls.Add(this.txtSearch);
            this.UpdateFournisseurs.Controls.Add(this.txtTel);
            this.UpdateFournisseurs.Controls.Add(this.txtSte);
            this.UpdateFournisseurs.Controls.Add(this.txtMail);
            this.UpdateFournisseurs.Controls.Add(this.label5);
            this.UpdateFournisseurs.Controls.Add(this.label3);
            this.UpdateFournisseurs.Controls.Add(this.label2);
            this.UpdateFournisseurs.Controls.Add(this.label1);
            this.UpdateFournisseurs.Location = new System.Drawing.Point(4, 22);
            this.UpdateFournisseurs.Name = "UpdateFournisseurs";
            this.UpdateFournisseurs.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateFournisseurs.Size = new System.Drawing.Size(773, 487);
            this.UpdateFournisseurs.TabIndex = 0;
            this.UpdateFournisseurs.Text = "Gérer les fournisseurs";
            this.UpdateFournisseurs.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(92, 359);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 36);
            this.btnNew.TabIndex = 80;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(170, 299);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(197, 21);
            this.comboType.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 19);
            this.label15.TabIndex = 78;
            this.label15.Text = "Type d\'article :";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(555, 361);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 36);
            this.btnReturn.TabIndex = 77;
            this.btnReturn.Text = "Accueil";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(168, 253);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(197, 20);
            this.txtVille.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Ville :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(555, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 38);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelette
            // 
            this.btnDelette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnDelette.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelette.ForeColor = System.Drawing.Color.White;
            this.btnDelette.Location = new System.Drawing.Point(555, 215);
            this.btnDelette.Name = "btnDelette";
            this.btnDelette.Size = new System.Drawing.Size(131, 38);
            this.btnDelette.TabIndex = 73;
            this.btnDelette.Text = "Supprimer";
            this.btnDelette.UseVisualStyleBackColor = false;
            this.btnDelette.Click += new System.EventHandler(this.btnDelette_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(229, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 38);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(555, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 38);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.Text = "Recherche";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "Chercher :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(543, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 69;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(168, 157);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(197, 20);
            this.txtTel.TabIndex = 67;
            // 
            // txtSte
            // 
            this.txtSte.Location = new System.Drawing.Point(168, 99);
            this.txtSte.Name = "txtSte";
            this.txtSte.Size = new System.Drawing.Size(197, 20);
            this.txtSte.TabIndex = 66;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(168, 204);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(197, 20);
            this.txtMail.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tél/Fax :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Entreprise :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "E-mail :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 36);
            this.label1.TabIndex = 60;
            this.label1.Text = "Gérer les Fournisseurs";
            // 
            // ListeFourniseurs
            // 
            this.ListeFourniseurs.Controls.Add(this.btnRefresh);
            this.ListeFourniseurs.Controls.Add(this.dataGridView1);
            this.ListeFourniseurs.Controls.Add(this.label14);
            this.ListeFourniseurs.Location = new System.Drawing.Point(4, 22);
            this.ListeFourniseurs.Name = "ListeFourniseurs";
            this.ListeFourniseurs.Padding = new System.Windows.Forms.Padding(3);
            this.ListeFourniseurs.Size = new System.Drawing.Size(773, 487);
            this.ListeFourniseurs.TabIndex = 1;
            this.ListeFourniseurs.Text = "Liste des Fournisseurs";
            this.ListeFourniseurs.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(636, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 38);
            this.btnRefresh.TabIndex = 81;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 377);
            this.dataGridView1.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(23, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(339, 36);
            this.label14.TabIndex = 78;
            this.label14.Text = "Liste des Fournisseurs";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHome.BackgroundImage = global::QualiTech.Properties.Resources.icons8_home_32;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(722, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 38);
            this.btnHome.TabIndex = 102;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FournisseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "FournisseurForm";
            this.Text = "FournisseurForm";
            this.Load += new System.EventHandler(this.FournisseurForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.UpdateFournisseurs.ResumeLayout(false);
            this.UpdateFournisseurs.PerformLayout();
            this.ListeFourniseurs.ResumeLayout(false);
            this.ListeFourniseurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UpdateFournisseurs;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelette;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSte;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ListeFourniseurs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnHome;
    }
}