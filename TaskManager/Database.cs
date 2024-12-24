using Npgsql;
using System;

namespace RepairRequestSystem
{
    public static class Database
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=1;Database=TaskManager";


        public static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }
    }
}
