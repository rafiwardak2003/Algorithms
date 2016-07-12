using System;
using System.Collections;

namespace Algorithms
{
	public class Fibonacci
	{
		// Basic recursive example
		public static int RecursiveFib(int position)
		{
			if (position < 2)
			{
				return position;
			}
			else {
				return RecursiveFib(position - 2) + RecursiveFib(position - 1);
			}
		}

		// Improved recursive example
		// Cache the previous result
		static Hashtable cachedResults = new Hashtable();
		public static int ImprovedRecursiveFib(int position)
		{
			Action<int> addToCache = (result) => 
				{
					if (!cachedResults.ContainsKey(position))
					{
						cachedResults.Add(position, result);
					}               
				};

			if (position < 2)
			{
				addToCache(position);
				return position;
			}
			else
			{
				if (!cachedResults.ContainsKey(position))
				{
					int result = (int)cachedResults[position - 2] + ImprovedRecursiveFib(position - 1);
					addToCache(result);
				}

				return (int)cachedResults[position];
			}
		}

		public static int SwapFibonacci(int position)
		{
			int temp;
			int a = 0;
			int b = 1;
			for (int i = 0; i < position; i++)
			{
				temp = a;
				a = b;
				b = temp + b;
			}

			return a;
		}
	}
}
