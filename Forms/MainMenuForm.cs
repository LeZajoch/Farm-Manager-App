using System;
using System.Windows.Forms;

namespace Farm_Manager
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();


            //fullscreen
            // FormBorderStyle = FormBorderStyle.None;
            // WindowState = FormWindowState.Maximized;

            //transparent BG
            // UsernameLabel.Parent = pictureBox1;
            //    UsernameLabel.BackColor = Color.Transparent;

        }
        
        private void EconomyMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            var economyForm = new EconomyForm();
            economyForm.Closed += (s, args) => Close(); 
            economyForm.Show();
        }
    }
}