﻿
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
            string filePath = @"C:\Users\opilane\samples\files.txt";
            string directoryPath = @"C:\Users\opilane\samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            File.WriteAllLines(filePath, files);
        }
    }
}
