using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Web2DbApp.Entities
{
    /// <summary>
    /// Represents a person
    /// </summary>
    public class Person
    {
        #region Fields
        /// <summary>
        /// The first name of the person
        /// </summary>
        protected string firstName;
        /// <summary>
        /// The last name of the person
        /// </summary>
        protected string lastName;
        /// <summary>
        /// The title of courtesy
        /// </summary>
        private string titleOfCourtesy;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <param name="firstName">The person's firstname</param>
        /// <param name="lastName">The person's lastname</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when firstname, or postalCode is greater than 10. Thrown when lastName is greater than 20. Thrown when city, region, or country is greater than 15. Thrown when address is greater than 60</exception>
        /// <exception cref="ArgumentException">Thrown when firstName or lastname, address, city, region, postalCode, or country is empty, null, numbers, or has special characters</exception>
        public Person(string firstName, string lastName, string titleOfCourtesy)
        {
            FirstName = firstName;
            LastName = lastName;
            TitleOfCourtesy = titleOfCourtesy;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 10</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string FirstName
        {
            get => firstName;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-zæøåÆØÅ]+$"))
                {
                    if(value.Length <= 10)
                    {
                        firstName = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is greater than 20</exception>
        /// <exception cref="ArgumentException">Thrown when the value is empty, null or has special characters, or numbers</exception>
        public string LastName
        {
            get => lastName;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value, "^[ A-Za-zæøåÆØÅ]+$"))
                {
                    if(value.Length <= 20)
                    {
                        lastName = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Gets or sets the title of courtesy
        /// </summary>
        public string TitleOfCourtesy
        {
            get => titleOfCourtesy;
            set => titleOfCourtesy = value;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Empty;
        }
        #endregion
    }
}