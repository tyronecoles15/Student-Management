using System;
using System.Data.SqlClient; // Import SQL Server library
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public class SignUp
{
    private const string connectionString = "Server = .; Initial Catalog = BelgiumCampusProjectDB; Integrated Security = SSPI";

    public void SignUser(string username, string password)
    {
        // Hash the password
        string hashedPassword = HashPassword(password);

        // Insert the username and hashed password into the database
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO UserCredentials (Username, PasswordHash) VALUES (@Username, @PasswordHash)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        MessageBox.Show("User signed up successfully.");
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ComputeHash - returns byte array
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convert byte array to a string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
