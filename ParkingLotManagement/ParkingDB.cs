using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ParkingLotDB
{
    /// <summary>
    /// Control the connection to the database.
    /// </summary>
    public class DBConnection
    {
        // The object of the connection to the data base.
        SqlConnection conn = null;
        /// <summary>
        /// Constructor.
        /// </summary>
        public DBConnection()
        {
            if(conn == null)
            {
                conn = new SqlConnection(
                    "Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=Test;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=30;" +
                    "Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False"
                    );
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// Proceed a query in the database.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <returns>The dataset you want.</returns>
        public DataSet DBQuery(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }

        /// <summary>
        /// Proceed a query in the database.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <returns>The number of records.</returns>
        public int DBQueryCount(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            return da.Fill(ds);
        }

        /// <summary>
        /// Update the database.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <returns>The amount of rows that are affected.</returns>
        public int DBCmd(string sql)
        {
            SqlCommand oc = new SqlCommand
            {
                // The query statement.
                CommandText = sql,
                // The command type.
                CommandType = CommandType.Text,
                // Set the connection.
                Connection = conn
            };
            int x = oc.ExecuteNonQuery();
            return x;
        }

        /// <summary>
        /// Close the connection to the database.
        /// </summary>
        public void Close()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
