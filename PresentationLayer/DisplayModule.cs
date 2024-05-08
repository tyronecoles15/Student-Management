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
    public partial class DisplayModule : Form
    {
        public DisplayModule()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();

            DataTable dataTable = new DataTable();

            string moduleCode = txtModuleCode.Text;

            dataTable = handler.SearchModule(moduleCode);

            dataGridView1.DataSource = dataTable;   
        }

        private void DisplayModule_Load(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();

            DataTable dataTable = new DataTable();

            dataTable = handler.GetModule();

            dataGridView1.DataSource= dataTable;    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
