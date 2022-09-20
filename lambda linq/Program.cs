using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LANGUAGE INTEGRATED QUERY (LINQ)

/*---LINQ FUNCTIONS---
 * FIRST
 * FIRSTORDEFAULT
 * GROUPBY
 * MIN
 * MAX
 * SUM
 * AVERAGE
 * ORDERBY
 * WHERE SELECT
 * SELECTMANY*/

namespace lambda_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Anonymus function: (x=>x%2==0) where x is one of the numbers from the array
            List<int> evenNums = arr.FindAll(x => x % 2 == 0);
            foreach (int num in evenNums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            List<int> rendezetlen = new List<int> { 51, 95, 66, 72, 42, 38, 39, 41, 15 };

            //MIN
            int min = rendezetlen.Min();
            Console.WriteLine("Minimum: " + min);

            //MAX
            int max = rendezetlen.Max();
            Console.WriteLine("Maximum: " + max);

            //AVG
            double avg = rendezetlen.Average();
            Console.WriteLine("Average: " + avg);

            //SUM
            int sum = rendezetlen.Sum();
            Console.WriteLine("Sum: " + sum);

            //ORDERBY
            List<int> rendezett = rendezetlen.OrderBy(x => x).ToList();
            Console.WriteLine("Ordered list of numbers:");
            foreach (int num in rendezett)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //WHERE
            List<int> even = rendezett.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Numbers that can be divided by two:");
            foreach (int num in even)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //SELECT
            List<int> negyzetek = rendezett.Select(x => { return x * x; }).ToList();
            Console.WriteLine("Squared numbers:");
            foreach (int num in negyzetek)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //FIRST
            int hatos = rendezett.First(x =>
            {
                int tizesek = x / 10;
                int egyesek = x % 10;

                return tizesek + egyesek == 6;
            });
           





        }
    }
}
