using NUnit.Framework;


namespace API_Rest_Netcon_dotnet.Tests
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

            
            conversor.statusCode = expectedStatusCode;

            
            Assert.AreEqual(expectedStatusCode, conversor.statusCode);
        }

        [Test]
        public void Conversor_ErrorMessage_ShouldBeSet()
        {
           
            var conversor = new Conversor();
            var expectedErrorMessage = "Error message";

           
            conversor.errorMessage = expectedErrorMessage;

            
            Assert.AreEqual(expectedErrorMessage, conversor.errorMessage);
        }

        [Test]
        public void Conversor_Value_ShouldBeSet()
        {
           
            var conversor = new Conversor();
            var expectedValue = 10.5f;

       
            conversor.value = expectedValue;

          
            Assert.AreEqual(expectedValue, conversor.value);
        }
    }
}