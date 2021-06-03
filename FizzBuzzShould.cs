using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Fizz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.FizzBuzzMessage(number);
            Assert.Equal("Fizz", message);
        }
        
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Buzz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.FizzBuzzMessage(number);
            Assert.Equal("Buzz", message);
        }
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void FizzBuzz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.FizzBuzzMessage(number);
            Assert.Equal("FizzBuzz", message);
        }
    }
}