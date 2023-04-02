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

			for (int i = 0; i < ints.Length; i++)
			{
				ints[i] = random.Next(1, 100);
			}

			Console.WriteLine("Creating an array with 10 random integers");
            Console.WriteLine(string.Join(", ", ints));

            return ints;
		}

        public static int[] MultiplyRandomArray(int[] prevArray)
		{
            var array = prevArray ?? throw new ArgumentNullException(nameof(prevArray), "The given array is null");
            var random = new Random();
            var number = random.Next(1, 11);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= number;
            }

            Console.WriteLine($"Multiplying array by {number}");
            Console.WriteLine(string.Join(", ", array));

            return array;
        }

        public static int[] SortAscending(int[] prevArray)
		{
            var array = prevArray ?? throw new ArgumentNullException(nameof(prevArray), "The given array is null");
            Array.Sort(array);
            Console.WriteLine("Array is being sorted by ascending");
            Console.WriteLine(string.Join(", ", array));

            return array;
        }

        public static double GetAverageValue(int[] prevArray)
        {
            var array = prevArray ?? throw new ArgumentNullException(nameof(prevArray), "The given array is null");
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double average = sum / array.Length;
            Console.WriteLine($"Average value of the array: {average}");

            return average;
        }
    }
}

