using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class EntrerForm : Form
    {
        private readonly GStockQualiTechEntities GSe = new GStockQualiTechEntities();

        public class ArticleToAdd
        {
            public int ArticleId { get; set; }
            public string Reference { get; set; }
            public string Designation { get; set; }
            public decimal PrixUnitaire { get; set; }
            public int Quantite { get; set; }
            public int TypeArticleId { get; set; }
            public DateTime DateReception { get; internal set; }
        }

        private List<ArticleToAdd> articlesToAdd = new List<ArticleToAdd>();
        private Achat nouvelAchat;

        public EntrerForm()
        {
            InitializeComponent();
        }

        private void EntrerForm_Load(object sender, EventArgs e)
        {
            numericPrix.Maximum = 30000;
            numericQteD.Maximum = 30000;

            numericPrix.Minimum = 0;
            numericQteD.Minimum = 0;

            dateSortie.Value = DateTime.Now;

            RefreshType();
            RefreshFrs();
            RefreshUser();
            RefreshGridAdd();
            RefreshGridBC();
            RefreshGridS();
        }

        private void RefreshGridBC()
        {
            dataBC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = from a in GSe.Achat
                      join t in GSe.Utilisateurs on a.UtilisateurId equals t.UtilisateurId
                      join f in GSe.Fournisseurs on a.FournisseurId equals f.FournisseurId
                      select new
                      {
                          Numero_BC = a.AchatId,
                          a.Date_Achat,
                          Fournisseur = f.Entreprise,
                          a.Montant_Total
                      };
            dataBC.DataSource = req.ToList();
        }

        private void RefreshGridS()
        {
            dataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var reqlist = from da in GSe.DetailAchat
                          join ac in GSe.Achat on da.AchatId equals ac.AchatId
                          select new
                          {
                              NumBC = da.AchatId,
                              ac.Date_Achat,
                              da.Designation,
                              da.Reference,
                              Libelle = da.TypeArticle.Libelle,
                              da.PrixUnitaire,
                              da.Quantite,
                              da.Montant_Produit,
                              ac.Montant_Total,
                              ac.Fournisseurs.Entreprise,
                              ac.Utilisateurs.Role
                          };
            dataList.DataSource = reqlist.ToList();
        }

        private void RefreshGridAdd()
        {
            dataDAchat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var reqAchat = from da in GSe.DetailAchat
                           select new
                           {
                               Num_BC = da.AchatId,
                               Libelle = da.TypeArticle.Libelle,
                               da.Designation,
                               da.Reference,
                               da.Quantite,
                               da.PrixUnitaire,
                               MontantTotal = da.Montant_Produit,
                           };
            dataDAchat.DataSource = reqAchat.ToList();
        }

        private void RefreshUser()
        {
            var comboU = GSe.Utilisateurs.ToList();
            comboUser.DataSource = comboU;
            comboUser.ValueMember = "UtilisateurId";
            comboUser.DisplayMember = "Role";
            comboUser.SelectedIndex = -1;
        }

        private void RefreshType()
        {
            var combo = GSe.TypeArticle.ToList();
            comboArticle.ValueMember = "TypeArticleId";
            comboArticle.DisplayMember = "Libelle";
            comboArticle.DataSource = combo;
            comboArticle.SelectedIndex = -1;
        }

        private void RefreshFrs()
        {
            var comboF = GSe.Fournisseurs.ToList();
            comboFrs.DataSource = comboF;
            comboFrs.ValueMember = "FournisseurId";
            comboFrs.DisplayMember = "Entreprise";
            comboFrs.SelectedIndex = -1;
        }

        private void AddArticleToList()
        {
            try
            {
                if (string.IsNullOrEmpty(txtRef.Text) || string.IsNullOrEmpty(txtDes.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (numericPrix.Value <= 0 || numericQteD.Value <= 0)
                {
                    MessageBox.Show("Les valeurs des champs numériques doivent être supérieures à zéro.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var montantProduit = Convert.ToDecimal(numericQteD.Value) * Convert.ToDecimal(numericPrix.Value);

                var newArticle = new ArticleToAdd
                {
                    Reference = txtRef.Text,
                    Designation = txtDes.Text,
                    PrixUnitaire = Convert.ToDecimal(numericPrix.Text),
                    Quantite = Convert.ToInt32(numericQteD.Text),
                    TypeArticleId = (int)comboArticle.SelectedValue,
                };

                if (articlesToAdd.Any(a => a.Reference == newArticle.Reference))
                {
                    MessageBox.Show("Cet article a déjà été ajouté à la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                articlesToAdd.Add(newArticle);
                RefreshGridAdd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddArticleToList();

                var montantProduit = Convert.ToDecimal(numericQteD.Value) * Convert.ToDecimal(numericPrix.Value);

                var existingArticle = GSe.Articles.FirstOrDefault(a => a.Reference == txtRef.Text);

                if (existingArticle == null)
                {
                    var newArticle = new Articles
                    {
                        Designation = txtDes.Text,
                        TypeArticleId = comboArticle.SelectedIndex != -1 ? (int)comboArticle.SelectedValue : -1, // ou une valeur par défaut appropriée
                        PrixUnitaire = Convert.ToDecimal(numericPrix.Text),
                        QuantiteStock = Convert.ToInt32(numericQteD.Text),
                        FournisseurId = (int)comboFrs.SelectedValue,
                        Reference = txtRef.Text,
                        DateReception = DateTime.Now
                    };

                    GSe.Articles.Add(newArticle);
                    GSe.SaveChanges();

                    var newDetailAchat = new DetailAchat
                    {
                        AchatId = nouvelAchat.AchatId,
                        ArticleId = newArticle.ArticleId,
                        TypeArticleId = comboArticle.SelectedIndex != -1 ? (int)comboArticle.SelectedValue : -1, // ou une valeur par défaut appropriée
                        Reference = txtRef.Text,
                        Designation = txtDes.Text,
                        PrixUnitaire = Convert.ToDecimal(numericPrix.Text),
                        Quantite = Convert.ToInt32(numericQteD.Text),
                        Montant_Produit = montantProduit
                    };

                    GSe.DetailAchat.Add(newDetailAchat);
                    GSe.SaveChanges();
                }
                else
                {
                    existingArticle.QuantiteStock += Convert.ToInt32(numericQteD.Value);

                    var newDetailAchat = new DetailAchat
                    {
                        AchatId = nouvelAchat.AchatId,
                        ArticleId = existingArticle.ArticleId,
                        Reference = txtRef.Text,
                        Designation = txtDes.Text,
                        PrixUnitaire = Convert.ToDecimal(numericPrix.Text),
                        Quantite = Convert.ToInt32(numericQteD.Text),
                        Montant_Produit = (decimal)existingArticle.PrixUnitaire * Convert.ToInt32(numericQteD.Value),
                        TypeArticleId = comboArticle.SelectedIndex != -1 ? (int)comboArticle.SelectedValue : -1 // ou une valeur par défaut appropriée
                    };

                    GSe.DetailAchat.Add(newDetailAchat);
                    GSe.SaveChanges();
                }
                RefreshGridAdd();
                RefreshGridBC();
                RefreshGridS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            try
            {
                nouvelAchat = new Achat
                {
                    UtilisateurId = (int)comboUser.SelectedValue,
                    FournisseurId = (int)comboFrs.SelectedValue,
                    Date_Achat = dateSortie.Value,
                };

                GSe.Achat.Add(nouvelAchat);
                GSe.SaveChanges();

                decimal montantTotal = 0;
                foreach (var detailAchat in nouvelAchat.DetailAchat)
                {
                    montantTotal += detailAchat.Montant_Produit;
                }
                nouvelAchat.Montant_Total = montantTotal;

                foreach (var articleToAdd in articlesToAdd)
                {
                    var newDetailAchat = new DetailAchat
                    {
                        AchatId = nouvelAchat.AchatId,
                        ArticleId = articleToAdd.ArticleId,
                        Reference = articleToAdd.Reference,
                        Designation = articleToAdd.Designation,
                        PrixUnitaire = articleToAdd.PrixUnitaire,
                        Quantite = articleToAdd.Quantite,
                        Montant_Produit = articleToAdd.PrixUnitaire * articleToAdd.Quantite,
                        TypeArticleId = comboArticle.SelectedIndex != -1 ? (int)comboArticle.SelectedValue : -1 // ou une valeur par défaut appropriée
                    };
                    GSe.DetailAchat.Add(newDetailAchat);
                }

                foreach (var newArticle in articlesToAdd)
                {
                    newArticle.DateReception = DateTime.Now;
                }

                GSe.SaveChanges();

                RefreshGridAdd();
                RefreshGridBC();
                RefreshGridS();

                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclse_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Mettre à jour le montant total dans la table Achat
                decimal montantTotalAchat = articlesToAdd.Sum(article => article.PrixUnitaire * article.Quantite);
                // Assurez-vous qu'il y a une nouvelle commande d'achat en cours
                if (nouvelAchat != null)
                {
                    nouvelAchat.Montant_Total = montantTotalAchat;
                    lblPrixT.Text = nouvelAchat.Montant_Total.ToString() + " Dhs";
                    // Enregistrez les changements dans la base de données
                    GSe.SaveChanges();
                    // Rafraîchissez la grille des commandes d'achat pour refléter les changements
                    RefreshGridBC();
                    RefreshGridS();
                }
                else
                {
                    MessageBox.Show("Une nouvelle commande d'achat doit être créée avant d'ajouter des articles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            RefreshGridS();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifiez si le tabControl actif est tabControl2
            if (tabControl1.SelectedTab == EffAchat)
            {
                // Assurez-vous qu'un nouvel achat a été créé
                if (nouvelAchat != null)
                {
                    // Mettez à jour lblBonC avec le numéro de BC (AchatId)
                    lblBonC.Text = nouvelAchat.AchatId.ToString() + "/2024";
                    lblPrixT.Text = nouvelAchat.Montant_Total.ToString() + " Dhs";
                }
            }
        }

        private void dataBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Vérifiez si l'index de la cellule cliquée est valide et qu'il ne s'agit pas de l'en-tête de colonne
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Récupérez l'AchatId à partir de la cellule cliquée dans la colonne "Numero_BC"
                    int achatId = Convert.ToInt32(dataBC.Rows[e.RowIndex].Cells["Numero_BC"].Value);

                    // Récupérez l'achat correspondant à partir de l'AchatId
                    var achat = GSe.Achat.FirstOrDefault(a => a.AchatId == achatId);

                    if (achat != null)
                    {
                        NumBC.Text = achat.AchatId.ToString() + "/2024";
                        // Mettez à jour les contrôles avec les données de l'achat sélectionné
                        comboUser.SelectedValue = achat.UtilisateurId;
                        comboFrs.SelectedValue = achat.FournisseurId;
                        dateSortie.Value = achat.Date_Achat;
                        // Mise à jour des labels NumBC et lblBonC avec l'AchatId
                        lblBonC.Text = achat.AchatId.ToString() + "/2024";
                        // Mise à jour d'autres contrôles si nécessaire
                        // Rafraîchir les détails d'achat associés à cet achat dans le DataGridView dataList
                        RefreshGridS();

                        // Sélectionner les détails d'achat associés à cet achat dans la table DetailAchat
                        var detailsAchat = GSe.DetailAchat.Where(d => d.AchatId == achat.AchatId).ToList();
                        if (detailsAchat.Count > 0)
                        {
                            // Remplir les contrôles avec les informations des détails d'achat
                            var detailAchat = detailsAchat.First(); // Supposons que nous prenons le premier détail d'achat pour mettre à jour les contrôles
                            txtRef.Text = detailAchat.Reference;
                            txtDes.Text = detailAchat.Designation;
                            numericPrix.Value = (decimal)detailAchat.PrixUnitaire;
                            numericQteD.Value = (decimal)detailAchat.Quantite;
                            if (detailAchat.TypeArticleId != null)
                            {
                                comboArticle.SelectedValue = detailAchat.TypeArticleId;
                            }
                            else
                            {
                                // Si le TypeArticleId est null ou vide, vous pouvez choisir une valeur par défaut ou ne rien sélectionner du tout
                                comboArticle.SelectedIndex = -1; // Ne sélectionne aucune valeur dans le ComboBox
                                                                 // Ou, vous pouvez sélectionner une valeur par défaut si cela est approprié pour votre application
                                                                 // comboArticle.SelectedIndex = 0; // Sélectionne la première valeur dans la liste (si elle existe)
                            }
                        }
                        else
                        {
                            // Effacer les contrôles si aucun détail d'achat n'est trouvé
                            txtRef.Text = "";
                            txtDes.Text = "";
                            numericPrix.Value = 0;
                            numericQteD.Value = 0;
                            comboArticle.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'achat correspondant n'a pas été trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du traitement de la sélection : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataBC.Rows.Count > 0 && dataBC.SelectedRows.Count > 0) // Vérifier si une ligne est sélectionnée
                {
                    int selectedRowIndex = dataBC.SelectedRows[0].Index;
                    int achatId = Convert.ToInt32(dataBC.Rows[selectedRowIndex].Cells["Numero_BC"].Value);

                    // Récupérer l'achat correspondant à partir de l'AchatId
                    var achatToUpdate = GSe.Achat.FirstOrDefault(a => a.AchatId == achatId);

                    if (achatToUpdate != null)
                    {
                        // Mettre à jour les propriétés de l'achat en fonction des valeurs des contrôles
                        achatToUpdate.UtilisateurId = (int)comboUser.SelectedValue;
                        achatToUpdate.FournisseurId = (int)comboFrs.SelectedValue;
                        achatToUpdate.Date_Achat = dateSortie.Value;

                        // Récupérer les détails d'achat associés à cet achat
                        var detAchat = GSe.DetailAchat.FirstOrDefault(d => d.AchatId == achatToUpdate.AchatId);

                        if (detAchat != null)
                        {
                            detAchat.Reference = txtRef.Text;
                            detAchat.Designation = txtDes.Text;
                            detAchat.PrixUnitaire = numericPrix.Value;
                            detAchat.Quantite = (int)numericQteD.Value;
                            detAchat.TypeArticleId = (int)comboArticle.SelectedValue;

                            // Enregistrer les modifications dans la base de données
                            GSe.SaveChanges();

                            // Rafraîchir le DataGridView pour refléter les changements
                            RefreshGridBC();
                            RefreshGridS();

                            // Afficher un message de succès
                            MessageBox.Show("L'achat et ses détails ont été mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Les détails d'achat associés n'ont pas été trouvés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'achat correspondant n'a pas été trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un achat à mettre à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la mise à jour de l'achat : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnValide_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée dans dataBC
                if (dataBC.SelectedRows.Count > 0)
                {
                    // Récupérer l'identifiant de l'achat sélectionné dans dataBC
                    int achatId = Convert.ToInt32(dataBC.SelectedRows[0].Cells["Numero_BC"].Value);

                    // Filtrer les détails d'achat correspondants à cet achat
                    var detailsAchat = GSe.DetailAchat.Where(d => d.AchatId == achatId).ToList();

                    // Afficher les détails d'achat dans la DataGridView dataDAchat de l'onglet numéro 2
                    // Assurez-vous que l'onglet numéro 2 est sélectionné
                    tabControl1.SelectedIndex = 1;
                    dataDAchat.DataSource = detailsAchat;
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un achat dans la grille avant de valider.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la validation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataDAchat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Récupérez les informations de l'article sélectionné dans la DataGridView dataDAchat
                    DataGridViewRow selectedRow = dataDAchat.Rows[e.RowIndex];

                    // Récupérez les valeurs des cellules pour l'article sélectionné en vérifiant si les cellules existent et ne sont pas nulles
                    string reference = selectedRow.Cells["Reference"]?.Value?.ToString() ?? string.Empty;
                    string designation = selectedRow.Cells["Designation"]?.Value?.ToString() ?? string.Empty;
                    decimal prixUnitaire = selectedRow.Cells["PrixUnitaire"]?.Value != null ? Convert.ToDecimal(selectedRow.Cells["PrixUnitaire"].Value) : 0;
                    int quantite = selectedRow.Cells["Quantite"]?.Value != null ? Convert.ToInt32(selectedRow.Cells["Quantite"].Value) : 0;

                    // Assurez-vous que le nom de la colonne est correct
                    // Si vous avez une colonne avec un nom différent, utilisez ce nom ici
                    string libelle = selectedRow.Cells["Libelle"]?.Value?.ToString() ?? string.Empty;

                    // Utilisez les valeurs récupérées comme bon vous semble
                    // Par exemple, vous pouvez les afficher dans des contrôles sur votre formulaire
                    txtRef.Text = reference;
                    txtDes.Text = designation;
                    numericPrix.Value = prixUnitaire;
                    numericQteD.Value = quantite;

                    // Si `TypeArticleId` est une valeur associée à `Libelle`, vous devez la récupérer à partir de la base de données ou de votre source de données
                    var typeArticle = GSe.TypeArticle.FirstOrDefault(t => t.Libelle == libelle);
                    if (typeArticle != null)
                    {
                        comboArticle.SelectedValue = typeArticle.TypeArticleId;
                    }
                    else
                    {
                        comboArticle.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du traitement de la sélection : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }
    }
}
