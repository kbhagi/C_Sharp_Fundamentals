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
            //File provides static methods, when using the File class operating system does some security checks and that can impact the performance of your application if you have large number of operations. In that case your can create fileInfo object and use it.
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg",true);
            File.Delete(path);
            if(File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);
            //fileInfo provides instance methods
            var fileInfo = new FileInfo(path); 
            fileInfo.CopyTo("...");
            fileInfo.Delete();
           if (fileInfo.Exists)
            {
                //
            }
          
        }       
    }
}
