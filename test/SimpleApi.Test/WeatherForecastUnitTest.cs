using Xunit;
using System.Linq;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class WeatherForecastUnitTest
    {
        WeatherForecastController target = new WeatherForecastController(null, null);
        
        [Fact]
        public void CheckCount()
        {
            var weatherForecast = target.Get();
            Assert.NotNull(weatherForecast);
            Assert.True(weatherForecast.Count() == WeatherForecastController.itemsCount);
        }
    }
}