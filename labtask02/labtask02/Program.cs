using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, odd = 0, even = 0;

            Console.Write("Enter number: ");

            for (i = 1; i <= 10; i += 2)
            {
                odd += i;
            }
            Console.WriteLine("Sum of even numbers between 1 to 10 = " + odd);
            for (i = 0; i <= 10; i += 2)
            {
                even += i;
            }
            Console.WriteLine("Sum of odd numbers between 1 to 10 = " + even);

            Console.ReadLine();
        }
    }
}
