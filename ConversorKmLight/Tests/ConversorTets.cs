using NUnit.Framework;


namespace ConversorKmLight.Tests
{
    public class ConversorTests
    {
        [Test]
        public void Conversor_Date_ShouldBeSet()
        {
           
            var conversor = new Conversor();
            var expectedDate = DateTime.Now;

            
            conversor.Date = expectedDate;

            
            Assert.AreEqual(expectedDate, conversor.Date);
        }

        [Test]
        public void Conversor_StatusCode_ShouldBeSet()
        {
            
            var conversor = new Conversor();
            var expectedStatusCode = 200;

            
            conversor.StatusCode = expectedStatusCode;

            
            Assert.AreEqual(expectedStatusCode, conversor.StatusCode);
        }

        [Test]
        public void Conversor_ErrorMessage_ShouldBeSet()
        {
           
            var conversor = new Conversor();
            var expectedErrorMessage = "Error message";

           
            conversor.ErrorMessage = expectedErrorMessage;

            
            Assert.AreEqual(expectedErrorMessage, conversor.ErrorMessage);
        }

        [Test]
        public void Conversor_Value_ShouldBeSet()
        {
           
            var conversor = new Conversor();
            var expectedValue = 10.5f;

       
            conversor.Value = expectedValue;

          
            Assert.AreEqual(expectedValue, conversor.Value);
        }
    }
}