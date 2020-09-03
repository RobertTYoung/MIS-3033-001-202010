using System;
using System.Dynamic;
using System.IO;

namespace ReadingFilesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Carol\Downloads\Pride and Prejudice by Jane Austen (1).txt";

            //string entireBook = File.ReadAllText(filePath);
            string[] allLines = File.ReadAllLines(filePath);

            //Output 5 lines of the book at a time
            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(allLines);
            //}

            //Output a Chapter at a time
            foreach (var line in allLines)
            {
                if (line.ToLower().Contains("chapter") == true)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
            }




        }
    }
}
