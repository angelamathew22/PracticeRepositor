﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Q4
    {
        public static void Main()
        {
            SortedDictionary<int,string> obj = new SortedDictionary<int,string>();
            int x = new Random().Next(110,220);
            obj.Add(124, "emp1");
            obj.Add(458, "emp2");
            obj.Add(621, "emp3");
            obj.Add(145, "emp4");
            obj.Add(435, "emp5");
            obj.Add(685, "emp6");
            obj.Add(751, "emp7");
            obj.Add(325, "emp1");

            foreach(var k in obj)
            {
                Console.WriteLine(k);
            }
        }
    }
}
