using System;
namespace TemperatureAlert
{
    public static class ReverseArray
    {
        public static void Reverse()
        {
            double[] scores = new double[] { 5.0, 4.7, 3.5, 2.6, 1.6 };

            double[] scoresReverse = new double[5];

            for (int i = scores.Length - 1; i >= 0; i--) // for(int i = 0; i < scores.Length; i++)
            {
                double currentScore = scores[i];
                scoresReverse[scores.Length - i - 1] = currentScore;
            }

            Console.WriteLine(scoresReverse);
        }
    }
}
