using System.Linq;
using System.IO;
using System;

namespace Intcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = GetFileContents("../input.txt").Split(',').Select(int.Parse).ToArray();
            Computer computer = new Computer(input1);
            (int noun, int verb) = computer.Attempt(1, 100, 19690720);
            System.Console.WriteLine(noun);
            System.Console.WriteLine(verb);
            System.Console.WriteLine(100 * noun + verb);
        }

        static string GetFileContents(string filePath)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                return file.ReadToEnd();
            }
        }
    }
}
