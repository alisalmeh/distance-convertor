using System;

namespace AliSalmeh_ProjectWeek2_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in miles: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // process converting miles to kilometers
            double convertMilesToKilometers = Math.Round((userInput / 0.621371), 5);

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{userInput} miles is equal to {convertMilesToKilometers} kilometers.");
            Console.ResetColor();
        }
    }
}
