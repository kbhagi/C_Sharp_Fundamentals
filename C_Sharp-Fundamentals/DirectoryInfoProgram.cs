using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class DirectoryInfoProgram
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
           var files= Directory.GetFiles(@"D:\Projects\C_Sharp-Fundamentals", "*sln", SearchOption.AllDirectories);
            //foreach (var file in files)
               // Console.WriteLine(file);
            var directories = Directory.GetDirectories(@"D:\Projects\C_Sharp-Fundamentals", "*.*", SearchOption.AllDirectories);
     foreach(var directory in directories)
                Console.WriteLine(directory);
            Directory.Exists("...");
            var directoryInfo = new DirectoryInfo("....");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
                       
   }
    }
}
