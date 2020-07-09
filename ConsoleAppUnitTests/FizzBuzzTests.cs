using System;
using ConsoleApp;
using Xunit;

namespace ConsoleAppUnitTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void GetOutPut_InputIsDivisibleBy3And5_ReturnFizzBuzz(int number)
        {
            //Act
            var result = FizzBuzz.GetOutPut(number);

            //Asserts
            Assert.Equal("FizzBuzz", result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void GetOutPut_InputIsDivisibleBy3_ReturnFizz(int number)
        {
            //Act
            var result = FizzBuzz.GetOutPut(number);

            //Asserts
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void GetOutPutInputIsDivisibleBy5_ReturnBuzz(int number)
        {
            //Act
            var result = FizzBuzz.GetOutPut(number);

            //Asserts
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GetOutPut_InputIsNotDivisibleBy3And5_ReturnNumberConvertedToStrin()
        {
            //Arrange
            var value = 1;

            //Act
            var result = FizzBuzz.GetOutPut(value);

            //Asserts
            Assert.Equal("1",result);
        }
    }
}
