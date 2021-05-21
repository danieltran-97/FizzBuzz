namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string PrintFizzBuzz(int numberInput)
        {
            var message = "";
            if (numberInput % 3 == 0)
            {
                message = "Fizz";
            }

            return message;
        }
    }
}