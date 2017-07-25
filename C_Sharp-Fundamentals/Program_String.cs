using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class Program_String
    {
        static void Main(string[] args)
        {
            int number;
            var Forms__Of_God = "Para_Vyuha";
            String myName = "Aniruddha";
            string GOD = "Sankarshna";
            var fullName = Forms__Of_God + " " + myName;
            var real_name = string.Format("My name is {0} {1}", Forms__Of_God, GOD);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);
            var format_Name = @"Hi John
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\\folder4"; //verbatim strings
            Console.WriteLine(format_Name);

        }
    }
}
