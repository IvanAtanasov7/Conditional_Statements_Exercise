using System;

namespace _06._World_Swimming_Record
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double recordSeconds = double.Parse(Console.ReadLine());
			double distanceMeters = double.Parse(Console.ReadLine());
			double time = double.Parse(Console.ReadLine());


			double distance = distanceMeters * time;
			double resistance = Math.Floor(distanceMeters / 15) * 12.5;
			double totalTime = distance + resistance;

			if (totalTime < recordSeconds)
			{
				Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
			}
			else
			{
				double missingSeconds = totalTime - recordSeconds;
				Console.WriteLine($"No, he failed! He was {missingSeconds:F2} seconds slower.");
			}
		}
	}
}
