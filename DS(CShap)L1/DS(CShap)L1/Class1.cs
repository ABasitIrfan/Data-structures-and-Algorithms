using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_CShap_L1
{   //Task01
    class Class1
    {
        public void ReadArray(int[] numbers, int n)
        {
            for (int a = 0; a < n; a++)
            {
                numbers[a] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void WriteArray(int[] numbers)
        {
            for (int a = 0; a < numbers.Length; a++)
            {
                Console.WriteLine("{0}", numbers[a]);
            }
        }
        public void ReadArray2(int[] numbers1, int n, int X, int Loc)
        {
            for (int a1 = 0; a1 < n; a1++)
            {
                numbers1[a1] = Convert.ToInt32(Console.ReadLine());
            }

            for (int K = 0; K < numbers1.Length; K++)
            {
                if (X == numbers1[K])
                {
                    Loc = K;
                    Console.WriteLine("\nLocation: {0},Number: {1}", Loc, X);
                }
                else
                {
                    K = K + 1;
                }
            }
        }

    }
}
    

