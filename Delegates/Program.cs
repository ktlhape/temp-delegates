using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate bool FilterDelegate(int n);
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        static void DisplayNumbers(string title, int[] nums,FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (int num in nums)
            {
                if (filter(num)) Console.Write(num + " ");
            }
        }
        static bool IsNegative(int num) => num < 0;
        static bool IsPositive(int num) => num > 0;
        static bool IsEven(int num) => num %2 == 0;
        static bool IsOdd(int num) => num % 2 > 0;
        

    }
}
