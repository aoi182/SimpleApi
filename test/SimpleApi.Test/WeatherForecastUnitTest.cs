using Xunit;
using System.Linq;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class WeatherForecastUnitTest
    {
        WeatherForecastController target = new WeatherForecastController();
        
        [Fact]
        public void CheckCount()
        {
            var weatherForecast = target.Get();
            Assert.True(weatherForecast.Count() == 5);
        }
    }
}