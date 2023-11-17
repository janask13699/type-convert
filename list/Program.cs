using System;

namespace list
{
    public class Conversion
    {
        public static void Main(string[] args)
        {
            // Example using int.Parse
            Console.WriteLine("Enter a number:");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter Correct Input method.");
            }


            // Example using int.TryParse
            Console.WriteLine("Enter another number:");
            int parsedNumber;
            if (int.TryParse(Console.ReadLine(), out parsedNumber))
            {
                Console.WriteLine("You entered: " + parsedNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
