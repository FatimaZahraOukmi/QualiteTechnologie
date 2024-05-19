using System;
using System.Linq;
using System.Windows.Forms;

namespace QualiTech
{
    public partial class LoginForm : Form
    {
        GStockQualiTechEntities GSe = new GStockQualiTechEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;
            var Log = GSe.Utilisateurs.FirstOrDefault(u => u.Login == username && u.Password == password);
            if (Log != null)
            {
                AccueilForm AF = new AccueilForm();
                AF.Show();
                this.Hide();
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Username or Password not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public bool IsAdmin(string username)
        {
            // Vérifiez si l'utilisateur est un administrateur
            return (username == "faty");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Cacher le mot de passe :
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
