using ThingToRelease.Services;

namespace ThingToRelease.Tests.Services;

public class WeatherForecastServiceTests
{
    [Test]
    public void WeatherForecastService_GetWeatherForecasts_ReturnsFiveForecats()
    {
        // Arrange
        IWeatherForecastService weatherForecastService = new WeatherForecastService();

        // Act
        var result = weatherForecastService.GetWeatherForecasts();
        
        // Assert
        Assert.That(result.Count(), Is.EqualTo(5));
    }
}