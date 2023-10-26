using Microsoft.AspNetCore.Mvc;


namespace API_Rest_Netcon_dotnet.Controllers
{
    [ApiController]
    [Route("api/converter")]
    public class ConversorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Conversor> Convert( float? km, float? anosLuz)
        {
            if (km.HasValue)
            {
                if (km < 1)
                {
                    return CreateBadRequest("Valor inválido. O valor não pode ser < 1.");
                }

                return CreateSuccessResponse(km.Value, "km");
            }
            else if (anosLuz.HasValue)
            {
                if (anosLuz < 1)
                {
                    return CreateBadRequest("Valor inválido. O valor não pode ser < 1.");
                }

                return CreateSuccessResponse(anosLuz.Value, "anos-luz");
            }

            return CreateBadRequest("Unidade inválida.");
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

        private ActionResult<Conversor> CreateBadRequest(string errorMessage)
        {
        
            return BadRequest(new Conversor
            {
                statusCode = 400,
                errorMessage = errorMessage,
                Date = DateTime.Now
            });
        }


        private ActionResult<Conversor> CreateSuccessResponse(float value, string unit)
        {
            float convertedValue = convertValue(value, unit);

            return Ok(new Conversor
            {
                statusCode = 200,
                value = convertedValue,
                Date = DateTime.Now
            });
        }




    }

}

   