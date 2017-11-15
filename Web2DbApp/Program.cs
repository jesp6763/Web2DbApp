using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web2DbApp.Entities;
using Web2DbApp.Services;

namespace Web2DbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MockDataProvider mockDataProvider = new MockDataProvider();
            PrintAll(mockDataProvider.GetPeople(10));

            Console.ReadKey();
        }

        private static void PrintAll(List<Person> persons)
        {
            foreach(Person person in persons)
            {
                Console.WriteLine($"{person.TitleOfCourtesy}. {person.FirstName} {person.LastName}");
            }
        }
    }
}
