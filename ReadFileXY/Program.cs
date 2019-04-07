using System;
using System.IO;


namespace ReadFileXY
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("test.txt");

            string[] array = lines[2].Split(",");

            string result = array[5];

            Console.WriteLine(result);
        }
    }
}
