using milestoneTwo.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestoneTwo.PresentationLayer
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
            txtDelete.TextChanged += txtDelete_TextChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            DataHandler handler = new DataHandler();

           
            int studentNumber;

           
            if (!int.TryParse(txtDelete.Text, out studentNumber))
            {
                // If the input is not a valid integer, show an error message to the user
                MessageBox.Show("Please enter a valid student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDelete.Focus();


                txtDelete.BackColor = Color.Red;
                return; // Exit the method to prevent further execution
            }

            try
            {
                // Attempt to delete the student using the DataHandler
                handler.deleteStudent(studentNumber);

                // If deletion is successful, display a success message to the user
                MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // If an exception occurs during deletion, display an error message with the exception details
                MessageBox.Show($"An error occurred while deleting the student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDelete.Text))
            {
                // If the textbox is empty or contains only whitespace, change its background color to red
                txtDelete.BackColor = Color.Red;
            }
            else
            {
                // If the textbox is not empty, reset its background color to the default
                txtDelete.BackColor = SystemColors.Window;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
