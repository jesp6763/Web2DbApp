using Web2DbApp.Entities;
using AspITCV.Validators.CommonEntities;

namespace Web2DbApp.Services
{
    class JsonPerson
    {
        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        public string First { get; set; }
        /// <summary>
        /// Gets or sets the lastname
        /// </summary>
        public string Last { get; set; }
        /// <summary>
        /// Gets or sets the title of courtesy
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Casts JsonPerson to a Person
        /// </summary>
        /// <param name="jPerson"></param>
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
