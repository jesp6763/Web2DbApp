using Web2DbApp.Entities;
using AspITCV.Validators.CommonEntities;

namespace Web2DbApp.Services
{
    class JsonPerson
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Title { get; set; }

        public static explicit operator Person(JsonPerson jPerson)
        {
            Person person = new Person(jPerson.First, jPerson.Last, jPerson.Title);
            #region Validation
            (bool isValid, string errorMessage) validationResult = PersonValidations.IsNameValid($"{jPerson.First} {jPerson.Last}");

            if(!validationResult.isValid)
            {
                if(char.IsWhiteSpace(person.FirstName[0]))
                {
                    person.FirstName.TrimStart(' ');
                }
                
                char[] firstNameCharacters = person.FirstName.ToCharArray();

                // Make first letter uppercase if it is a lowercase
                if(char.IsLower(firstNameCharacters[0]))
                {
                    firstNameCharacters[0] = char.ToUpper(firstNameCharacters[0]);
                }

                person.FirstName = new string(firstNameCharacters);
            }
            #endregion

            return person;
        }
    }
}
