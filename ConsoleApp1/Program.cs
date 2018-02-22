using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input from use
            //Console.WriteLine("Please type directory path for which you want sub-directory and file info:");

            string input = args[0];//Console.ReadLine();
            if (!System.IO.Directory.Exists(input))
            {
                Console.WriteLine("Directory path doesn't exist.");
            }

            System.IO.DriveInfo di = new System.IO.DriveInfo(input);
            System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");
            System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            Console.WriteLine(String.Concat("Total Files: ", fileNames.Length));
            Console.WriteLine(String.Concat("Total Directories: ", dirInfos.Length));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
