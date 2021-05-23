using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string PrintFizzBuzz(int numberInput)
        {
            var message = String.Empty;
            
            if (numberInput % 3 == 0)
            {
                message = "Fizz";
            }

            if (numberInput % 5 == 0)
            {
                message = "Buzz";
            }

            if (numberInput % 3 == 0 && numberInput % 5 == 0)
            {
                message = "FizzBuzz";
            }
            

            return message;
        }
    }
}