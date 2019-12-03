using Day_3.Geometry;
using System;
using System.IO;
using System.Linq;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var SplitContent = GetFileContents("../../../input.txt").Split(Environment.NewLine);
            var WireOne = new Wire(SplitContent[0].Split(','));
            var WireTwo = new Wire(SplitContent[1].Split(','));
            var AllPoints = WireOne.AllPoints.Concat(WireTwo.AllPoints).OrderBy(p => p.X).ThenBy(p => p.Y);
            
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
