using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private string _message = string.Empty;

        public string FizzBuzzMessage(int numberInput)
        {

            if (_fizz(numberInput) && _buzz(numberInput))
            {
                _message = "FizzBuzz";
            }
            else if (_fizz(numberInput))
            {
                _message = "Fizz";
            }
            else if (_buzz(numberInput))
            {
                _message = "Buzz";
            }
            else
            {
                _message = numberInput.ToString();
            }
            
            return _message;
        }

        private static bool _fizz(int number)
        {
            return (number % 3 == 0);
        }

        private static bool _buzz(int number)
        {
            return (number % 5 == 0);
        }
        
        
        
    }
}