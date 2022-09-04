using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            int timeOfMovie = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double timeForLunch = lunchBreak * 0.125;
            double timeForRest = lunchBreak * 0.25;

            double allNeededTime = timeOfMovie + timeForRest + timeForLunch;
            double difference = Math.Abs(lunchBreak - allNeededTime);

            if (lunchBreak - allNeededTime >= 0)
            {
                Console.WriteLine($"You have enough time to watch {nameOfMovie} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameOfMovie}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
