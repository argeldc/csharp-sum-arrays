using System;

namespace sum_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //dichiarazione array e contenitore somma
            double[] arr = [1, 5.2, 4, 0, -1];
            double sum = 0;

            //ciclo l'array con foreach
            foreach (double num in arr)
            {   
                //somma ogni elemento dell'array nel contenitore
                sum += num;

            }

            //stampa la somma
            Console.WriteLine(sum);
        }
    }
}
