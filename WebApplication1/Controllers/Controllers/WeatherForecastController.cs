using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("GetName/{name}/{uniName}")]
        public string GetName(string name, string uniName)
        {
            return "Hi i am " + name + " From " + uniName;
        }

        [HttpPost("SaveName/{name}/{uniName}")]
        public string SaveName(string name, string uniName)
        {
            return "Hi i am " + name + " From " + uniName;
        }

        [HttpPost("SaveStudent")]
        public string SaveStudent(Product student)
        {

            return "Hi i am " + student.Name + " From ";
        }
    }
}