using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Fundamentals
{
    class Program_Text
    {
static void Main(string[]args)
        {
            var sentence = "This is going to be a really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
            
            }
        

        }
    
}
