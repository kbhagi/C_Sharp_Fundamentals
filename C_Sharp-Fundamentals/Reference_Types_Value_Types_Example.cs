﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
public class Person
    {
        public int Age;
    }

    class Reference_Types_Value_Types_Example
    {

        static void Main(string[]args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

}
