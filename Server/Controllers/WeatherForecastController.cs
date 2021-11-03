using BlazorWebAssemblyPrerendering.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAssemblyPrerendering.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService forecastService;

        public WeatherForecastController(IWeatherForecastService forecastService)
        {
            this.forecastService = forecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var forecasts = await forecastService.GetForecastAsync(DateTime.Now);
            return forecasts;
        }
    }
}