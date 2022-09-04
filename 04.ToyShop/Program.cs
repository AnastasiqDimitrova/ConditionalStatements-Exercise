using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double parseForTrip = double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double parseForPuzzels = numberOfPuzzels * 2.60;
            double parseForDolls = numberOfDolls * 3.0;
            double parseForBears = numberOfBears * 4.10;
            double parseForMinions = numberOfMinions * 8.20;
            double parseForTrucks = numberOfTrucks * 2.0;

            double numberOfToys = parseForPuzzels + parseForDolls + parseForBears + parseForMinions + parseForTrucks;
            int sumOfAllTous = numberOfPuzzels + numberOfDolls + numberOfBears + numberOfTrucks + numberOfMinions;

            if (sumOfAllTous >= 50)
            {
                double discount = numberOfToys * 0.25;
                numberOfToys = numberOfToys - discount;
            }
            double rent = numberOfToys * 0.1;
            double finalIncom = numberOfToys - rent;

            if (finalIncom >=  parseForTrip)
            {
                double moneyLeft = finalIncom - parseForTrip;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyNeeded = parseForTrip - finalIncom;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }

            
        }
    }
}
