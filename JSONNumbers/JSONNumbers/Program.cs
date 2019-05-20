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
            for(int i = 0; i < console.Length; i++)
            {
                if (console[i] == '.')
                {
                    if (i == console.Length - 1) return false;
                }

            }            
            if (console[0] == '0' && double.TryParse(console, out double num))
            {
                if (num > 1)
                    return false;
            }
                     
            return success;           
        }
    }
}
