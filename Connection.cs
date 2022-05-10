using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public static class Connection
    {
        public static string ConnectionString =>
            @"Data Source=(LocalDB)\MSSQLLocalDB;
             AttachDbFilename='|DataDirectory|\ShopEasyDatabase.mdf';Integrated Security=True";

        private static SqlConnection ServerConnection = null;

        /* Creates the SqlConnection used to connect to whatever SQL Database the Connection.ConnectionString
         * is set to.
         * 
         * Returns FALSE if the connection was unsuccessful, otherwise returns true.
         */
        public static bool Create()
        {
            ServerConnection = null;
            try
            {
                ServerConnection = new SqlConnection(Connection.ConnectionString);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

            return true;
        }

        /* Returns a reference to the current SqlConnection.
         */
        public static SqlConnection GetConnection()
        {
            return ServerConnection;
        }

        /* Opens the SqlConnection connected to the SQL Database File.
         * 
         * Returns FALSE if the connection could not be opened, otherwise returns true.
         */
        public static bool Open()
        {
            try
            {
                ServerConnection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

            return true;
        }

        /* Closes the SqlConnection.
         * 
         * Returns TRUE if the connection was successfully closed, otherwise returns false.
         */
        public static bool Close()
        {
            if (ServerConnection != null)
            {
                ServerConnection.Close();
                return true;
            }

            return false;
        }
    }
}
