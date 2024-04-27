using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farm_Manager.logic.database;
using static Farm_Manager.logic.database.Dao;

namespace Farm_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            //fullscreen
           // FormBorderStyle = FormBorderStyle.None;
           // WindowState = FormWindowState.Maximized;
            
            //transparent BG
           // UsernameLabel.Parent = pictureBox1;
            //    UsernameLabel.BackColor = Color.Transparent;

        }
        
        private void Data_Check(string inputuUsername, string inputPassword)
        {
            if (Login() == true)
            {
                LoginPanel.Hide();
            }
            else
            {
                MessageBox.Show("Error with login");
            }
        }
        
        private void UsernameBOX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = UsernameBOX.Text;
            string inputPassword = PasswordBOX.Text;
            Data_Check(inputUsername, inputPassword);
        }
        
        
    }
    }