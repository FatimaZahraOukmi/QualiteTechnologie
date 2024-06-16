using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class VenteForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();

        public class ArticleToAdd
        {
            public int VenteId { get; set; } // Il semble que VenteId soit également nécessaire ici
            public int ArticleId { get; set; }
            public string Reference { get; set; }
            public string Designation { get; set; }
            public decimal PrixUnitaire { get; set; }
            public int Quantite { get; set; }
            public decimal Montant_Produit { get; set; } // Assurez-vous que le type décimal correspond à votre base de données
            public int TypeArticleId { get; set; }
        }

        private List<ArticleToAdd> articlesToAdd = new List<ArticleToAdd>();
        private Vente nouvelleVente;
        public int VenteId { get; private set; }

        public VenteForm()
        {
            InitializeComponent();
            dataGridBL.CellClick += dataGridBL_CellClick;
        }

        // Méthode pour afficher les détails de l'article sélectionné dans les contrôles de la VenteForm
        public void DisplaySelectedArticle(ArticleToAdd selectedArticle)
        {
            comboRef.Text = selectedArticle.Reference;
            comboDes.Text = selectedArticle.Designation;
            comboArticle.SelectedValue = selectedArticle.TypeArticleId;
            lblPrixU.Text = selectedArticle.PrixUnitaire.ToString();
            numericQteD.Value = selectedArticle.Quantite;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifiez si le tabControl actif est tabControl2
            if (tabControl1.SelectedTab == EffVente)
            {
                // Assurez-vous qu'un nouvel achat a été créé
                if (nouvelleVente != null)
                {
                    // Mettez à jour lblBonC avec le numéro de BC (AchatId)
                    lblFacture.Text = nouvelleVente.VenteId.ToString() + "/2024";
                    lblPrixT.Text = nouvelleVente.Montant_Total.ToString() + " Dhs";
                }
            }
        }

        private void VenteForm_Load(object sender, EventArgs e)
        {
            NumFacture.Text = (GSe.Vente.OrderByDescending(v => v.VenteId).FirstOrDefault()?.VenteId + 1 ?? 0 + 1) + "/2024";

            numericQteD.Maximum = 30000;
            numericQteD.Minimum = 0;
            dateSortie.Value = DateTime.Now;

            RefreshDes();
            RefreshRef();
            RefreshType();
            RefreshUser();
            RefreshClt();
            RefreshGridBL();
            RefreshGridList();
            RefreshGridVente();
        }

        private void RefreshGridBL()
        {
            dataGridBL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = from v in GSe.Vente
                      join t in GSe.Utilisateurs on v.UtilisateurId equals t.UtilisateurId
                      join c in GSe.Clients on v.ClientID equals c.ClientId
                      select new
                      {
                          Numero_BC = v.VenteId,
                          v.Date_Vente,
                          Client = c.Entreprise,
                          v.Montant_Total
                      };
            dataGridBL.DataSource = req.ToList();
        }

        private void RefreshGridList()
        {
            dataListV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var reqlist = from dv in GSe.DetailVente
                          join v in GSe.Vente on dv.VenteId equals v.VenteId
                          select new
                          {
                              NumFacture = dv.VenteId,
                              v.Date_Vente,
                              dv.Designation,
                              dv.Reference,
                              Libelle = dv.TypeArticle.Libelle,
                              dv.PrixUnitaire,
                              dv.Quantite,
                              dv.Montant_Produit,
                              v.Montant_Total,
                              v.Clients.Entreprise,
                              v.Utilisateurs.Role
                          };
            dataListV.DataSource = reqlist.ToList();
        }

        decimal marge = 0; // Initialisation de la marge à 0
        private void RefreshGridVente()
        {
            dataGridVente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var articles = GSe.Articles.ToList(); // Récupérer les données dans une liste

            var reqVente = articles.Select(da => new
            {
                da.Designation,
                da.TypeArticle.Libelle,
                // Calcul du prix unitaire avec la marge de bénéfice
                PrixUnitaireAvecMarge = da.PrixUnitaire * (1 + GetMargeByType(da.TypeArticle.Libelle)),
                da.QuantiteStock,
                da.Reference,
                // da.PrixUnitaire
            }).ToList(); // Exécuter la requête localement

            dataGridVente.DataSource = reqVente;
        }

        // Méthode pour obtenir la marge en fonction du type d'article
        private decimal GetMargeByType(string typeArticle)
        {
            switch (typeArticle)
            {
                case "Tablettes":
                    return 0.10m; // Marge de 10%
                case "Accessoires":
                    return 0.15m; // Marge de 15%
                case "PC":
                    return 0.20m; // Marge de 20%
                case "SmartPhone":
                    return 0.25m; // Marge de 25%
                default:
                    return 0.30m; // Par défaut, la marge est de 30
            }
        }

        private void RefreshUser()
        {
            var comboU = GSe.Utilisateurs.ToList();
            comboUser.DataSource = comboU;
            comboUser.ValueMember = "UtilisateurId";
            comboUser.DisplayMember = "Role";
            comboUser.SelectedIndex = -1;
        }

        private void RefreshClt()
        {
            var comboF = GSe.Clients.ToList();
            comboClt.DataSource = comboF;
            comboClt.ValueMember = "CLientId";
            comboClt.DisplayMember = "Entreprise";
            comboClt.SelectedIndex = -1;
        }

        private void RefreshType()
        {
            var combo = GSe.TypeArticle.ToList();
            comboArticle.DataSource = combo;
            comboArticle.ValueMember = "TypeArticleId";
            comboArticle.DisplayMember = "Libelle";
            comboArticle.SelectedIndex = -1;
        }

        private void RefreshRef()
        {
            var comboA = GSe.Articles.ToList();
            comboRef.DataSource = comboA;
            comboRef.ValueMember = "ArticleId";
            comboRef.DisplayMember = "Reference";
            comboRef.SelectedIndex = -1;
        }

        private void RefreshDes()
        {
            var comboA = GSe.Articles.ToList();
            comboDes.DataSource = comboA;
            comboDes.ValueMember = "ArticleId";
            comboDes.DisplayMember = "Designation";
            comboDes.SelectedIndex = -1;
        }
        private void btnAddOtherArt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(comboDes.Text) && !string.IsNullOrEmpty(comboRef.Text) &&
                    !string.IsNullOrEmpty(lblPrixU.Text) && !string.IsNullOrEmpty(lblPrixT.Text))
                {
                    if (decimal.TryParse(lblPrixU.Text, out decimal prixUnitaire))
                    {
                        int articleId = (int)comboRef.SelectedValue;

                        // Vérifiez si l'article existe dans la table Articles
                        var articleExists = GSe.Articles.Any(a => a.ArticleId == articleId);
                        if (!articleExists)
                        {
                            MessageBox.Show("L'article sélectionné n'existe pas dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Calcul de la marge selon le type d'article
                        if (comboArticle.SelectedItem != null)
                        {
                            string typeArticle = comboArticle.SelectedItem.ToString();
                            marge = GetMargeByType(typeArticle);
                            Console.WriteLine("Marge pour " + typeArticle + " : " + marge);
                        }

                        // Calcul du prix unitaire avec la marge de bénéfice
                        decimal prixUnitaireAvecMarge = prixUnitaire * (1 + marge);
                        decimal montantTotal = prixUnitaireAvecMarge * numericQteD.Value;


                        using (var transaction = GSe.Database.BeginTransaction())
                        {
                            try
                            {
                                ArticleToAdd articleToAdd = new ArticleToAdd
                                {
                                    ArticleId = articleId,
                                    Designation = comboDes.Text,
                                    Reference = comboRef.Text,
                                    PrixUnitaire = prixUnitaireAvecMarge, // Enregistrer le prix unitaire avec la marge
                                    Quantite = Convert.ToInt32(numericQteD.Value),
                                    Montant_Produit = montantTotal,
                                    TypeArticleId = comboArticle.SelectedIndex != -1 ? (int)comboArticle.SelectedValue : -1
                                };
                                var article = GSe.Articles.FirstOrDefault(a => a.ArticleId == articleId);
                                if (article != null && article.QuantiteStock < articleToAdd.Quantite)
                                {
                                    MessageBox.Show("La quantité demandée est supérieure à la quantité disponible en stock.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Empêche l'ajout de l'article à la vente
                                }

                                var newDetailVente = new DetailVente
                                {
                                    VenteId = nouvelleVente.VenteId,
                                    ArticleId = articleToAdd.ArticleId,
                                    Reference = articleToAdd.Reference,
                                    TypeArticleId = articleToAdd.TypeArticleId,
                                    Designation = articleToAdd.Designation,
                                    PrixUnitaire = prixUnitaireAvecMarge,
                                    Quantite = articleToAdd.Quantite,
                                    Montant_Produit = articleToAdd.Montant_Produit
                                };

                                // Enregistrer le détail de la vente dans la base de données
                                articlesToAdd.Add(articleToAdd);
                                GSe.DetailVente.Add(newDetailVente);
                                // Mettre à jour la quantité vendue dans le stock de l'article
                                article.QuantiteStock -= articleToAdd.Quantite;
                                GSe.SaveChanges();
                                transaction.Commit();

                                comboDes.SelectedIndex = -1;
                                comboRef.SelectedIndex = -1;
                                comboArticle.SelectedIndex = -1;
                                lblPrixU.Text = "";
                                numericQteD.Value = 0;

                                MessageBox.Show("L'article a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                ShowDetailedException(ex);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Les prix doivent être des valeurs numériques valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs nécessaires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowDetailedException(ex);
            }
        }
        private void ShowDetailedException(Exception ex)
        {
            var errorMessage = new System.Text.StringBuilder();
            errorMessage.AppendLine("Une erreur est survenue : " + ex.Message);

            Exception innerException = ex.InnerException;
            while (innerException != null)
            {
                errorMessage.AppendLine("Exception interne : " + innerException.Message);
                innerException = innerException.InnerException;
            }

            MessageBox.Show(errorMessage.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            try
            {
                // Assurez-vous que l'utilisateur et le client sont sélectionnés
                if (comboUser.SelectedItem != null && comboClt.SelectedItem != null)
                {
                    // Créez une nouvelle vente
                    nouvelleVente = new Vente
                    {
                        Date_Vente = dateSortie.Value,
                        UtilisateurId = (int)comboUser.SelectedValue,
                        ClientID = (int)comboClt.SelectedValue,
                    };
                    // Ajoutez la nouvelle vente à la base de données
                    GSe.Vente.Add(nouvelleVente);
                    // Enregistrez les modifications dans la base de données
                    GSe.SaveChanges();
                    // Récupérez l'ID de la vente enregistrée
                    VenteId = nouvelleVente.VenteId;
                    // Passez à l'onglet 1 de votre formulaire
                    tabControl1.SelectedIndex = 1;
                    lblFacture.Text = nouvelleVente.VenteId.ToString() + "/2024";
                    // Rafraîchissez les données dans vos grilles de données
                    RefreshGridBL();
                    RefreshGridList();
                    RefreshGridVente();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un utilisateur et un client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifiez si des articles ont été ajoutés à la vente
                if (articlesToAdd.Any())
                {
                    // Enregistrez chaque vente avec ses détails dans la base de données
                    foreach (var vente in GSe.Vente)
                    {
                        decimal montantTotal = 0;
                        foreach (var detailVente in vente.DetailVente)
                        {
                            montantTotal += detailVente.Montant_Produit;
                        }
                        vente.Montant_Total = montantTotal;
                    }
                    // Enregistrez les modifications dans la base de données
                    GSe.SaveChanges();
                    // Affichez un message de succès
                    MessageBox.Show("Toutes les ventes ont été enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aucun article n'a été ajouté à la vente.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridVente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifiez si une ligne est réellement sélectionnée
            {
                DataGridViewRow row = dataGridVente.Rows[e.RowIndex];

                // Récupérez les valeurs des colonnes pour l'article sélectionné
                string designation = row.Cells["Designation"].Value.ToString();
                string reference = row.Cells["Reference"].Value.ToString();
                decimal prixUnitaireAvecMarge = Convert.ToDecimal(row.Cells["PrixUnitaireAvecMarge"].Value);
                int quantiteStock = Convert.ToInt32(row.Cells["QuantiteStock"].Value);
                string type = row.Cells["Libelle"].Value.ToString();

                // Affichez les détails de l'article dans les contrôles correspondants
                comboDes.Text = designation;
                comboRef.Text = reference;
                comboArticle.Text = type;
                lblPrixU.Text = prixUnitaireAvecMarge.ToString(); // Afficher le prix avec marge
                lblPrixT.Text = (prixUnitaireAvecMarge * numericQteD.Value).ToString() + " Dhs"; // Calculer et afficher le montant total
                lblQteS.Text = quantiteStock.ToString();
            }
        }
        private void numericQteD_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblPrixU.Text, out decimal prixUnitaire))
            {
                decimal montantTotal = prixUnitaire * (1 + marge) * numericQteD.Value;
                lblPrixT.Text = montantTotal.ToString() + " Dhs";
            }
        }
        private Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printSettings(dataListV);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.dataListV.Width / 2), this.dataListV.Location.Y);
        }
        private Bitmap memoryimg;
        private void getprintarea(DataGridView pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void printSettings(DataGridView pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            dataListV = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void EffVente_Click(object sender, EventArgs e)
        {

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGridBL();
        }

        private void btnActualise_Click(object sender, EventArgs e)
        {
            RefreshGridList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifiez s'il y a une ligne sélectionnée dans dataGridBL
                if (dataGridBL.SelectedRows.Count > 0)
                {
                    // Obtenez l'ID de la vente sélectionnée
                    int venteId = Convert.ToInt32(dataGridBL.SelectedRows[0].Cells["Numero_BC"].Value);

                    // Obtenez l'objet vente correspondant à l'ID sélectionné
                    var venteToDelete = GSe.Vente.FirstOrDefault(v => v.VenteId == venteId);

                    // Vérifiez si la vente existe
                    if (venteToDelete != null)
                    {
                        // Supprimez d'abord les détails de vente associés à cette vente
                        var detailsToDelete = GSe.DetailVente.Where(d => d.VenteId == venteId);
                        GSe.DetailVente.RemoveRange(detailsToDelete);
                        // Supprimez ensuite la vente elle-même de la base de données
                        GSe.Vente.Remove(venteToDelete);
                        // Enregistrez les modifications dans la base de données
                        GSe.SaveChanges();

                        // Rafraîchissez les grilles de données
                        RefreshGridBL();
                        RefreshGridList();

                        MessageBox.Show("La vente a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La vente sélectionnée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une vente à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplaySelectedSaleInfo()
        {
            if (dataGridBL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridBL.SelectedRows[0];

                // Récupérez les informations de la vente sélectionnée à partir de la ligne sélectionnée dans dataGridBL
                int venteId = Convert.ToInt32(selectedRow.Cells["Numero_BC"].Value);
                DateTime dateVente = Convert.ToDateTime(selectedRow.Cells["Date_Vente"].Value);
                string entrepriseClient = selectedRow.Cells["Client"].Value.ToString();
                decimal montantTotal = Convert.ToDecimal(selectedRow.Cells["Montant_Total"].Value);
                tabControl1.SelectedTab = EffVente;
                // Affichez les informations dans les contrôles correspondants
                NumFacture.Text = venteId.ToString() + "/2024";
                lblFacture.Text = venteId.ToString() + "/2024";
                dateSortie.Value = dateVente;
                comboClt.Text = entrepriseClient;
                lblPrixT.Text = montantTotal.ToString() + " Dhs";
            }
            else
            {
                // Effacez les valeurs des contrôles si aucune ligne n'est sélectionnée
                NumFacture.Text = "";
                dateSortie.Value = DateTime.Now;
                comboClt.SelectedIndex = -1;
                lblPrixT.Text = "";
            }
        }

        private void dataGridBL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySelectedSaleInfo();
        }
    }
}

