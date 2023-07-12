using System;

namespace _01._Sum_Seconds
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstTime = int.Parse(Console.ReadLine());
			int secondTime = int.Parse(Console.ReadLine());
			int thidTime = int.Parse(Console.ReadLine());
			int totalTime = firstTime + secondTime + thidTime;

			int minutes = totalTime / 60;
			int seconds = totalTime % 60;

			if (seconds < 10)
			{
				Console.WriteLine($"{minutes}:0{seconds}");
			}
			else
			{
				Console.WriteLine($"{minutes}:{seconds}");
			}
		}
	}
}
