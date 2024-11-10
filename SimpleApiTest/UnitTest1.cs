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

        [Fact]
        public void GetSumTest()
        {
            //arrange
            var num1 = 10;
            var num2 = 20;

            //act
            var total = num1 + num2;

            //assert
            Assert.Equal(30, total);
        }
    }
}