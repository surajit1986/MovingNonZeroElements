using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingNonZeroElements
{
    internal class MovingZonZeroes
    {
        public void MovingNonZeroesToLeft(int[] arr)
        {
            int i = 0;

            foreach (int x in arr)
            {
                if(x!=0)
                {
                    arr[i++] = x;
                }
            }
            while (i < arr.Length)
            {
                arr[i++] = 0;
            }

            Console.WriteLine("Output Array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
