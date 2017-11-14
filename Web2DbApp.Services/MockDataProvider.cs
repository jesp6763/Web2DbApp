using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Web2DbApp.Entities;

namespace Web2DbApp.Services
{
    public class MockDataProvider
    {
        private string url;

        public List<Person> GetPeople(int amount)
        {
            return new List<Person>();
        }
    }
}
