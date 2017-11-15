using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web2DbApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web2DbApp.Services;
using Web2DbApp.Entities;

namespace Web2DbApp.Tests
{
    [TestClass()]
    public class Web2DbApTests
    {
        [TestMethod()]
        public void TestJsonResult1()
        {
            // Arrange
            int expectedCount = 5;
            MockDataProvider mockDataProvider = new MockDataProvider();

            // Act
            List<Person> persons = mockDataProvider.GetPeople(expectedCount);

            // Assert
            Assert.AreEqual(expectedCount, persons.Count);
        }

        [TestMethod()]
        public void TestJsonResult2()
        {
            // Arrange
            int expectedCount = 8;
            MockDataProvider mockDataProvider = new MockDataProvider();

            // Act
            List<Person> persons = mockDataProvider.GetPeople(expectedCount);

            // Assert
            Assert.AreEqual(expectedCount, persons.Count);
        }

        [TestMethod()]
        public void TestValidationCodeInEntity()
        {
            
        }

        [TestMethod()]
        public void TestGetAllPersonFromDB()
        {
            // Arrange
            Repository repo = new Repository();
            MockDataProvider mockDataProvider = new MockDataProvider();
            int expectedCount = 15;

            // Act
            repo.Save(mockDataProvider.GetPeople(expectedCount));
            List<Person> persons = repo.GetAll();

            // Assert
            Assert.AreEqual(expectedCount, persons.Count);
        }
    }
}