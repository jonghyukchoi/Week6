using System;

namespace Week06_Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter a word: ");
			string word = Console.ReadLine ();
			Palindrome (word);
		}
		static string FindFirstWord(string word)
		{
			return word.Substring(0, 1);
		}
		static string FindLastWord(string word)
		{
			return word.Substring (word.Length - 1);
		}
		static string SplitWord(ref string word)
		{
			return word.Substring (1, word.Length - 2);
		}
		static void Palindrome(string word)
		{
			for (int i = 1; i <= word.Length/2; i++ ) {
				string firstword = FindFirstWord (word);
				string lastword = FindLastWord (word);
				if (firstword == lastword) {
					SplitWord (ref word);
				} else {
					Console.WriteLine ("'{0}' is not Palindrome.", word); 
					return;
				}
			}
			Console.WriteLine ("'{0}' is Palindrome.", word);
		}
	}
}