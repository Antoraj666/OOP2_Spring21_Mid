using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 9, 8, 7, 2, 1, 2, 1 };
            int count = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("Total number of duplicate elements found in array:" + count);
            Console.ReadLine();
        }
    }
}
