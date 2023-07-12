using System;

namespace _08._Lunch_Break
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string moveName = Console.ReadLine();
			int episodeLength = int.Parse(Console.ReadLine());
			int breakDuration = int.Parse(Console.ReadLine());

			double timeForLunch = breakDuration * 0.125;
			double timeForRelax = breakDuration * 0.25;
			double timeLeft = breakDuration - timeForLunch - timeForRelax;

			if (timeLeft >= episodeLength)
			{
				double extraTime = timeLeft - episodeLength;
				Console.WriteLine($"You have enough time to watch {moveName} and left with {Math.Ceiling(extraTime)} minutes free time.");

			}
			else
			{
				double timeNeed = episodeLength - timeLeft;
				Console.WriteLine($"You don't have enough time to watch {moveName}, you need {Math.Ceiling(timeNeed)} more minutes.");

			}

		}
	}
}
