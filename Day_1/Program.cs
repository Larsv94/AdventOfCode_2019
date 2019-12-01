using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionOne = GetFileContent("input.txt").Select(decimal.Parse).Select(processMass).Sum();
            System.Console.WriteLine($"The total fuel for the modules is {solutionOne}");//3315383
            var solutionTwo = GetFileContent("input.txt").Select(decimal.Parse).Select(processMassIncludingFuel).Sum();
            System.Console.WriteLine($"The total fuel for the modules including the fuel itself {solutionTwo}");//4970206
        }

        public static IEnumerable<string> GetFileContent(string path)
        {
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        public static decimal processMass(decimal value) => Math.Floor(value / 3m) - 2;

        public static decimal processMassIncludingFuel(decimal value)
        {
            decimal fuel = processMass(value);
            return fuel <= 0 ? 0 : fuel + processMassIncludingFuel(fuel);
        }
    }
}
