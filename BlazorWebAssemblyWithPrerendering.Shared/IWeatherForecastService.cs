using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAssemblyWithPrerendering.Shared
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate);
    }
}