using System;
using System.Linq;
using System.Threading.Tasks;
using cicd_lab.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
namespace cicd_lab.tests
{
    public class GET_Must_Have_Data
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void PassingTest2()
        {
            Assert.Equal(5, Add(3, 2));
        }

        //[Fact]
        //public void FailingTest()
        //{
        //    Assert.Equal(5, Add(2, 2));
        //}

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void GetMusthHaveData()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockLogger.Object);

            // Act
            var result =  controller.Get();

            // Assert
            Assert.True(result.Count() > 0);
        }
    }
}
