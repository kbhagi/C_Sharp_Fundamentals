using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
   
    class Conditionals
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true; float price; if (isGoldCustomer) price = 19.95f; else price = 29.95f;

            float price_ = (isGoldCustomer) ? 19.95f : 29.95f; Console.WriteLine(price);

            var season = Season.Autumn; switch (season)
            { case Season.Autumn:
                case Season.Summer: Console.WriteLine("We've got promotion");break;
                default: Console.WriteLine("I don't understand that season!");break; 
                
                }




        }
    }
}
