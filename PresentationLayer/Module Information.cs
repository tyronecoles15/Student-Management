using milestoneTwo.BusinessLogicLayer;
using milestoneTwo.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestoneTwo.PresentationLayer
{
    public partial class Module_Information : Form
    {
        public Module_Information()
        {
            InitializeComponent();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler(); 
            
            DeleteModule delete = new DeleteModule();
            delete.Show();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
          
            string moduleCode = txtModuleCode.Text;
            string moduleName = txtModuleName.Text;
            string moduleDescription = txtModuleDescription.Text;
            string onlineResources = txtOnlineResources.Text;

          
            if (string.IsNullOrWhiteSpace(moduleCode) || string.IsNullOrWhiteSpace(moduleName))
            {
                MessageBox.Show("Module code and name are required fields.");
                return;
            }

            DataHandler handler = new DataHandler();

            
            Module newModule = new Module(moduleCode, moduleName, moduleDescription, onlineResources);

            
            handler.AddModule(newModule);

            
            MessageBox.Show("Module added successfully.");
        }


        private void btnDisplayModule_Click(object sender, EventArgs e)
        {
            DisplayModule displayModule = new DisplayModule();
            displayModule.Show();
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            
            string moduleCode = txtModuleCode.Text;
            string moduleName = txtModuleName.Text;
            string moduleDescription = txtModuleDescription.Text;
            string onlineResources = txtOnlineResources.Text;

            
            if (string.IsNullOrWhiteSpace(moduleCode) || string.IsNullOrWhiteSpace(moduleName))
            {
                MessageBox.Show("Module code and name are required fields.");
                return;
            }

            DataHandler handler = new DataHandler();


            Module updatedModule = new Module(moduleCode, moduleName, moduleDescription, onlineResources);

            
            handler.updateModule(updatedModule);

            
            MessageBox.Show("Module updated successfully.");
        }

    }
}
