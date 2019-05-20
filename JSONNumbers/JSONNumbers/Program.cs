using System;

namespace JSONNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string console = Console.ReadLine();
            bool success = IsValidJSONNumber(console);
            if (success == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }

        public static bool IsValidJSONNumber(string console)
        {
            return double.TryParse(console, out double number)
              && !HasLeadingZero(console, number)
              && !EndsInDot(console);
        }

        public static bool HasLeadingZero(string input, double number)
        {
            return number > 1 && input[0] == '0';
        }

        public static bool EndsInDot(string input)
        {
            return input.EndsWith(".");
        }
    }
}
