using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr1 = new int[] { 1, 1, 2, 3, 4 };

            for (int i = 0; i < 5; i++)
            {
                count = 0;

                for (int j = 0; j < i - 1; j++)
                {

                    if (arr1[i] == arr1[j])
                    {
                        count++;
                    }
                }

                for (int k = i + 1; k < 5; k++)
                {

                    if (arr1[i] == arr1[k])
                    {
                        count++;
                    }

                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }

                if (count == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
        }
    }
}
