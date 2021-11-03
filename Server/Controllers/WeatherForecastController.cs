using BlazorWebAssemblyWithPrerendering.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyWithPrerendering.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        public WeatherForecastController(IWeatherForecastService weatherService)
        {
            _weatherService = weatherService;
        }

        private readonly IWeatherForecastService _weatherService;

        [HttpGet]
        public Task<IEnumerable<WeatherForecast>> Get()
        {
            return _weatherService.GetForecastAsync(DateTime.Now);
        }
    }
}
