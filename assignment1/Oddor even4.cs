using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Oddor_even4
    {
        static void main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a =Convert.ToInt32(Console.ReadLine());
            if(a%2 == 0)
            {
                Console.WriteLine("a is an even number");    
            }
            else
            {
                Console.WriteLine("a is an odd number");
            }
        }
    }
}
