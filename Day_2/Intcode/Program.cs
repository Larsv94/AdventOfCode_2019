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
            input1[1]=12;
            input1[2]=2;
        }

        static string GetFileContents(string filePath){
            using (StreamReader file = new StreamReader(filePath))
            {
                return file.ReadToEnd();
            }
        }
    }
}
