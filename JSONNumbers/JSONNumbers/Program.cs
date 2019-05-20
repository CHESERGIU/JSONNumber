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
                success = ZeroLeading(console, number);
                if (console[console.Length - 1] == '.')
                    success = PointEnding(console, number);
            }
            else success = false;       
            return success;           
        }

        private static bool PointEnding(string console, double number)
        {
            return number.ToString().Length == console.Length;
        }

        public static bool ZeroLeading(string console, double number)
        {
            if (console[0] == '0' && number > 1)
                    return false;
            return true;
            
        }

    }
}
