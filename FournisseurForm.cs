using System;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class FournisseurForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();
        public FournisseurForm()
        {
            InitializeComponent();
        }

        private void FournisseurForm_Load(object sender, EventArgs e)
        {
            RefreshComboF();
            RefreshDataF();
        }
        private void RefreshComboF()
        {
            var combo = GSe.TypeArticle.ToList();
            comboType.DataSource = combo;
            comboType.ValueMember = "TypeArticleId";
            comboType.DisplayMember = "Libelle";
            comboType.SelectedIndex = -1;
        }
        private void RefreshDataF()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = from f in GSe.Fournisseurs
                      join t in GSe.TypeArticle on f.TypeArticleId equals t.TypeArticleId
                      select new
                      {
                          f.FournisseurId,
                          f.Entreprise,
                          f.Telephone,
                          f.Ville,
                          f.Email,
                          TypeArticleLibelle = t.Libelle
                      };
            dataGridView1.DataSource = req.ToList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            //Vider les champs :
            foreach (Control control in tabControl1.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
        private bool ValidateFournisseur()
        {
            // Vérifier si tous les champs requis sont remplis
            if (!string.IsNullOrWhiteSpace(txtMail.Text) &&
                !string.IsNullOrWhiteSpace(txtSte.Text) &&
                !string.IsNullOrWhiteSpace(txtVille.Text) &&
                !string.IsNullOrWhiteSpace(txtTel.Text) &&
                !string.IsNullOrWhiteSpace(comboType.Text))
                return true;
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFournisseur())
                {
                    var exFournisseur = GSe.Fournisseurs.FirstOrDefault(u => u.Entreprise == txtSte.Text);
                    if (exFournisseur == null)
                    {
                        GSe.Fournisseurs.Add(new Fournisseurs
                        {
                            Email = txtMail.Text,
                            Entreprise = txtSte.Text,
                            Telephone = txtTel.Text,
                            Ville = txtVille.Text,
                            TypeArticleId = (int)comboType.SelectedValue
                        });
                        GSe.SaveChanges();
                    }
                    else MessageBox.Show("Le login existe déjà.Veuillez choisir une Entreprise unique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Fill all the fields!");
                MessageBox.Show("Added successfuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Ste = txtSearch.Text;
            var Search = GSe.Fournisseurs.FirstOrDefault(u => u.Entreprise == Ste);
            if (Search != null)
            {
                txtMail.Text = Search.Email;
                txtSte.Text = Search.Entreprise;
                txtTel.Text = Search.Telephone;
                txtVille.Text = Search.Ville;
                var item = comboType.Items.Cast<TypeArticle>()
                                   .FirstOrDefault(t => t.TypeArticleId == Search.TypeArticleId);
                if (item != null)
                {
                    comboType.SelectedItem = item;
                }
            }
            else
                MessageBox.Show("Veuillez entrer l'entreprise deja existe avant de rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDelette_Click(object sender, EventArgs e)
        {
            var fournisseursToDelete = GSe.Fournisseurs.FirstOrDefault(s => s.Entreprise == txtSearch.Text);
            if (fournisseursToDelete != null)
            {
                GSe.Fournisseurs.Remove(fournisseursToDelete);
                GSe.SaveChanges();
                MessageBox.Show("Le Fournisseur a été supprimé avec succès.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez entrer une entreprise qui existe avant de supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var UpdateF = GSe.Fournisseurs.FirstOrDefault(u => u.Entreprise == txtSearch.Text);
            if (UpdateF != null)
            {
                UpdateF.Email = txtMail.Text;
                UpdateF.Entreprise = txtSte.Text;
                UpdateF.Telephone = txtTel.Text;
                UpdateF.Ville = txtVille.Text;
                UpdateF.TypeArticleId = (int)comboType.SelectedValue;
                GSe.SaveChanges();
                MessageBox.Show("Updated successfuly");
            }
            else
                MessageBox.Show("Veuillez entrer un login existant avant de rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataF();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }
    }
}
