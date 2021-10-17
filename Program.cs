using System;

namespace OOP1
{
	internal class Program
	{
		private static void Main()
		{
			int t = 4;
			int l = 3;
			int[,] nums = new int[t, l];
			Random rn = new Random();
			for (int k = 0; k < t; k++)
			{
				for (int w = 0; w < l; w++)
				{
					nums[k, w] = rn.Next(12);
				}
			}
			for (int j = 0; j < t; j++)
			{
				for (int w2 = 0; w2 < l; w2++)
				{
					Console.Write(string.Format("{0,3}", nums[j, w2]));
				}
				Console.WriteLine();
			}
			string[] words = new string[3]
			{
				"Pop",
				"Leha",
				"Top"
			};
			for (byte i = 0; i < 3; i = (byte)(i + 1))
				Console.WriteLine("El: " + words[i]);
			
			Console.ReadKey();
		}
	}
}
