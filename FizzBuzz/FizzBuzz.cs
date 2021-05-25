using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string PrintFizzBuzz(int numberInput)
        {
            string message;

            if (numberInput % 3 == 0 && numberInput % 5 != 0)
            {
                message = "Fizz";
            }
            else if (numberInput % 5 == 0 && numberInput % 3 != 0)
            {
                message = "Buzz";
            }

            else if (numberInput % 3 == 0 && numberInput % 5 == 0)
            {
                message = "FizzBuzz";
            }
            else
            {
                message = numberInput.ToString();
            }
            
            return message;
        }
    }
}