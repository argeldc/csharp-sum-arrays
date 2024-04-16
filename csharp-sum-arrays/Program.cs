using System;

namespace sum_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = [1, 5.2, 4, 0, -1];
            double sum = 0;

            foreach (double num in arr)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
