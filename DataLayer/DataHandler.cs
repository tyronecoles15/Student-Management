using milestoneTwo.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestoneTwo.DataLayer
{
    internal class DataHandler
    {
        string connection = "Server = .; Initial Catalog = BelgiumCampusProjectDB; Integrated Security = SSPI";




        // This method looks slightly different in order to enable the profile picture upload
        public void Register(Person person, string imagePath)
        {
            try
            {
              
                byte[] imageData = File.ReadAllBytes(imagePath);

                string query = "INSERT INTO Students VALUES " +
                    "(@studentNumber, @firstName, @surname, @studentImage, @DOB, @gender, @phone, @studentAddress, @moduleCodes);";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                    
                        cmd.Parameters.AddWithValue("@studentNumber", person.StudentNumber);
                        cmd.Parameters.AddWithValue("@firstName", person.Name);
                        cmd.Parameters.AddWithValue("@surname", person.Surname);

                       
                        cmd.Parameters.Add("@studentImage", SqlDbType.VarBinary).Value = imageData;

                        cmd.Parameters.AddWithValue("@DOB", person.DateOfBirth);
                        cmd.Parameters.AddWithValue("@gender", person.Gender);
                        cmd.Parameters.AddWithValue("@phone", person.Phone);
                        cmd.Parameters.AddWithValue("@studentAddress", person.Address);
                        cmd.Parameters.AddWithValue("@moduleCodes", person.ModuleCodes);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"{person.Name} {person.Surname} registered successfully.");

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering student.");
                throw;
            }
        }

        public DataTable GetData()
        {
            try
            {
                string query = $"SELECT * FROM Students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            } catch (Exception ex)
            {
                throw;
            }
             
        }

        public DataTable Search(int studentNumber)
        {
            try
            {
                string query = $"SELECT * FROM Students WHERE studentNumber = {studentNumber}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            } catch (Exception ex)
            {
                throw;
            }
          
        }

     

        public void updateStudent(Person person, string imagePath)
        {
            try
            {
                byte[] imageData = File.ReadAllBytes(imagePath);

                string query = "UPDATE Students SET " +
                               "studentNumber = @studentNumber, " +
                               "firstName = @firstName, " +
                               "surname = @surname, " +
                               "studentImage = @studentImage, " +
                               "DOB = @DOB, " +
                               "gender = @gender, " +
                               "phone = @phone, " +
                               "studentAddress = @studentAddress, " +
                               "moduleCodes = @moduleCodes " +
                               "WHERE studentNumber = @originalStudentNumber;";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentNumber", person.StudentNumber);
                        cmd.Parameters.AddWithValue("@firstName", person.Name);
                        cmd.Parameters.AddWithValue("@surname", person.Surname);
                        cmd.Parameters.AddWithValue("@studentImage", imageData);
                        cmd.Parameters.AddWithValue("@DOB", person.DateOfBirth);
                        cmd.Parameters.AddWithValue("@gender", person.Gender);
                        cmd.Parameters.AddWithValue("@phone", person.Phone);
                        cmd.Parameters.AddWithValue("@studentAddress", person.Address);
                        cmd.Parameters.AddWithValue("@moduleCodes", person.ModuleCodes);
                        cmd.Parameters.AddWithValue("@originalStudentNumber", person.StudentNumber);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"{person.Name} {person.Surname} updated successfully.");

                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void deleteStudent(int studentNumber)
        {
            try
            {
                string query = $"DELETE FROM Students WHERE studentNumber = {studentNumber};";

                using (SqlConnection con = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show($"Student {studentNumber} has been deleted.");
                }
            } catch (Exception)
            {
                throw;
            }
        }

        // Below are the methods that will work with the Module class

        public void AddModule(Module module)
        {
            string query = $"INSERT INTO Module VALUES ('{module.ModuleCode}', '{module.ModuleName}', " +
               $"'{module.ModuleDescription}', '{module.OnlineResources}')";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                MessageBox.Show($"{module.ModuleName} added successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show($"Error adding {module.ModuleName} to system");
                throw;
            }
        }

        public void updateModule(Module module)
        {
            string query = $"UPDATE Module SET moduleCode = '{module.ModuleCode}', moduleName = '{module.ModuleName}', " +
                $"moduleDescription = '{module.ModuleDescription}', onlineResources = '{module.OnlineResources}' WHERE moduleCode = '{module.ModuleCode}';";
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SearchModule(string moduleCode)
        {
            try
            {
                string query = $"SELECT * FROM Module WHERE moduleCode LIKE '{moduleCode}';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public DataTable GetModule()
        {
            string query = $"SELECT * FROM Module";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void deleteModule(string moduleCode)
        {
            try
            {
                string query = $"DELETE FROM Module WHERE moduleCode LIKE '{moduleCode}';";

                using (SqlConnection con = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                MessageBox.Show($"{moduleCode} has been deleted.");
            }
            catch (Exception)
            {
                throw;
            }
        }










    }
}
