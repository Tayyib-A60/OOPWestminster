using System;
namespace TemperatureAlert
{
    public static class DiceThrow
    {
        public static void Throw()
        {
            var rand = new Random();
            int die1 = 0;
            int die2 = 0;

            while(die1 != 6 && die2 != 6) // true && false => false
            {
                die1 = rand.Next(1, 7); // 1
                die2 = rand.Next(1, 7); // 6

                Console.WriteLine($"Die1: {die1}, Die2: {die2}");
            }
        }
    }
}
