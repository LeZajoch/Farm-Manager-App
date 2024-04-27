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

        public static bool Login()
        {
            return true;

        }
        
    }
    
}