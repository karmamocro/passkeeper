using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passkeeper
{
    class Database
    {
        private const string provider = "System.Data.SqlClient";
        private const string connectionString = "Data Source=DESKTOP-UF0PRTR;Initial Catalog=funTest;Integrated Security=True";

        private static DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
        private static DbConnection connection = factory.CreateConnection();
        public static bool Connect()
        {
            // DbProviderFactories generates an 
            // instance of a DbProviderFactory


            // The DBConnection represents the DB connection
            // Check if a connection was made
            if (connection == null)
            {
                Console.WriteLine("Connection Error");
                Console.ReadLine();
                return false;
            }

            if (connection.State == ConnectionState.Open)
                return true;


            // The DB data needed to open the correct DB
            connection.ConnectionString = connectionString;

            // Open the DB connection
            connection.Open();
            return true;
        }

        public static DbDataReader sql(string _mSql)
        {
            if (connection.State == ConnectionState.Closed)
                Connect();
            // Allows you to pass queries to the DB
            DbCommand command = factory.CreateCommand();

            // Set the DB connection for commands
            command.Connection = connection;

            // The query you want to issue
            command.CommandText = _mSql;


            // DbDataReader reads the row results
            // from the query
            DbDataReader dataReader = command.ExecuteReader();
            // Advance to the next results
            return dataReader;
        }

        public static void Close()
        {
            connection.Close();
        }
    }
}
