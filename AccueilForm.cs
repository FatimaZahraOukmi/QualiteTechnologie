using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class AccueilForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();
        Timer timer = new Timer();
        int progress_value = 0;
        int salesGoal = 500000;
        public AccueilForm()
        {
            InitializeComponent();
            var data = GSe.Achat.AsQueryable().GroupBy(da => da.AchatId)
                .Select(g => new
                {
                    Id = g.Key,
                    Montant_Achat = g.Sum(da => da.Montant_Total)
                })
                .ToList();
            var dataV = GSe.Vente.AsQueryable().GroupBy(da => da.VenteId)
                .Select(g => new
                {
                    VenteId = g.Key,
                    Montant_Total = g.Sum(da => da.Montant_Total)
                })
                 .ToList();
            chart1.Series[0].Points.DataBind(data, "Id", "Montant_Achat", "");
            chart1.Series[1].Points.DataBind(dataV, "VenteId", "Montant_Total", "");
        }
        private void ArticleRupture()
        {
            var lowStockProducts = GSe.Articles.Where(p => p.QuantiteStock <= 3).ToList();
            int nbArticlesRupture = lowStockProducts.Count();
            // Afficher le nombre d'articles en rupture de stock dans label3
            lblRupture.Text = nbArticlesRupture + " Article" + (nbArticlesRupture != 1 ? "s" : "") + " en rupture";
        }
        private void AccueilForm_Load(object sender, EventArgs e)
        {
            ArticleRupture();
            //Les statistiques :
            decimal TotalOrders = GetTotalOrders();
            lblCharge.Text = "-" + TotalOrders.ToString("N2") + " Dhs";
            decimal TotalQteA = GetTotalQteA();
            lblQteA.Text = "+" + TotalQteA.ToString() + " Unités";
            decimal totalQte = GetTotalQte();
            lblQteV.Text = "-" + totalQte.ToString() + " Unités";
            decimal totalSales = GetTotalSales();
            lblCA.Text = "+" + totalSales.ToString("N2") + " Dhs";
            guna2CircleProgressBar1.FillColor = Color.AliceBlue;
            guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(27, 83, 160);
            // Configuration initiale
            guna2CircleProgressBar1.Value = 0;
            guna2CircleProgressBar1.Animated = true;
            // Ajout du contrôle au formulaire
            totalSales = GetTotalSales();
            int percentage = (int)((totalSales * 100) / salesGoal);
            guna2CircleProgressBar1.Value = percentage;
            this.Controls.Add(guna2CircleProgressBar1);
            // Ajout d'un label pour afficher le pourcentage
            Label percentageLabel = new Label();
            // Calculer le pourcentage
            double prc = (double)((totalSales / salesGoal) * 100);
            // Mettre à jour le texte du label
            percentageLabel.Text = $"{prc:F1}% ";
            percentageLabel.AutoSize = true;
            percentageLabel.ForeColor = Color.FromArgb(27, 83, 160);
            percentageLabel.Location = new Point(483, 218); // Positionner juste en dessous du progressBar
            percentageLabel.Font = new Font(percentageLabel.Font, FontStyle.Bold);
            this.Controls.Add(percentageLabel);
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }
        decimal totalSales = 0;
        private int GetTotalSales()
        {
            foreach (var vente in GSe.Vente)
            {
                totalSales += vente.Montant_Total;
            }
            return (int)totalSales;
        }
        private decimal GetTotalQte()
        {
            decimal totalQte = 0;
            foreach (var venteD in GSe.DetailVente)
            {
                if (venteD.Quantite.HasValue) // Vérifiez si la quantité est définie
                {
                    totalQte += (decimal)venteD.Quantite; // Conversion explicite de int? à decimal
                }
            }
            return totalQte;
        }
        private decimal GetTotalQteA()
        {
            decimal totalQteA = 0;
            foreach (var AchatD in GSe.DetailAchat)
            {
                if (AchatD.Quantite.HasValue) // Vérifiez si la quantité est définie
                {
                    totalQteA += (decimal)AchatD.Quantite; // Conversion explicite de int? à decimal
                }
            }
            return totalQteA;
        }
        private decimal GetTotalOrders()
        {
            decimal TotalOrders = 0;
            foreach (var AchatD in GSe.Achat)
            {
                TotalOrders += AchatD.Montant_Total;
            }
            return TotalOrders;
        }
        public DbSet<DetailAchat> DetailAchats { get; set; }
        public DbSet<Achat> achat { get; set; }
        public DbSet<Vente> vente { get; set; }
        public class Achats
        {
            public int Id { get; set; }
            public decimal Montant_Total { get; set; }
            public DateTime Date_Achat { get; set; }
        }
        public class Ventes
        {
            public int Id { get; set; }
            public decimal Montant_Total { get; set; }
            public DateTime Date_Vente { get; set; }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            int totalSales = GetTotalSales();
            int targetSales = 100;

            int percentage = (totalSales * 100) / targetSales;

            if (progress_value < percentage)
            {
                progress_value++;
                guna2CircleProgressBar1.Value = progress_value;
            }
            else
            {
                timer.Stop();
            }
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Hide();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Check if the user is an admin
                if (loginForm.IsAdmin("faty")) // Provide the username and password to check
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas un gérant pour accéder à cette section.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm ClientF = new ClientForm();
            this.Hide();
            ClientF.Show();
        }
        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            FournisseurForm fournisseurF = new FournisseurForm();
            this.Hide();
            fournisseurF.Show();
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            StockForm sF = new StockForm();
            this.Hide();
            sF.Show();
        }

        private void btnAchat_Click(object sender, EventArgs e)
        {
            EntrerForm ef = new EntrerForm();
            this.Hide();
            ef.Show();
        }

        private void btnVente_Click(object sender, EventArgs e)
        {
            VenteForm vf = new VenteForm();
            this.Hide();
            vf.Show();
        }
        bool sidebarExpand;
        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            MessageBox.Show("Deconnécter !");
            lf.Show();
        }
        private void CheckLowStock()
        {
            var lowStockProducts = GSe.Articles.Where(p => p.QuantiteStock <= 3).ToList();
            if (lowStockProducts.Any())
            {
                string message = "Les produits suivants sont en presque rupture de stock :\n";
                foreach (var product in lowStockProducts)
                {
                    message += $"- {product.Designation} (Quantité : {product.QuantiteStock})\n";
                }
                MessageBox.Show(message, "Alerte de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
        }

        private void btnCheckLowStock_Click(object sender, EventArgs e)
        {
            CheckLowStock();
        }
    }
}
