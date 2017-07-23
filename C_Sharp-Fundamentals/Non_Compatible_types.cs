using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class Non_Compatible_types
    {
        static void Main(string[] args)
        {
        try {

            var number = "1234";
            byte b = Convert.ToByte(number); //if you dont handle exception, exception will be propagated to .net runtime and .net runtime mechanism is to stop your application and display your error
            Console.WriteLine(b);
        }
            catch(Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }

