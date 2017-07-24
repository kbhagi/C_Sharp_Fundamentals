using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C_Sharp_Fundamentals.Math;

namespace C_Sharp_Fundamentals
{
   
    class Class
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
  


}
