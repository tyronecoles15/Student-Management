using milestoneTwo.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestoneTwo.PresentationLayer
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();

            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(textBox1.Text);

            DataHandler handler = new DataHandler();
            DataTable searchTable = new DataTable();    

            searchTable = handler.Search(studentNumber);

            dataGridView1.DataSource = searchTable; 

           
            string columnName = "studentImage";
            int rowIndex = 0;  // Specify the row index you want to access

          
            object columnValue = searchTable.Rows[rowIndex][columnName];

            // Access the byte array representing the image
            byte[] imageData = searchTable.Rows[rowIndex][columnName] as byte[];

            
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(ms);

                pictureBox1.Image = image;
            }
        }
        

        private void Display_Load(object sender, EventArgs e)
        {
            DataTable loadTable = new DataTable();  
            DataHandler handler = new DataHandler();

            loadTable = handler.GetData();

            dataGridView1.DataSource = loadTable;   
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Get the index of the image path column in your DataGridView
            int imagePathColumnIndex = dataGridView1.Columns["studentImage"].Index;

            // Check if the current row is valid and has a non-empty image path
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[imagePathColumnIndex].Value != null)
            {
                // Get the image path from the DataGridView
                string imagePath = dataGridView1.Rows[e.RowIndex].Cells[imagePathColumnIndex].Value.ToString();

                // Check if the image file exists
                if (File.Exists(imagePath))
                {
                    // Load the image to get its height
                    using (Bitmap bmp = new Bitmap(imagePath))
                    {
                        // Set the height of the row to the height of the image
                        dataGridView1.Rows[e.RowIndex].Height = bmp.Height;
                    }
                }
            } 
        }
    }
}
