using System;
using System.Collections.Generic;
using Web2DbApp.Entities;
using Web2DbApp.Services;
using Web2DbApp.DataAccess;

namespace Web2DbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MockDataProvider mockDataProvider = new MockDataProvider();
            List<Person> people = mockDataProvider.GetPeople(10);
            PrintAll(people);

            Repository repository = new Repository();
            repository.Save(people);
            Console.WriteLine("Executed");

            Console.ReadKey();
        }

        /// <summary>
        /// Prints all people from given list
        /// </summary>
        /// <param name="persons">All the people to print</param>
        private static void PrintAll(List<Person> persons)
        {
            foreach(Person person in persons)
            {
                Console.WriteLine($"{person.TitleOfCourtesy}. {person.FirstName} {person.LastName}");
            }
        }
    }
}
