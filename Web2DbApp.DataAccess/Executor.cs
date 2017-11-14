using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Web2DbApp.DataAccess
{
    public class Executor
    {
        private const string connectionString = "";

        public Executor()
        {

        }

        public void Execute(string procedureName, string sqlQuery)
        {

        }

        public DataSet Execute(string stringQuery)
        {
            return new DataSet();
        }
    }
}
