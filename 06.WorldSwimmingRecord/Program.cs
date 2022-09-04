using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsForMetres = double.Parse(Console.ReadLine());

            double distanceToSwimInSecond = distanceInMetres * timeInSecondsForMetres;
            double waterResisytance = Math.Floor(distanceInMetres / 15);
            double addetTime = waterResisytance * 12.5;
            double finalTimeForSwim = distanceToSwimInSecond + addetTime;

            if (finalTimeForSwim < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finalTimeForSwim:F2} seconds.");
            }
            else
            {
                double needenSeconds = finalTimeForSwim - worldRecord;
                Console.WriteLine($"No, he failed! He was {needenSeconds:F2} seconds slower.");
            }
        }
    }
}
