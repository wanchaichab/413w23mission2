using System;
namespace Mission_2
{
	public class DiceFunctions
	{
		public void RollDice(int maxRolls)
		{
			Random r = new Random();
			int[] totals = new int[11];

			// Loop to roll 2 dice
			for (int i = 0; i < maxRolls; i++)
			{
				int currentRoll = r.Next(1, 7);
				currentRoll += r.Next(1, 7);
				// Store current roll in array
				totals[currentRoll - 2] += 1;
				currentRoll = 0;
			}

			// Calculate percentage
			for (int i = 0; i < totals.Length; i++)
			{
				float numStars = (totals[i] / (float)maxRolls) * 100;
				string stars = "";

				// Create stars
				for (int j = 0; j < numStars; j++)
				{
					stars += "*";
				}

				// Print histogram
				Console.WriteLine((i + 2) + ": " + stars);
			}
        }
	}
}

