using Microsoft.AspNetCore.Mvc;
using System.Reflection;


namespace SABAKatochcom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        public string hyr = "";
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
         [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {


                Summarys = hyr

            })
            .ToArray();
        }
        [HttpPost(Name = "Figma")]
        public Detail PostDetail(DateTime model)
        {
            var newDetail = new Detail()
            {
                Model = model,

            };
            if (model.Month == 1) { hyr = "Овен"; }
            if (model.Month == 2) { hyr = "Телец"; }
            if (model.Month == 3) { hyr = "♊Близнецы"; }
            if (model.Month == 4) { hyr = "Рак"; }
            if (model.Month == 5) { hyr = "Лев"; }
            if (model.Month == 6) { hyr = "Дева"; }
            if (model.Month == 7) { hyr = "Весы"; }
            if (model.Month == 8) { hyr = "Скорпион"; }
            if (model.Month == 9) { hyr = "Стрелец"; }
            if (model.Month == 10) { hyr = "Козерог"; }
            if (model.Month == 11) { hyr = "Водолей"; }
            if (model.Month == 12) { hyr = "Рыбы"; }
            return newDetail;
        }
    }
}