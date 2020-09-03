using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ReadingFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Owner\Downloads\Pride and Prejudice by Jane Austen.txt";

            //string entireBook = File.ReadAllText(filePath);
            string[] allLines = File.ReadAllLines (filePath);

            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (i % 5 == 0 && i !=0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(allLines[i]);
            foreach (var line in allLines)
            {
                if(line.ToLower().Contains("chapter") == true)
                {
                    Console.ReadLine();
                }
                Console.WriteLine(line);
            }
            


        }
    }
}
