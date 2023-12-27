using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Oddeven5
    {
        static void main(string[] args)
        {
            int even,odd;
            int[] arr;
            Console.WriteLine("enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter elements in array");
            arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            even = 0;odd = 0;
            for(int i = 0;i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("total even number=" + even);
            Console.WriteLine("total odd number=" + odd);
            Console.read();
        }
    }
}
