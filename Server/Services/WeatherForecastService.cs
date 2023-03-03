using BlazorApp.HiringTest.Server.Services.Contracts;
using BlazorApp.HiringTest.Shared;

namespace BlazorApp.HiringTest.Server.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly ISummariesServices _summariesServices;

        public WeatherForecastService(ISummariesServices summariesServices)
        {
            _summariesServices = summariesServices;
        }

        public IEnumerable<WeatherForecast> GetData()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _summariesServices.GetSummary(),
            })
            .ToArray();
        }
    }
}
