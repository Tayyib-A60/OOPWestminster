using System;
namespace TemperatureAlert
{
    public static class NFactorial
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter the value of n:");

            var n = Convert.ToInt32(Console.ReadLine()); // 5

            // 5 * 4 * 3 * 2 * 1

            var result = 1;

            for(int i = n; i >= 1; i--)
            {
                result = result * i; // => 5, 20, 60, 120, 120
            }

            Console.WriteLine(result);
        }
    }
}
