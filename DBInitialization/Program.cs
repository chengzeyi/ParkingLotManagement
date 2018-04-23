using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBInitialization
{
    class Program
    {
         private bool Initialize(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string sqlCmd =
                "CREATE TABLE Register(" +
                "   username VARCHAR(32) NOT NULL," +
                "   password VARCHAR(32) NOT NULL," +
                "   PRIMARY KEY(username)" +
                "   );" +
                "INSERT INTO "

            try
            {
                // Open DB connection.
                conn.Open();
            }
            catch
            {
                // Failed to connect to DB.
                return false;
            }
            try
            {
                
            }
        }

        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
        }
    }
}
