using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroNet
{
    internal class databaseConnection
    {
        public databaseConnection() { }
        public NpgsqlConnection Connection { get; set; }
        int idIndex = 0; //ID is always index 0
        int nameIndex = 1; //Name is always index 1
        int emailIndex = 3; //Email is always index 3
        int passwordIndex = 4; //Password is always index 4

        public bool connectToDatabase()
        {
            if (Connection == null)
            {
                string connString = ConfigurationManager.ConnectionStrings["PostgresConn"].ConnectionString;
                Connection = new NpgsqlConnection(connString);
            }

            if (Connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    Connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message + ". There was an issue connecting to the database.");
                    return false;
                }
            }
            return true;
        }
        public bool login(string Email, string Password)
        {
            connectToDatabase();
            string Query = "SELECT * FROM systemuser;";
            NpgsqlCommand Command = new NpgsqlCommand(Query, Connection);
            if (Connection.State == ConnectionState.Closed) Connection.Open();
            NpgsqlDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                if (DataReader.GetString(emailIndex).Equals(Email))
                {
                    if (DataReader.GetString(passwordIndex).Equals(Password))
                    {
                        DataReader.Close();
                        Connection.Close();
                        return true;
                    }

                }
            }
            DataReader.Close();
            Connection.Close();
            return false;
        }
    }
}
