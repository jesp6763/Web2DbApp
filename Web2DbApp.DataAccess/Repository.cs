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
        private Executor executor;

        public Repository()
        {
            executor = new Executor();
        }

        /// <summary>
        /// Gets all person from database
        /// </summary>
        /// <returns>A list of persons found</returns>
        public List<Person> GetAll()
        {
            return new List<Person>();
        }

        /// <summary>
        /// Saves a list of persons to the database
        /// </summary>
        /// <param name="persons"></param>
        public void Save(List<Person> persons)
        {

        }
    }
}
