﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    class Swapping
    {
        
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before Swapping value of a={0},b={1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping value of a={0},b={1}", a, b);
            Console.ReadLine();

           
        }
    }
}
