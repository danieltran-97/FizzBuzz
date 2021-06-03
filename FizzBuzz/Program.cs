using System;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            
            for (var i = 1; i < 101; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzzMessage(i));
            }
        }
    }
}