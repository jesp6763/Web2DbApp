using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Web2DbApp.DataAccess
{
    public class Executor
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Web2DbApp;Integrated Security=false;";

        /// <summary>
        /// Initializes a new instance of the Executor class
        /// </summary>
        public Executor()
        {

        }

        /// <summary>
        /// Executes a stored procedure
        /// </summary>
        /// <param name="procedureName">The name of the stored procedure</param>
        /// <param name="sqlQuery">The sql query to execute</param>
        public void Execute(string procedureName, string sqlQuery)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(procedureName, connection) { CommandType = CommandType.StoredProcedure })
                {
                    command.Parameters.Add("@sqlQuery", SqlDbType.NVarChar).Value = sqlQuery;
                    connection.Open();
                    command.ExecuteNonQuery();
                    Debug.WriteLine("Executed sql");
                }
            }
        }

        /// <summary>
        /// Executes a sql query
        /// </summary>
        /// <param name="sqlQuery">The sql query to execute</param>
        /// <returns>A dataset with changed data</returns>
        public DataSet Execute(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                    }
                }
            }

            return dataSet;
        }
    }
}
