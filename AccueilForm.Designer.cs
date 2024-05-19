namespace QualiTech
{
    partial class AccueilForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAchat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVente = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClient = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblQteV = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblQteA = new System.Windows.Forms.Label();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.btnCheckLowStock = new System.Windows.Forms.Button();
            this.lblRupture = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion  de Stock";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(218, 538);
            this.sidebar.MinimumSize = new System.Drawing.Size(52, 538);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(218, 538);
            this.sidebar.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 109);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quali-Tech";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::QualiTech.Properties.Resources.Image2;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(64, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 56);
            this.panel5.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnHome.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-6, -17);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(245, 72);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAchat);
            this.panel2.Location = new System.Drawing.Point(3, 161);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(242, 37);
            this.panel2.TabIndex = 1;
            // 
            // btnAchat
            // 
            this.btnAchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnAchat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAchat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnAchat.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAchat.Image = ((System.Drawing.Image)(resources.GetObject("btnAchat.Image")));
            this.btnAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAchat.Location = new System.Drawing.Point(-6, -17);
            this.btnAchat.Margin = new System.Windows.Forms.Padding(10);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAchat.Size = new System.Drawing.Size(245, 72);
            this.btnAchat.TabIndex = 4;
            this.btnAchat.Text = "         Achat";
            this.btnAchat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAchat.UseVisualStyleBackColor = false;
            this.btnAchat.Click += new System.EventHandler(this.btnAchat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVente);
            this.panel3.Location = new System.Drawing.Point(3, 204);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(242, 37);
            this.panel3.TabIndex = 2;
            // 
            // btnVente
            // 
            this.btnVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnVente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnVente.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnVente.Image = ((System.Drawing.Image)(resources.GetObject("btnVente.Image")));
            this.btnVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVente.Location = new System.Drawing.Point(-6, -17);
            this.btnVente.Name = "btnVente";
            this.btnVente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVente.Size = new System.Drawing.Size(232, 77);
            this.btnVente.TabIndex = 5;
            this.btnVente.Text = "          Vente";
            this.btnVente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVente.UseVisualStyleBackColor = false;
            this.btnVente.Click += new System.EventHandler(this.btnVente_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnStock);
            this.panel6.Location = new System.Drawing.Point(3, 247);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(242, 37);
            this.panel6.TabIndex = 2;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnStock.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(-6, -17);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(232, 65);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "          Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnClient);
            this.panel7.Location = new System.Drawing.Point(3, 290);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(242, 37);
            this.panel7.TabIndex = 2;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnClient.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(-6, -17);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(236, 65);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "          Clients";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnFournisseur);
            this.panel8.Location = new System.Drawing.Point(3, 333);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(242, 37);
            this.panel8.TabIndex = 2;
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFournisseur.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnFournisseur.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("btnFournisseur.Image")));
            this.btnFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFournisseur.Location = new System.Drawing.Point(-6, -17);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFournisseur.Size = new System.Drawing.Size(237, 65);
            this.btnFournisseur.TabIndex = 2;
            this.btnFournisseur.Text = "          Fournisseurs";
            this.btnFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFournisseur.UseVisualStyleBackColor = false;
            this.btnFournisseur.Click += new System.EventHandler(this.btnFournisseur_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnAdmin);
            this.panel9.Location = new System.Drawing.Point(3, 376);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.panel9.Size = new System.Drawing.Size(242, 37);
            this.panel9.TabIndex = 3;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.25F);
            this.btnAdmin.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAdmin.Image = global::QualiTech.Properties.Resources.icons8_admin_32;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(-6, -17);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(240, 65);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "          Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnLogout);
            this.panel10.Location = new System.Drawing.Point(3, 419);
            this.panel10.Name = "panel10";
            this.panel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel10.Size = new System.Drawing.Size(200, 112);
            this.panel10.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(-178, -13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(408, 194);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CircleProgressBar1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleProgressBar1.Image")));
            this.guna2CircleProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CircleProgressBar1.InnerColor = System.Drawing.Color.AliceBlue;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(439, 81);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.AliceBlue;
            this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(130, 131);
            this.guna2CircleProgressBar1.TabIndex = 28;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.AliceBlue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(224, 230);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.SystemColors.InactiveCaption;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.Name = "Ventes";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            series2.Legend = "Legend1";
            series2.Name = "Achats";
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(564, 301);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(83)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(449, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Objectif du Mois";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblCA.ForeColor = System.Drawing.Color.Lime;
            this.lblCA.Location = new System.Drawing.Point(301, 103);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(32, 21);
            this.lblCA.TabIndex = 31;
            this.lblCA.Text = "CA";
            // 
            // lblQteV
            // 
            this.lblQteV.AutoSize = true;
            this.lblQteV.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblQteV.ForeColor = System.Drawing.Color.Red;
            this.lblQteV.Location = new System.Drawing.Point(623, 103);
            this.lblQteV.Name = "lblQteV";
            this.lblQteV.Size = new System.Drawing.Size(54, 21);
            this.lblQteV.TabIndex = 32;
            this.lblQteV.Text = "Unités";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblCharge.ForeColor = System.Drawing.Color.Red;
            this.lblCharge.Location = new System.Drawing.Point(301, 170);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(64, 21);
            this.lblCharge.TabIndex = 33;
            this.lblCharge.Text = "Charges";
            // 
            // lblQteA
            // 
            this.lblQteA.AutoSize = true;
            this.lblQteA.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblQteA.ForeColor = System.Drawing.Color.Lime;
            this.lblQteA.Location = new System.Drawing.Point(623, 170);
            this.lblQteA.Name = "lblQteA";
            this.lblQteA.Size = new System.Drawing.Size(54, 21);
            this.lblQteA.TabIndex = 34;
            this.lblQteA.Text = "Unités";
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // btnCheckLowStock
            // 
            this.btnCheckLowStock.Location = new System.Drawing.Point(691, 290);
            this.btnCheckLowStock.Name = "btnCheckLowStock";
            this.btnCheckLowStock.Size = new System.Drawing.Size(80, 37);
            this.btnCheckLowStock.TabIndex = 36;
            this.btnCheckLowStock.Text = "Check Low Stock";
            this.btnCheckLowStock.UseVisualStyleBackColor = true;
            this.btnCheckLowStock.Click += new System.EventHandler(this.btnCheckLowStock_Click);
            // 
            // lblRupture
            // 
            this.lblRupture.AutoSize = true;
            this.lblRupture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRupture.ForeColor = System.Drawing.Color.Red;
            this.lblRupture.Location = new System.Drawing.Point(664, 357);
            this.lblRupture.Name = "lblRupture";
            this.lblRupture.Size = new System.Drawing.Size(111, 13);
            this.lblRupture.TabIndex = 37;
            this.lblRupture.Text = "Articles en rupture";
            // 
            // AccueilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(799, 538);
            this.Controls.Add(this.lblRupture);
            this.Controls.Add(this.btnCheckLowStock);
            this.Controls.Add(this.lblQteA);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblQteV);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccueilForm";
            this.Text = "QualiTech";
            this.Load += new System.EventHandler(this.AccueilForm_Load);
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAchat;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnVente;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnFournisseur;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblQteV;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblQteA;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCheckLowStock;
        private System.Windows.Forms.Label lblRupture;
    }
}