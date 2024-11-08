using System;
using Xunit;
using SimpleApi.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleApiTest
{
    public class UnitTest1
    {
       

        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            //arrange
            var val = controller.Get(1);
            Assert.Equal("Jose", val.Value);
        }

        [Fact]
        public void GetWeatherList()
        {
            //arrange
            var val = controller.Get().ToList();

            Assert.True(val.Count > 0);
        }
    }
}