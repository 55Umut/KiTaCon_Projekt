using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
 
namespace KiTaCon
{
    public class DBConnection
    {
        private static DBConnection instance = null;
        private static readonly object lockObj = new object();
        private readonly string connectionString = "Server=localhost;Database=kitacon;User Id=root;Password=;";

        private DBConnection() { }

        public static DBConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new DBConnection();
                        }
                    }
                }
                return instance;
            }
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler bei der Abfrage: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public MySqlDataReader ExecuteReader(string query, params MySqlParameter[] parameters)
        {
            var conn = GetConnection();
            try
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Dispose();
                MessageBox.Show($"Fehler beim Lesen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
