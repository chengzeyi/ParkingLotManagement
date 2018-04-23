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
        public DBConnection(string connectionString)
        {
            if(conn == null)
            {
                conn = new SqlConnection(connectionString);
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
        public DataSet DBQuery(string sql, string srcTable)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, srcTable);
            return ds;
        }

        /// <summary>
        /// Proceed a query in the database.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <returns>The number of records.</returns>
        public int DBQueryCount(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            return da.Fill(new DataSet());
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
            return oc.ExecuteNonQuery();
        }

        /// <summary>
        /// Close the connection to the database.
        /// </summary>
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
