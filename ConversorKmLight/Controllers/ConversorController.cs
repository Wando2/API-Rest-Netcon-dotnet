using Microsoft.AspNetCore.Mvc;


namespace ConversorKmLight.Controllers;

    [ApiController]
    public class ConversorController : ControllerBase
    {
        [HttpGet("v1/conversor/{km?}/{anosLuz?}")]
        public ActionResult<Conversor> Convert(float? km, float? anosLuz)
        {
            var units = new Dictionary<string, float?>
            {
                { "km", km },
                { "anos-luz", anosLuz }
            };

            foreach (var unit in units)
            {
                if (unit.Value.HasValue)
                {
                    if (unit.Value < 1)
                    {
                        return CreateBadRequest("Valor inválido. O valor não pode ser < 1.");
                    }

                    return CreateSuccessResponse(unit.Value.Value, unit.Key);
                }
            }

            return CreateBadRequest("Unidade inválida.");
        }


        private float ConvertValue(float value, string unit)
        {

            if (unit == "km")
            {
                return (float)(value * 1.057e-13);
            }

            else if (unit == "anos-luz")
            {
              
                return (float)(value * 9.461e12);
            }

             return -1;
         

            


        }

        private ActionResult<Conversor> CreateBadRequest(string errorMessage)
        {
        
            return BadRequest(new Conversor
            {
                StatusCode = 400,
                ErrorMessage = errorMessage,
                Date = DateTime.Now
            });
        }


        private ActionResult<Conversor> CreateSuccessResponse(float value, string unit)
        {
            float convertedValue = ConvertValue(value, unit);

            return Ok(new Conversor
            {
                StatusCode = 200,
                Value = convertedValue,
                Date = DateTime.Now
            });
        }




    }



   