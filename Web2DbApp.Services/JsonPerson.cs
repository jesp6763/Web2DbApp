using Web2DbApp.Entities;

namespace Web2DbApp.Services
{
    class JsonPerson
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Title { get; set; }

        public static explicit operator Person(JsonPerson jPerson)
        {
            return new Person(jPerson.First, jPerson.Last, jPerson.Title);
        }
    }
}
