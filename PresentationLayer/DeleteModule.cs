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
    public partial class DeleteModule : Form
    {
        DataHandler handler = new DataHandler();

        public DeleteModule()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Extract the module code from the text box
            string moduleCode = txtDelete.Text;

            // Check if the module code is not empty
            if (!string.IsNullOrEmpty(moduleCode))
            {
                // Call the appropriate method to handle the deletion of the module
                handler.deleteModule(moduleCode);

                // Optionally, you can provide feedback to the user after deletion
                MessageBox.Show("Module deleted successfully.");
            }
            else
            {
                // Notify the user if the module code is empty
                MessageBox.Show("Please enter a module code to delete.");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
