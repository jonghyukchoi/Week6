using System;

namespace Drawing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Drawing(1, 3, "*");
			Drawing(1, 4, "#");
			Drawing(1, 8, "%");
		}
		static void Drawing(int min, int max, string letter)
		{
			for (int outer = min; outer <= max; outer++) {
				for (int inner = min; inner <= outer; inner++) {
					Console.Write (letter);
				}
				Console.WriteLine ();
			}
		}
	}
}
