using BlazorWebAssemblyWithPrerendering.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebAssemblyWithPrerendering.Client
{
    public class HttpWeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public HttpWeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate)
        {
            return _httpClient.GetJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast");
        }
    }
}
