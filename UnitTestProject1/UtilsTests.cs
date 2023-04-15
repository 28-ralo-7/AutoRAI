using CoreLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UtilsTests
    {
        private Utils _utils;

        [TestInitialize]
        public void Initialize()
        {
            _utils = new Utils();
        }

        [TestMethod]
        public void Identity_GivenValidNameAndDateTime_ReturnsExpectedString()
        {
            //Arrange
            string name = "John Smith Doe";
            DateTime dateTime = new DateTime(2022, 06, 03, 15, 30, 00);
            string expectedOutput = "John_S.D._06.03.2022_15_30";

            //Act
            string result = _utils.Identity(name, dateTime);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Identity_GivenNameWithMoreThanThreeWords_ReturnsErrorMessage()
        {
            //Arrange
            string name = "John Smith Doe Jr.";
            DateTime dateTime = new DateTime(2022, 06, 03, 15, 30, 00);
            string expectedOutput = "Исходная строка имеет неверный формат";

            //Act
            string result = _utils.Identity(name, dateTime);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Identity_GivenNameWithLessThanThreeWords_ReturnsErrorMessage()
        {
            //Arrange
            string name = "John Smith";
            DateTime dateTime = new DateTime(2022, 06, 03, 15, 30, 00);
            string expectedOutput = "Исходная строка имеет неверный формат";

            //Act
            string result = _utils.Identity(name, dateTime);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Identity_GivenNameWithExtraWhitespace_ReturnsExpectedString()
        {
            //Arrange
            string name = "  John  Smith   Doe  ";
            DateTime dateTime = new DateTime(2022, 06, 03, 15, 30, 00);
            string expectedOutput = "John_S.D._06.03.2022_15_30";

            //Act
            string result = _utils.Identity(name, dateTime);

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
