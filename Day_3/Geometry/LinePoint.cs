using System.Collections.Generic;

namespace Day_3.Geometry
{
    public class LinePoint
    {
        public static Dictionary<char, LinePoint> Direction = new Dictionary<char, LinePoint>() {
            {'U',new LinePoint(0,1)},
            {'D',new LinePoint(0,-1)},
            {'R',new LinePoint(1,0)},
            {'L',new LinePoint(-1,0)}
        };
        public int X { get; set; }
        public int Y { get; set; }
        public Segment ParentSegment { get; set; }
        public LinePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        
        public static LinePoint operator + (LinePoint p1, LinePoint p2)
        {
            return new LinePoint(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static LinePoint operator *(LinePoint vector, int distance)
        {
            return new LinePoint(vector.X * distance, vector.Y * distance);
        }
    }
}