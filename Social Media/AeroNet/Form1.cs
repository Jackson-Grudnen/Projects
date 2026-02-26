namespace AeroNet
{
    public partial class frmLogin : Form
    {
        private databaseController myController_;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (txtEmail.Text == "" || txtPassword.Text.Length < 8)
            {
                lblError.Text = "Please enter a valid username and password";
                return;
            }
            else if (myController_.getLogin(email, password))
            {
                frmHome home = new frmHome();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password";
                return;
            }
        }
    }
}
