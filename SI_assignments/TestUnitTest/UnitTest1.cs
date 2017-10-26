using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SI_assignments;

namespace TestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private string validName = "Name Test";
        private DateTime validDateTime = new DateTime(1234, 01, 02);
        
        private int maleCode = 0;
        private int femaleCode = 1;

        private Person GetValidPerson()
        {
            return new Person(validName, new DateTime(1234, 01, 02), 0);
        }

        [TestMethod]
        public void Should_ReturnValidName_When_UsingGetter()
        {
            Person testPerson = GetValidPerson();
            Assert.AreEqual(validName, testPerson.Name);
        }

        [TestMethod]
        public void Should_ThrowArgumentException_When_NameIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Person(null, validDateTime, femaleCode));
        }

        [TestMethod]
        public void Should_ThrowArgumentException_When_GenderNrIsLessThanZero()
        {
            Assert.AreEqual(EnumGender.MONKEY, new Person(validName, validDateTime, -1).Gender);
        }

        [TestMethod]
        public void Should_ThrowArgumentException_When_GenderNrIsGreaterThanOne()
        {
            Assert.AreEqual(EnumGender.MONKEY, new Person(validName, validDateTime, 3).Gender);
        }
    }
}
