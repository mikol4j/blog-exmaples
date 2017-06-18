using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication;

namespace UnitTests
{
    [TestClass]
    public class ExampleClassTests
    {

        [TestMethod]
        public void ShouldRetrunTrue_When_FirstLetterIsCapitalic()
        {
            //Arrange
            string country = "Poland";
            //Act
            bool retVal = ExampleClass.IsCapitalized(country);
            //Asert
            Assert.AreEqual(retVal, true);
        }

        [TestMethod]
        public void ShouldRetrunFalse_When_FirstLetterIsNotCapitalic()
        {
            //Arrange
            string country = "poland";
            //Act
            bool retVal = ExampleClass.IsCapitalized(country);
            //Asert
            Assert.AreEqual(retVal, false);
        }
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void ShouldThrowExcpetionNullExcpetion_When_StringIsNullOrEmpty()
        {
            //Arrange
            string country = string.Empty;
            //Act
            bool retVal = ExampleClass.IsCapitalized(country);
            //Asert
            
        }

    }
}
