using System;
using ConsoleApp;
using Xunit;

namespace ConsoleAppUnitTests
{
    public class DemeritPointsCalculatorTests
    {
        DemeritPointsCalculator _demetricPoints;

        public DemeritPointsCalculatorTests()
        {
            _demetricPoints = new DemeritPointsCalculator();
        }

        [Fact]
        public void CalculateDemericPoints_SpeedBelowToZero_ThrowExcetion()
        {
            //arrange
            var speed = -1;

            //Act // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _demetricPoints.CalculateDemericPoints(speed));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(65, 0)]
        [InlineData(64, 0)]
        [InlineData(70, 1)]
        [InlineData(75, 2)]
        public void CalculateDemericPoints_WhenCalled_ReturnDemericPoints(int speed, int expected)
        {
            //Arrange
            //act
            var result = _demetricPoints.CalculateDemericPoints(speed);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
