using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class File_Programs
    {
 static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg",true);
            File.Delete(path);
            if(File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);
        }       
    }
}
