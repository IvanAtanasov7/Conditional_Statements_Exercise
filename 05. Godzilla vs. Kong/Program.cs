using System;

namespace _05._Godzilla_vs._Kong
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int countOfStatisti = int.Parse(Console.ReadLine());
			double priceClothingForStatist = double.Parse(Console.ReadLine());

			double priceDecor = budget * 0.1;
			double priceClothing = countOfStatisti * priceClothingForStatist;


			double discount = 0.0;
			if (countOfStatisti > 150)
			{
				discount = priceClothing * 0.1;
				priceClothing = priceClothing - discount;
			}
			double totalPriceForFilm = priceDecor + priceClothing;
			double remainingMoney = budget - totalPriceForFilm;
			if (totalPriceForFilm > budget)
			{

				Console.WriteLine("Not enough money!");
				Console.WriteLine($"Wingard needs {Math.Abs(remainingMoney):F2} leva more.");
			}
			else if (totalPriceForFilm <= budget)
			{
				double needMoney = budget - totalPriceForFilm;
				Console.WriteLine("Action!");
				Console.WriteLine($"Wingard starts filming with {needMoney:F2} leva left.");

			}
		}
	}
}
