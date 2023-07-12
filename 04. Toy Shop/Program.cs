using System;

namespace _04._Toy_Shop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double priceExcursion = double.Parse(Console.ReadLine());
			int countOfPuzzles = int.Parse(Console.ReadLine());
			int countOfDolls = int.Parse(Console.ReadLine());
			int teddyBears = int.Parse(Console.ReadLine());
			int countOfMinions = int.Parse(Console.ReadLine());
			int trucks = int.Parse(Console.ReadLine());

			double sum = countOfPuzzles * 2.60 + countOfDolls * 3 + teddyBears * 4.10 + countOfMinions * 8.20 + trucks * 2;
			int countOfToys = countOfPuzzles + countOfDolls + teddyBears + countOfMinions + trucks;
			double discount = 0.0;

			if (countOfToys >= 50)
			{
				discount = 0.25 * sum;
			}

			double totalPrice = sum - discount;
			double rent = 0.1 * totalPrice;
			double profit = totalPrice - rent;

			if (profit >= priceExcursion)
			{
				double remainingMoney = profit - priceExcursion;
				Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
			}
			else
			{
				double needMoney = priceExcursion - profit;
				Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
			}
		}
	}
}
