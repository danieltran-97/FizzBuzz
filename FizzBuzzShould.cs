using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void PrintFizz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.PrintFizzBuzz(number);
            Assert.Equal("Fizz", message);
        }
        
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void PrintBuzz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.PrintFizzBuzz(number);
            Assert.Equal("Buzz", message);
        }
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void PrintFizzBuzz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.PrintFizzBuzz(number);
            Assert.Equal("FizzBuzz", message);
        }
    }
}