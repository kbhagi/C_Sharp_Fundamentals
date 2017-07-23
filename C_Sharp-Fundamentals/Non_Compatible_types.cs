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
            string s = "1";
            int i = (int)s; //won't compile

            string z = "1";
            int x = Convert.ToInt32(z);//right way of conversion 
            int j = int.Parse(z);
        }
    }
}
