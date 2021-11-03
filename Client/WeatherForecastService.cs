using BlazorWebAssemblyPrerendering.Shared;
using System.Net.Http.Json;

namespace BlazorWebAssemblyPrerendering.Client;


public class WeatherForecastService : IWeatherForecastService
{
    private readonly HttpClient httpClient;

    public WeatherForecastService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        var forecasts = await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        return forecasts!;
    }
}
