using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        [Fact]
        public void PrintFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var message = fizzBuzz.PrintFizzBuzz(3);
            Assert.Equal("Fizz", message);
        }
    }
}