using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class Overflowing
    {
        static void main(String[] args)
        { 
        byte number = 255;
        number = number+1;

            checked // prevent overflow & throw exception
            {
                byte number = 255;
                number = number + 1;

            }
        }
    }

