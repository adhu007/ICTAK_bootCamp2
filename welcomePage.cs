namespace bootCamp2
{
    public partial class welcomePage : Form
    {
        public welcomePage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userLogin = new userLoginPage();
            userLogin.Closed += (s, args) => this.Close();
            userLogin.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userReg = new userRegistration();
            userReg.Closed += (s, args) => this.Close();
            userReg.Show();
        }

       
    }
}
