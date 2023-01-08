using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WeatherForcastDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        //private readonly ILogger<WeatherForecastController> _logger;
        //
        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]//[HttpGet(Name = "GetWeatherForecast")]
        //[Route("[Action]")]
        public IEnumerable<WeatherForecast> GetRandomInfo()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]

        public ActionResult<MyCalcRequestDto> PostMyData([FromBody]MyCalcRequestDto dto)
        {
            long sum = dto.A + dto.B;
            if (sum == 0)
            {
                return NotFound("a+b=0����ֹ");
            }
            return Ok(dto);
        }

        public class MyCalcRequestDto
        {
            [Required]
            public int A { get; set; }
            [Required]
            public int B { get; set; }
            [Required(AllowEmptyStrings = true, ErrorMessage = "name�ֶ��Ǳ�����")]
            [MinLength(4,ErrorMessage = "name�ֶγ���Ҫ������4�ֽ�")]
            public string? Name { get; set; }
        }
    }
}