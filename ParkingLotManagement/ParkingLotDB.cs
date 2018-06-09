using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ParkingLotDB
{
    /// <summary>
    /// Control the connection to the database.
    /// </summary>
    public static class DBConnection
    {
        /// <summary>
        /// The connection to the data base.
        /// </summary>
        private static SqlConnection conn = null;
        /// <summary>
        /// The data adapter used for executing query in
        /// the data base.
        /// </summary>
        private static SqlDataAdapter da = null;
        /// <summary>
        /// The commmand used for executing non query operation
        /// in the data base.
        /// </summary>
        private static SqlCommand oc = null;
        /// <summary>
        /// The connection string that will be loaded from App.config.
        /// </summary>
        private static string connectionString = ConfigurationManager.ConnectionStrings["dBConnection"].ConnectionString;

        /// <summary>
        /// Open connection.
        /// </summary>
        /// <returns>
        /// If succeeded, return true.
        /// If failed, return false.
        /// </returns>
        private static bool Open()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connectionString);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return true;
            } catch(Exception)
            {
                MessageBox.Show("Failed to connect to the database!");
                return false;
            }
        }

        /// <summary>
        /// Proceed a query in the database.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <param name="srcTable">The source table's name for filling.</param>
        /// <returns>The data set you want.</returns>
        public static DataSet DBQuery(string sql, string srcTable)
        {
            DataSet ds = new DataSet();
            if (Open())
            {
                try
                {
                    da = new SqlDataAdapter(sql, conn);
                    da.Fill(ds, srcTable);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to query in the database!");
                }
                finally
                {
                    Close();
                }
            }
            return ds;
        }

        /// <summary>
        /// Proceed a query in the database.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <returns>The number of records.</returns>
        public static int DBQueryCount(string sql)
        {
            int count = 0;
            if(Open())
            {
                try
                {
                    da = new SqlDataAdapter(sql, conn);
                    count = da.Fill(new DataSet());
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to query in the database!");
                }
                finally
                {
                    Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Update the database.
        /// Return the count of rows that are affected.
        /// </summary>
        /// <param name="sql">The query statement.</param>
        /// <returns>The amount of rows that are affected.</returns>
        public static int DBCmd(string sql)
        {
            int count = 0;
            if(Open())
            {
                try
                {
                    oc = new SqlCommand
                    {
                        // The query statement.
                        CommandText = sql,
                        // The command type.
                        CommandType = CommandType.Text,
                        // Set the connection.
                        Connection = conn
                    };
                    count = oc.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to execute command in the database!");
                }
                finally
                {
                    Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Close the connection to the database.
        /// </summary>
        /// <returns>
        /// If succeeded, return true.
        /// If failed, return false.
        /// </returns>
        private static bool Close()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return true;
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to close the connection to the database!");
                return false;
            }
        }
    }
}
