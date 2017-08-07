using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class Program_StringBuilder
    {
        static void Main(string[]args)
        {
            //StringBuilder & String Manipulation methods
            var builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine("First Char: "+builder[0]);
        }
    }
}
