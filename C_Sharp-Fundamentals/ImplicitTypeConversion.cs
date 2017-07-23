using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class ImplicitTypeConversion
    {
        static void Main(String[]args)
        {
            byte b = 1;//takes 1 byte of memory
            int i = b; //implicit type conversion ,compiler knows byte can hold 8 bits, int can hold 32 bits

            int x = 1; // chance for data loss
            byte y = x; // won't compile 
            //When the compiler knows theres is chance for data loss, it wont allow implicit inversino

            int m = 1;
            byte n = (byte)m; // Explicit type conversion
        }

    }
}
