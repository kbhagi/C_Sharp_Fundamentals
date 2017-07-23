using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class ExplicitTypeConversion
    {
        static void Main(String[] args)
        {
            float f = 1.0f;//compiler is aware of data loss, so we say explicitly that we want to cast to int
            int i = (int)f;
        }
    }

}
