using System;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class AdminForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();
        Utilisateurs utilisateur = new Utilisateurs();
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Cacher le mot de passe :
            txtPassword.UseSystemPasswordChar = true;

            //Actualiser la liste des employés :
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var req = GSe.Utilisateurs.Select(u => new
            {
                u.UtilisateurId,
                u.Nom,
                u.Prenom,
                u.Role,
                u.Email,
                u.Telephone,
                u.Login,
                u.Password
            }).ToArray();

            dataGridView1.DataSource = req;
        }
        private bool ValidateAdmin()
        {
            // Vérifier si tous les champs requis sont remplis
            if (!string.IsNullOrWhiteSpace(txtNom.Text) &&
                !string.IsNullOrWhiteSpace(txtPrenom.Text) &&
                !string.IsNullOrWhiteSpace(txtRole.Text) &&
                !string.IsNullOrWhiteSpace(txtMail.Text) &&
                !string.IsNullOrWhiteSpace(txtTel.Text) &&
                !string.IsNullOrWhiteSpace(txtLogin.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // Vérifier si le champ d'email est au format valide
                if (!IsValidEmail(txtMail.Text))
                {
                    MessageBox.Show("L'adresse e-mail n'est pas valide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Vérifier si le numéro de téléphone commence par 0 et est un nombre
                if (!IsPhoneNumberValid(txtTel.Text))
                {
                    MessageBox.Show("Le numéro de téléphone n'est pas valide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Vérifier si le mot de passe est valide
                if (!IsPasswordValid(txtPassword.Text))
                {
                    MessageBox.Show("Le mot de passe n'est pas valide. Il doit contenir au moins une lettre majuscule, une lettre minuscule, un chiffre et un caractère spécial, et avoir au moins 6 caractères au total.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Toutes les validations ont réussi
                return true;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Méthode pour valider le numéro de téléphone
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Vérifier si le numéro de téléphone commence par 0 et est un nombre
            return phoneNumber.StartsWith("0") && phoneNumber.All(char.IsDigit);
        }
        // Méthode pour valider le format du mot de passe
        private bool IsPasswordValid(string password)
        {
            // Vérifier si le mot de passe contient au moins une lettre majuscule, une lettre minuscule, un chiffre et un caractère spécial, et a au moins 6 caractères au total
            return password.Any(char.IsUpper) &&          // Au moins une lettre majuscule
                   password.Any(char.IsLower) &&          // Au moins une lettre minuscule
                   password.Any(char.IsDigit) &&          // Au moins un chiffre
                   password.Any(ch => !char.IsLetterOrDigit(ch)) && // Au moins un caractère spécial
                   password.Length >= 6;                  // Au moins 6 caractères
        }
        private bool IsValidEmail(string email)
        {
            // Expression régulière pour valider le format de l'email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateAdmin())
            {
                var existingEmp = GSe.Utilisateurs.FirstOrDefault(u => u.Login == txtLogin.Text);
                if (existingEmp == null)
                {
                    utilisateur.Nom = txtNom.Text;
                    utilisateur.Prenom = txtPrenom.Text;
                    utilisateur.Role = txtRole.Text;
                    utilisateur.Email = txtMail.Text;
                    utilisateur.Telephone = txtTel.Text;
                    utilisateur.Password = txtPassword.Text;
                    utilisateur.Login = txtLogin.Text;
                    GSe.Utilisateurs.Add(utilisateur);
                    GSe.SaveChanges();
                }
                else MessageBox.Show("Le login existe déjà.Veuillez choisir un login unique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Fill all the fields!");
            MessageBox.Show("Added successfuly!");

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            //Vider les champs :
            foreach (Control control in tabPage1.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Update = GSe.Utilisateurs.FirstOrDefault(u => u.Login == txtSearch.Text);
            if (Update != null)
            {
                Update.Nom = txtNom.Text;
                Update.Prenom = txtPrenom.Text;
                Update.Role = txtRole.Text;
                Update.Email = txtMail.Text;
                Update.Telephone = txtTel.Text;
                Update.Password = txtPassword.Text;
                Update.Login = txtLogin.Text;
                GSe.SaveChanges();
            }
            MessageBox.Show("Veuillez entrer un login existant avant de rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDelette_Click(object sender, EventArgs e)
        {
            var Delete = GSe.Utilisateurs.FirstOrDefault(u => u.Login == txtSearch.Text);
            if (Delete != null)
            {
                GSe.Utilisateurs.Attach(Delete);
                GSe.Utilisateurs.Remove(Delete);
                GSe.SaveChanges();
                MessageBox.Show("L'utilisateur a été supprimé avec succès.", "Supprission", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Veuillez entrer un login deja existe avant de rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string log = txtSearch.Text;
            var Search = GSe.Utilisateurs.FirstOrDefault(u => u.Login == log);
            if (Search != null)
            {
                txtNom.Text = Search.Nom;
                txtPrenom.Text = Search.Prenom;
                txtRole.Text = Search.Role;
                txtMail.Text = Search.Email;
                txtTel.Text = Search.Telephone;
                txtPassword.Text = Search.Password;
                txtLogin.Text = Search.Login;
            }
            else
                MessageBox.Show("Veuillez entrer un login deja existe avant de rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
