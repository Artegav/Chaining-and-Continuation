using System;
using System.Linq;
using System.Threading.Tasks;

namespace Chaining_and_Continuation
{
	public class Tasks
	{
        public static int[] TenRandomInts()
		{
			var random = new Random();
			int[] ints = new int[10];

			for (int i = 0; i < ints.Length; ++i)
			{
				ints[i] = random.Next(100);
			}

			Console.WriteLine("Creating an array with 10 random integers");
            Console.WriteLine(string.Join(", ", ints));

            return ints;
		}

        public static int[] MultiplyRandomArray(int[] prevArray)
		{
			var random = new Random();
			var number = random.Next(1, 11);

			for (int i = 0; i < prevArray.Length; ++i)
			{
                prevArray[i] *= number;
            }

            Console.WriteLine($"Multiplying array by {number}");
            Console.WriteLine(string.Join(", ", prevArray));

            return prevArray;
        }

        public static int[] SortAscending(int[] prevArray)
		{
			//ints.OrderBy(x => x);
			Array.Sort(prevArray);
            Console.WriteLine("Array is being sorted by ascending");
            Console.WriteLine(string.Join(", ", prevArray));

            return prevArray;
		}

        public static double GetAverageValue(int[] prevArray)
        {
            double sum = 0;

            for (int i = 0; i < prevArray.Length; i++)
            {
                sum += prevArray[i];
            }

            double average = sum / prevArray.Length;
            Console.WriteLine($"Average value of the array: {average}");

            return average;
        }
    }
}

