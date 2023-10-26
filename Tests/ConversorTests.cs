using NUnit.Framework;
using System;

namespace API_Rest_Netcon_dotnet.Tests
{
    public class ConversorTests
    {
        [Test]
        public void Conversor_Date_ShouldBeSet()
        {
            // Arrange
            var conversor = new Conversor();
            var expectedDate = DateTime.Now;

            // Act
            conversor.Date = expectedDate;

            // Assert
            Assert.AreEqual(expectedDate, conversor.Date);
        }

        [Test]
        public void Conversor_StatusCode_ShouldBeSet()
        {
            // Arrange
            var conversor = new Conversor();
            var expectedStatusCode = 200;

            // Act
            conversor.statusCode = expectedStatusCode;

            // Assert
            Assert.AreEqual(expectedStatusCode, conversor.statusCode);
        }

        [Test]
        public void Conversor_ErrorMessage_ShouldBeSet()
        {
            // Arrange
            var conversor = new Conversor();
            var expectedErrorMessage = "Error message";

            // Act
            conversor.errorMessage = expectedErrorMessage;

            // Assert
            Assert.AreEqual(expectedErrorMessage, conversor.errorMessage);
        }

        [Test]
        public void Conversor_Value_ShouldBeSet()
        {
            // Arrange
            var conversor = new Conversor();
            var expectedValue = 10.5f;

            // Act
            conversor.value = expectedValue;

            // Assert
            Assert.AreEqual(expectedValue, conversor.value);
        }
    }
}