using CleanApi.Application.Adapters;

namespace CleanApi.WebApi.Endpoints;

public static class WeatherForecastEndpoint
{
    private static readonly string[] s_summaries = 
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public static IEndpointRouteBuilder AddWeatherForecastEndpoints(this IEndpointRouteBuilder routeBuilder)
    {
        routeBuilder.MapGet("/weatherforecast", () =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    s_summaries[Random.Shared.Next(s_summaries.Length)]
                ))
                .ToArray();
            return forecast;
        })
        .WithName("GetWeatherForecast");

        return routeBuilder;
    }
}
