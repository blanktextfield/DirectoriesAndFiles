using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePaths();


        }

        public static void WriteFilePaths()
        {
            string filepath = @"C:\Users\mammu\samples\files.txt";
            string directoryPath = @"C:\Users\mammu\samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filepath, files);
        }
    }
}
