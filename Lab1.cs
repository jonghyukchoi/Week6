using System;

namespace Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintIntroduction ();

			string name = "";
			EnterYourName (ref name);


			int[] numbers;

			GetLotteryNumbers (out numbers);


			Console.Write ("Name : {0}, Numbers : [", name);
			foreach (int number in numbers) {
				Console.Write ("{0} ", number);
			}
			Console.WriteLine ("]");
		}
		static void PrintIntroduction()
		{
			Console.WriteLine ("**********************************");
			Console.WriteLine ("******** Lottery Numbers *********");
			Console.WriteLine ("**********************************");
		}
		public static string EnterYourName(ref string name)
		{
			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();
			return name;
		}
		public static int[] GetLotteryNumbers(out int[] numbers)
		{
			Random random = new Random ();
			numbers = new int[6] { 0, 0, 0, 0, 0, 0 };
			int index = 0;

			do {			
				int randomNumber = random.Next (1, 46);
				for (int loop = 0; loop < index; loop++) {
					if (numbers [loop] == randomNumber) {
						break;
					}
				}

				if (numbers [index] != randomNumber) {
					numbers [index] = randomNumber;
					index++;
				}
			} while(index < numbers.Length);
			return numbers;
		}
	}
}
