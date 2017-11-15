using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Web2DbApp.Entities;

namespace Web2DbApp.DataAccess
{
    public class Repository
    {
        /// <summary>
        /// Reference to an sql executor
        /// </summary>
        private Executor executor;

        public Repository()
        {
            executor = new Executor();
        }

        /// <summary>
        /// Gets all people from dbtable
        /// </summary>
        /// <returns>A list of persons found</returns>
        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            DataSet dataSet = executor.Execute("SELECT * FROM dbo.Persons");

            if(dataSet.Tables != null && dataSet.Tables.Count > 0)
            {
                foreach(DataRow row in dataSet.Tables[0].Rows)
                {
                    string firstName = row.Field<string>("Firstname");
                    string lastName = row.Field<string>("Lastname");
                    string title = row.Field<string>("Title");
                    persons.Add(new Person(firstName, lastName, title));
                }
            }

            return persons;
        }

        /// <summary>
        /// Saves a list of people to the dbtable
        /// </summary>
        /// <param name="persons"></param>
        public void Save(List<Person> persons)
        {

        }
    }
}
