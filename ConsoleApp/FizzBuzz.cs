using System;
namespace ConsoleApp
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public static string GetOutPut(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if ((number % 5 == 0))
                return "Buzz";

            return number.ToString();
        }
    }
}
