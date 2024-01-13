using ThingToRelease.Models;

namespace ThingToRelease.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetWeatherForecasts();
}