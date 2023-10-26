using Microsoft.AspNetCore.Mvc;


namespace API_Rest_Netcon_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversorController : ControllerBase
    {


        [HttpGet]
        public ActionResult<Conversor> Get(float value, string unit)
        {
            Conversor conversorData = new Conversor
            {
              Date = System.DateTime.Now
            };

            conversorData.Date = DateTime.Parse(conversorData.Date.ToString("yyyy-MM-dd HH:mm:ss"));

            if (value < 1)
            {
                conversorData.statusCode = 400;
                conversorData.errorMessage = "Valor inválido. O valor não pode ser < 1.";
                return conversorData;
            }

        
            float valueConverted = convertValue(value, unit);

            if (valueConverted == -1)
            {
                conversorData.statusCode = 400;
                conversorData.errorMessage = "Unidade inválida. Unidade deve ser 'km' ou 'anos-luz'.";
                return conversorData;
            }

            conversorData.value = valueConverted;
            conversorData.statusCode = 200;
            return conversorData;
        }

        private float convertValue(float value, string unit)
        {

            if (unit == "km")
            {
                return (float)(value * 1.057e-13);
            }

            else if (unit == "anos-luz")
            {
              
                return (float)(value * 9.461e12);
            }

            else {
                return -1;
            } 

            


        }
    }
}