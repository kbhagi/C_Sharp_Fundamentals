﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class While_Loops
    {
static void Main(string[] args)
        {
            var i = 0; while (i <= 10) { if (i % 2 == 0) Console.WriteLine(i); i++; }
while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                { 
                Console.WriteLine("@Echo: "+input);
            }

        }
    }
}
