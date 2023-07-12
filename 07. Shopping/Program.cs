using System;

namespace _07._Shopping
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int videoCards = int.Parse(Console.ReadLine());
			int cpu = int.Parse(Console.ReadLine());
			int ram = int.Parse(Console.ReadLine());

			double priceVideoCards = videoCards * 250;
			double priceCpu = priceVideoCards * 0.35;
			double sumCpu = cpu * priceCpu;
			double priceRam = priceVideoCards * 0.1;
			double sumRam = ram * priceRam;
			double totalSum = priceVideoCards + sumCpu + sumRam;



			if (videoCards > cpu)
			{
				totalSum = totalSum - totalSum * 0.15;

			}

			if (totalSum <= budget)
			{
				double leftMoney = budget - totalSum;
				Console.WriteLine($"You have {leftMoney:F2} leva left!");
			}
			else
			{
				double needMoney = totalSum - budget;
				Console.WriteLine($"Not enough money! You need {needMoney:F2} leva more!");
			}
		}
	}
}
