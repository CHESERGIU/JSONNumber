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
            bool success = true;
            if (double.TryParse(console, out double number))
            {
                success = true;
            }
            else success = false;
            return success;           
        }
    }
}
