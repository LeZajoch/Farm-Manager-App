using System;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using System.Configuration;

namespace Farm_Manager.logic.database
{
    
    
    public class Dao
    {
        
        public static DatabaseConnection Connect()
        {
            SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
            consStringBuilder.UserID = ReadConfig("Name");
            consStringBuilder.Password = ReadConfig("Password");
            consStringBuilder.InitialCatalog = ReadConfig("DataBase");
            consStringBuilder.DataSource = ReadConfig("DataSource");
            consStringBuilder.ConnectTimeout = 30;
            SqlConnection connection = new SqlConnection(consStringBuilder.ConnectionString);
            
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.Connection = connection;
            dbConnection.ConnectionStringBuilder = consStringBuilder;
            try
            {
                connection.Open();
                return dbConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
                return null;
            }
        }
        
        public static string ReadConfig(string key)
        {
            string value = ConfigurationManager.AppSettings[key].ToString();
            return value;
        }

        
        public static bool Login(string userInput)
        {
            bool isMatch = false;

            try
            {
                // Load connection string components from app.config
                SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                consStringBuilder.UserID = ReadConfig("Name");
                consStringBuilder.Password = ReadConfig("Password");
                consStringBuilder.InitialCatalog = ReadConfig("DataBase");
                consStringBuilder.DataSource = ReadConfig("DataSource");
                consStringBuilder.ConnectTimeout = 30;
                

                using (SqlConnection connection = new SqlConnection(consStringBuilder.ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to retrieve data from the database
                    string query = "SELECT * FROM Users WHERE Username = @UserInput";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for user input
                        command.Parameters.AddWithValue("@UserInput", userInput);

                        // Execute the query
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if any rows match the user input
                            if (reader.HasRows)
                            {
                                isMatch = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            if (isMatch)
            {
                return true;
            }
                return false;
            

        }
        
    }
    
}