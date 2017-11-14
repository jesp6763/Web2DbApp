using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Web2DbApp.Entities;

namespace Web2DbApp.Services
{
    public class MockDataProvider
    {
        private string url;

        /// <summary>
        /// Extracts all people from json
        /// </summary>
        /// <param name="amount">Amount of people</param>
        /// <returns>A list of people</returns>
        public List<Person> GetPeople(int amount)
        {
            #region Setup
            List<Person> persons = new List<Person>();
            url = $"https://randomuser.me/api/?results={amount}&inc=name";
            #endregion

            #region Get json
            WebClient client = new WebClient();
            string json = client.DownloadString(url);
            JObject person = JObject.Parse(json);
            #endregion

            #region Json extraction to list of persons
            for(int i = 0; i < amount; i++)
            {
                JToken currentPerson = person["results"][i];
                string firstName = (string)currentPerson["name"]["first"];
                string lastName = (string)currentPerson["name"]["last"];
                string titleOfCourtesy = (string)currentPerson["name"]["title"];

                Person jPerson = (Person)new JsonPerson() { First = firstName, Last = lastName, Title = titleOfCourtesy };
                persons.Add(jPerson);
            }
            #endregion

            return persons;
        }
    }
}
