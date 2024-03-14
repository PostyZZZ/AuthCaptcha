using Npgsql;
using System;

namespace Domash0802
{
    internal class DataHelper : IDisposable
    {
        private string connectionString;
        private NpgsqlConnection connection;

        public DataHelper(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        public void CreateTable()
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS players (
                        id SERIAL PRIMARY KEY,
                        username VARCHAR(50) UNIQUE NOT NULL,
                        password VARCHAR(50) NOT NULL
                    )";
                cmd.ExecuteNonQuery();
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM players WHERE username = @Username AND password = @Password";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                long count = (long)cmd.ExecuteScalar(); 

                return count > 0;
            }
        }



        public void SaveCredentials(string username, string password)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                cmd.CommandText = @"
                    INSERT INTO players (username, password) 
                    VALUES (@Username, @Password)";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
