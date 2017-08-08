using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class Program_Exercises
    {
public static void Main(string[] args)
        {
            string[] elements;
            while(true)
            {
                Console.WriteLine("Enter a list of comma-separated number: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));
            var smallests = new List<int>();
            while (smallests.Count<3)
            {
                var min = numbers[0];
                foreach(var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}
