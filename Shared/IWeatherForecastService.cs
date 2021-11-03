using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssemblyPrerendering.Shared;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}
