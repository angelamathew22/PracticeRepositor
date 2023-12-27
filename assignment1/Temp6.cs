using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Temp6
    {
        static void main(string[] args)
        {
            double celcius;
            Console.WriteLine("enter fahrenhit value");
            double fahrenhit = Convert.ToDouble(Console.ReadLine());
            celcius = (fahrenhit - 32) * 5 / 9;
            Console.WriteLine("the converted into celcius=" + cellcius);
            Console.Read();

        }
    }
}
