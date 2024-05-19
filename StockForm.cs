using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class StockForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();
        List<Articles> articlesList = new List<Articles>();
        public System.Windows.Forms.TabControl tabControl1;
        int currentIndex = 0;

        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // Remplissez votre liste ou tableau avec les données à afficher
            articlesList = GSe.Articles.ToList();

            numericPU.Maximum = 30000;
            numericPrix.Maximum = 30000;
            numericQteS.Maximum = 30000;
            numericQte.Maximum = 30000;

            numericPU.Minimum = 0;
            numericPrix.Minimum = 0;
            numericQteS.Minimum = 0;
            numericQte.Minimum = 0;

            dateTimePicker1.Value = DateTime.Now;
            dateMod.Value = DateTime.Now;

            articlesList = GSe.Articles.ToList();


            RefreshGridS();
            RefreshType();
            RefreshFrs();
            RefreshFrsMod();
            RefreshTypeMod();
            RefreshGridAdd();
        }
        private void RefreshTypeMod()
        {
            var comboM = GSe.TypeArticle.ToList();
            comboTypemod.DataSource = comboM;
            comboTypemod.ValueMember = "TypeArticleId";
            comboTypemod.DisplayMember = "Libelle";
            comboTypemod.SelectedIndex = -1;
        }
        private void RefreshType()
        {
            var combo = GSe.TypeArticle.ToList();
            comboType.DataSource = combo;
            comboType.ValueMember = "TypeArticleId";
            comboType.DisplayMember = "Libelle";
            comboType.SelectedIndex = -1;
        }
        private void RefreshFrs()
        {
            var comboF = GSe.Fournisseurs.ToList();
            comboFrs.DataSource = comboF;
            comboFrs.ValueMember = "FournisseurId";
            comboFrs.DisplayMember = "Entreprise";
            comboFrs.SelectedIndex = -1;
        }

        private void RefreshFrsMod()
        {
            var comboFM = GSe.Fournisseurs.ToList();
            comboFrsMod.DataSource = comboFM;
            comboFrsMod.ValueMember = "FournisseurId";
            comboFrsMod.DisplayMember = "Entreprise";
            comboFrsMod.SelectedIndex = -1;
        }
        private void RefreshGridAdd()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = from a in GSe.Articles
                      join t in GSe.TypeArticle on a.TypeArticleId equals t.TypeArticleId
                      join f in GSe.Fournisseurs on a.FournisseurId equals f.FournisseurId
                      select new
                      {
                          a.ArticleId,
                          TypeArticleLibelle = t.Libelle,
                          a.Reference,
                          a.Designation,
                          a.QuantiteStock,
                          a.PrixUnitaire,
                          a.DateReception,
                          Fournisseurs = f.Entreprise
                      };
            dataGridView1.DataSource = req.ToList();
        }
        private void RefreshGridS()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = from a in GSe.Articles
                      join t in GSe.TypeArticle on a.TypeArticleId equals t.TypeArticleId
                      join f in GSe.Fournisseurs on a.FournisseurId equals f.FournisseurId
                      select new
                      {
                          a.ArticleId,
                          a.TypeArticleId,
                          TypeArticle = t.Libelle,
                          a.Reference,
                          a.Designation,
                          a.QuantiteStock,
                          a.PrixUnitaire,
                          a.DateReception,
                          Fournisseurs = f.Entreprise
                      };
            dataGridView2.DataSource = req.ToList();
        }
        private bool ValidateArticle()
        {
            if (numericQte.Value > 0 && numericPU.Value > 0 &&
                !string.IsNullOrWhiteSpace(txtDesignation.Text) &&
                !string.IsNullOrWhiteSpace(txtRef.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            RefreshGridS();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabControl1.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateArticle())
                {
                    var exArticle = GSe.Articles.FirstOrDefault(u => u.Reference == txtRef.Text);
                    if (exArticle == null)
                    {
                        Articles newArticle = new Articles
                        {
                            Designation = txtDesignation.Text,
                            Reference = txtRef.Text,
                            PrixUnitaire = (decimal)numericPU.Value,
                            QuantiteStock = (int)numericQte.Value,
                            DateReception = dateTimePicker1.Value,
                            TypeArticleId = (int)comboType.SelectedValue,
                            FournisseurId = (int)comboFrs.SelectedValue
                        };
                        GSe.Articles.Add(newArticle);
                        GSe.SaveChanges();
                        MessageBox.Show("L'article a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("L'article existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout de l'article : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Articles article = null;
                if (radioRef.Checked)
                {
                    article = GSe.Articles.FirstOrDefault(a => a.Reference == txtSearch.Text);
                }
                else if (radioDesign.Checked)
                {
                    article = GSe.Articles.FirstOrDefault(a => a.Designation == txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un critère de recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (article != null)
                {
                    // Mettre à jour les propriétés de l'article avec les valeurs des contrôles
                    article.Designation = txtDesig.Text;
                    article.FournisseurId = (int)comboFrsMod.SelectedValue;
                    article.TypeArticleId = (int)comboTypemod.SelectedValue;
                    article.Reference = txtRefMod.Text;
                    article.PrixUnitaire = numericPrix.Value;
                    article.QuantiteStock = (int)numericQteS.Value;
                    article.DateReception = dateMod.Value;
                    // Enregistrer les modifications dans la base de données
                    GSe.SaveChanges();
                    ClearArticleDetails();
                    MessageBox.Show("L'article a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Afficher un message si l'article n'est pas trouvé
                    MessageBox.Show("Article non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la modification de l'article : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Articles article = null;
                if (radioRef.Checked)
                {
                    article = GSe.Articles.FirstOrDefault(a => a.Reference == txtSearch.Text);
                }
                else if (radioDesign.Checked)
                {
                    article = GSe.Articles.FirstOrDefault(a => a.Designation == txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un critère de recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (article != null)
                {
                    GSe.Articles.Remove(article);
                    GSe.SaveChanges();
                    ClearArticleDetails();
                    MessageBox.Show("L'article a été Supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Afficher un message si l'article n'est pas trouvé
                    MessageBox.Show("Article non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la modification de l'article : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                // Effectuer la recherche en fonction du critère sélectionné par l'utilisateur
                Articles article = null;
                if (radioRef.Checked)
                {
                    article = GSe.Articles.FirstOrDefault(a => a.Reference == txtSearch.Text);
                }
                else if (radioDesign.Checked)
                {
                    article = GSe.Articles.FirstOrDefault(a => a.Designation == txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un critère de recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Afficher les résultats dans les contrôles correspondants
                if (article != null)
                {
                    DisplayArticleDetails(article);
                }
                else
                {
                    MessageBox.Show("Aucun article correspondant trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la recherche : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayArticleDetails(Articles article)
        {
            txtDesig.Text = article.Designation;
            comboFrsMod.SelectedValue = article.FournisseurId;
            comboTypemod.SelectedValue = article.TypeArticleId;
            txtRefMod.Text = article.Reference;
            numericPrix.Value = article.PrixUnitaire ?? 0;
            numericQteS.Value = article.QuantiteStock ?? 0;
            dateMod.Value = article.DateReception ?? DateTime.Now;
        }
        private void ClearArticleDetails()
        {
            txtDesignation.Text = "";
            txtRef.Text = "";
            numericPrix.Value = 0;
            numericQteS.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnActualiser_Click_1(object sender, EventArgs e)
        {
            RefreshGridS();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            DisplayArticleDetails(articlesList[currentIndex]);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayArticleDetails(articlesList[currentIndex]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < articlesList.Count - 1)
            {
                currentIndex++;
                DisplayArticleDetails(articlesList[currentIndex]);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = articlesList.Count - 1;
            DisplayArticleDetails(articlesList[currentIndex]);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGridAdd();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }
    }
}
