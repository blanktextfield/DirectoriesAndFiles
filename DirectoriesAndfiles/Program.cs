using System;
using System.IO;

namespace DirectoriesAndfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\mammu\samples";
            string[] allDirectories = Directory.GetDirectories(rootPath);
            //ReadArray(allDirectories);

            string[] includeNestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            //ReadArray(includeNestedDirectories);
            string[] files = Directory.GetFiles(rootPath, "*.*",SearchOption.AllDirectories);
            ReadArray(files);



        }

        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
              Console.WriteLine(line);

            }
            
        }
    }
}
