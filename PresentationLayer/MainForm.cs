using milestoneTwo.BusinessLogicLayer;
using milestoneTwo.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace milestoneTwo.PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtStudentNumber.TextChanged += txtStudentNumber_TextChanged;
            txtName.TextChanged += txtName_TextChanged;
            txtSurname.TextChanged += txtSurname_TextChanged;
            txtDOB.TextChanged += txtDOB_TextChanged;
            txtGender.TextChanged += txtGender_TextChanged;
            txtAddress.TextChanged += txtAddress_TextChanged;
            txtPhone.TextChanged += txtPhone_TextChanged;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtDOB.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtStudentNumber.BackColor = Color.Red;
                txtName.BackColor = Color.Red;
                txtSurname.BackColor = Color.Red;
                txtDOB.BackColor = Color.Red;
                txtGender.BackColor = Color.Red;
                txtAddress.BackColor = Color.Red;
                txtPhone.BackColor = Color.Red;

                MessageBox.Show("Please complete all fields");
             
            } else
            {
                DataHandler handler = new DataHandler();
                Person newStudent = new Person
                (int.Parse(txtStudentNumber.Text), txtName.Text, txtSurname.Text, DateTime.Parse(txtDOB.Text), txtGender.Text, txtPhone.Text, txtAddress.Text, txtModuleCodes.Text);

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;


                    handler.Register(newStudent, imagePath);
                }
            }
            
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtStudentNumber.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtStudentNumber.BackColor = SystemColors.Window;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtName.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtName.BackColor = SystemColors.Window;
            }
        }
        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtSurname.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtSurname.BackColor = SystemColors.Window;
            }
        }
        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDOB.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtDOB.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtDOB.BackColor = SystemColors.Window;
            }
        }
        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGender.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtGender.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtGender.BackColor = SystemColors.Window;
            }
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtAddress.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtAddress.BackColor = SystemColors.Window;
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtPhone.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtPhone.BackColor = SystemColors.Window;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            lblNote.BackColor = Color.Green;
            lblNote.ForeColor = Color.White;
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            Module_Information modules = new Module_Information();  
            modules.Show(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();

            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
             
                MessageBox.Show("Please enter a value in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                txtStudentNumber.Focus();
              
                
                txtStudentNumber.BackColor = Color.Red;
               


            }
            else
            {
                Person newStudent = new Person
          (int.Parse(txtStudentNumber.Text), txtName.Text, txtSurname.Text, DateTime.Parse(txtDOB.Text), txtGender.Text, txtPhone.Text, txtAddress.Text, txtModuleCodes.Text);

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;


                    handler.updateStudent(newStudent, imagePath);
                }
            }

         
        }
   

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.Show();
        }

      
    }
}
