using BlazorApp.HiringTest.Server.Services.Contracts;

namespace BlazorApp.HiringTest.Server.Services
{
    public class SummariesServices : ISummariesServices
    {
        private static readonly string[] _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string GetSummary() => _summaries[Random.Shared.Next(_summaries.Length)];
    }
}
