using System;
namespace TemperatureAlert
{
    public static class ScoresAverage
    {
        public static void CalculateScoresAverage()
        {
            Console.WriteLine("Insert the number of scores:");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] scores = new int[size];

            for (int i = 0; i < scores.Length; i++) // [0, 0, 0, 0]
            {
                int value;
                do
                {
                    Console.WriteLine("Enter the score");
                    value = Convert.ToInt32(Console.ReadLine());
                } while (value < 1 || value > 5);
                scores[i] = value;
            }

            int sum = 0;

            for (int i = 0; i < scores.Length; i++) // 1,2,2,4,5
            {
                sum += scores[i];
            }

            double avg = (double)sum / scores.Length;
            Console.WriteLine($"Average is {avg}");
            // go through all the array elements and calculate their sum
            // divide the result by the number of elements
        }
    }
}
