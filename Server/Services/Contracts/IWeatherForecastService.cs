using BlazorApp.HiringTest.Shared;

namespace BlazorApp.HiringTest.Server.Services.Contracts
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetData();
    }
}