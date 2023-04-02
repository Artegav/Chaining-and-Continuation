using System;
using System.Linq;
using System.Threading.Tasks;
using static Chaining_and_Continuation.Tasks;

namespace Chaining_and_Continuation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task<int[]> task1 = Task.Factory.StartNew(TenRandomInts);
            Task<int[]> task2 = task1.ContinueWith(t => MultiplyRandomArray(t.Result));
            Task<int[]> task3 = task2.ContinueWith(t => SortAscending(t.Result));
            Task<double> task4 = task3.ContinueWith(t => GetAverageValue(t.Result));

            task4.Wait();
            Console.WriteLine($"\nAverage value: {task4.Result}");

            Console.ReadKey();
        }
    }
}

