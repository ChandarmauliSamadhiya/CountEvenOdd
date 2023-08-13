using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Even elements: " + evenCount);
            Console.WriteLine("Odd elements: " + oddCount);
            Console.ReadLine();
        }
    }
}
