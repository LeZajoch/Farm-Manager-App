using System;
using System.Windows.Forms;
using Farm_Manager.logic.database;

namespace Farm_Manager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /*
        public void SwitchForm(string formName)
        {
            Hide();
            var economyForm = new EconomyForm();
            economyForm.Closed += (s, args) => Close(); 
            economyForm.Show();
        }
        */
        private void UsernameBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Data_Check(string inputuUsername, string inputPassword)
        { 
            
            if (Dao.Login(inputuUsername) == true)
            {
                Hide();
                var mainMenForm = new MainMenuForm();
                mainMenForm.Closed += (s, args) => Close(); 
                mainMenForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
            //todo logika Data_Check neni upravena z panelu na formu
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = UsernameBOX.Text;
            string inputPassword = PasswordBOX.Text;
            Data_Check(inputUsername, inputPassword);
        }
    }
}