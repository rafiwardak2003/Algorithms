using System;

namespace Algorithms
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string result;

			Console.WriteLine("Recursive Fibonacci");
			result = string.Join(", ", RunFibonacci(Fibonacci.RecursiveFib));
			Console.WriteLine(result);


			Console.WriteLine("Improved Recursive Fibonacci");
			result = string.Join(", ", RunFibonacci(Fibonacci.ImprovedRecursiveFib));
			Console.WriteLine(result);

			Console.WriteLine("Swap Fibonacci");
			result = string.Join(", ", RunFibonacci(Fibonacci.SwapFibonacci));
			Console.WriteLine(result);
		}

		static int[] RunFibonacci(Func<int, int> fibFunc)
		{
			int[] results = new int[10];
			for (int i = 0; i < 10; i++)
			{
				results[i] = fibFunc(i);
			}

			return results;
		}
	}
}
