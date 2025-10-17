using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab
{
    public class DirectoryLab
    {


        public void main(string[] args)
        {
            //不同操作系统目录分隔符不同
            Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

            // returns:
            // stores\201 on Windows
            //
            // stores/201 on macOS

            //Join paths
            Console.WriteLine(Path.Combine("stores", "201"));

            //Determine filename extensions
            Console.WriteLine(Path.GetExtension("sales.json"));

            //文件遍历查找
            IEnumerable<String> salesFiles = FindFile("stores", "sales.json");
            foreach (String salesFile in salesFiles)
            {
                Console.WriteLine(salesFile);
            }

        }



        IEnumerable<String> FindFile(string folderName, string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\", folderName); //当前目录上3层目录
            IEnumerable<String> files = Directory.EnumerateFiles(path, fileName, SearchOption.AllDirectories);

            return files;
        }

    }

}