using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAQA2
{
	public class Helper
	{
		public double GetValueFromConsole()
		{
			for (int i = 0; i <= 2; i++)
			{
				try
				{
					var entry = Console.ReadLine();
					var enteredValue = double.Parse(entry);

					if (enteredValue <= 0)
					{
						Console.Write("ERR:You entered a wrong value.\n");
						continue;
					}
					/*if (enteredValue > 5)
					{
						Console.Write("ERR:You entered a higher than 5.\n");
						continue;
					}*/
					return enteredValue;
				}
				catch (FormatException)
				{
					Console.Write("ERR:Only numbers are allowed.\n");
					continue;
				}
			}

			var randomValue = Math.Round(RandomNumberBetween(0.5, 5), 2);
			Console.WriteLine("We will set default random value - " + randomValue);
			return randomValue;
		}

		private readonly Random random = new Random();

		private double RandomNumberBetween(double minValue, double maxValue)
		{
			var next = random.NextDouble();
			return minValue + (next * (maxValue - minValue));
		}
	}
}
