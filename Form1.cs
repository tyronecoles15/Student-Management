using milestoneTwo.DataLayer;
using milestoneTwo.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestoneTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          Login login = new Login();    
          bool outcome = login.LoginUser(txtUsername.Text, txtPassword.Text);  

            if (outcome)
            {
                Form1 form1 = new Form1();
                form1.Hide();

                MainForm main = new MainForm();
                main.Show();
            } else
            {
                txtUsername.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;  
            }

        

              

          
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtUsername.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtUsername.BackColor = SystemColors.Window;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtPassword.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtPassword.BackColor = SystemColors.Window;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SignUp signUpForm = new SignUp();

                signUpForm.SignUser(txtUsername.Text, txtPassword.Text);

                Form1 form1 = new Form1();
                form1.Hide();

                MainForm main = new MainForm();
                main.Show();
            } else
            {
                MessageBox.Show("Please enter a valid username or password");
                txtUsername.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
            }
           
        }
    }
}
