using System;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class ClientForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();
        AdminForm adF = new AdminForm();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            RefreshCombo();
        }
        private void RefreshCombo()
        {
            //var combo = GSe.TypeArticle.Select(u => u.Libelle).ToList();
            //comboType.DataSource = combo;
            var combo = GSe.TypeArticle.ToList();
            comboType.DataSource = combo;
            comboType.ValueMember = "TypeArticleId";
            comboType.DisplayMember = "Libelle";
            comboType.SelectedIndex = -1;
        }
        private void RefreshDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = from c in GSe.Clients
                      join ty in GSe.TypeArticle on c.TypeArticleId equals ty.TypeArticleId
                      select new
                      {
                          c.ClientId,
                          c.Entreprise,
                          c.TelephoneFax,
                          c.Ville,
                          c.Email,
                          TypeArticleLibelle = ty.Libelle
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
        private bool ValidateClient()
        {
            // Vérifier si tous les champs requis sont remplis
            if (!string.IsNullOrWhiteSpace(txtSte.Text) &&
                !string.IsNullOrWhiteSpace(txtVille.Text) &&
                !string.IsNullOrWhiteSpace(txtMail.Text) &&
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
                if (ValidateClient())
                {
                    var exclient = GSe.Clients.FirstOrDefault(u => u.Entreprise == txtSte.Text);
                    if (exclient == null)
                    {
                        GSe.Clients.Add(new Clients
                        {
                            Entreprise = txtSte.Text,
                            Email = txtMail.Text,
                            TelephoneFax = txtTel.Text,
                            Ville = txtVille.Text,
                            TypeArticleId = (int)comboType.SelectedValue
                        });
                        GSe.SaveChanges();
                        MessageBox.Show("Added successfuly!");
                    }
                    else MessageBox.Show("Le login existe déjà.Veuillez choisir une Entreprise unique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Fill all the fields!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Ste = txtSearch.Text;
            var Search = GSe.Clients.FirstOrDefault(u => u.Entreprise == Ste);
            if (Search != null)
            {
                txtSte.Text = Search.Entreprise;
                txtMail.Text = Search.Email;
                txtTel.Text = Search.TelephoneFax;
                txtVille.Text = Search.Ville;
                //comboType.SelectedItem = Search.TypeArticle.ToString();
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
            try
            {
                var clientToDelete = GSe.Clients.FirstOrDefault(u => u.Entreprise == txtSearch.Text);
                if (clientToDelete != null)
                {
                    GSe.Clients.Remove(clientToDelete);
                    GSe.SaveChanges();
                    MessageBox.Show("Le client a été supprimé avec succès.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une entreprise qui existe avant de supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var UpdateC = GSe.Clients.FirstOrDefault(u => u.Entreprise == txtSearch.Text);
                if (UpdateC != null)
                {
                    UpdateC.Entreprise = txtSte.Text;
                    UpdateC.Email = txtMail.Text;
                    UpdateC.TelephoneFax = txtTel.Text;
                    UpdateC.Ville = txtVille.Text;
                    UpdateC.TypeArticleId = (int)comboType.SelectedValue;
                    GSe.SaveChanges();
                    MessageBox.Show("Updated successfuly");
                }
                else
                    MessageBox.Show("Veuillez entrer un login existant avant de rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la mise à jour du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AccueilForm af = new AccueilForm();
            this.Hide();
            af.Show();
        }
    }
}

