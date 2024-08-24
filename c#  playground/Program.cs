﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 100; ++i) 
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 3 == 0) 
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0) 
                {
                    Console.Write("Buzz");
                }
                 else
                {
                    Console.WriteLine(i);
                }
            }  
        }
    }
}
