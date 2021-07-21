using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller=new WeatherForecastController();

        [Fact]
        public void Test1()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("sandeep kara", returnValue.Value);
        }
    }
}
