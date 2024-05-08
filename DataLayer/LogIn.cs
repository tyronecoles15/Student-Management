using System;
using System.Data.SqlClient; // Import SQL Server library
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public class Login
{
    private const string connectionString = "Server = .; Initial Catalog = BelgiumCampusProjectDB; Integrated Security = SSPI";

    public bool LoginUser(string username, string password)
    {
        // Hash the entered password
        string hashedPassword = HashPassword(password);

        // Retrieve the hashed password associated with the entered username from the database
        string storedPasswordHash = RetrievePasswordHash(username);

        // Compare the hashed password from the database with the hashed password entered by the user
        if (hashedPassword == storedPasswordHash)
        {
            MessageBox.Show("Login successful.");
            return true; // Authentication successful
        }
        else
        {
            MessageBox.Show("Invalid username or password.");
            return false; // Authentication failed
        }
    }

    private string RetrievePasswordHash(string username)
    {
        string passwordHash = null;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT PasswordHash FROM UserCredentials WHERE Username = @Username";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    passwordHash = result.ToString();
                }
            }
        }

        return passwordHash;
    }

    private static string HashPassword(string password)
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

