using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web2DbApp.Entities;

namespace Web2DbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            PrintAll(persons);

            Console.ReadKey();
        }

        private static void PrintAll(List<Person> persons)
        {
            foreach(Person person in persons)
            {
                Console.WriteLine("***************************************************");
                Console.WriteLine($"First name: {person.FirstName}");
                Console.WriteLine($"Last name: {person.LastName}");
                Console.WriteLine($"Title of courtesy: {person.TitleOfCourtesy}");
            }
        }
    }
}
