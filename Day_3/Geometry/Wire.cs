using System.Linq;
using System.Collections.Generic;

namespace Day_3.Geometry
{
    public class Wire
    {
        public List<Segment> Segments = new List<Segment>();
        public IEnumerable<LinePoint> AllPoints
        {
            get => Segments.Select(p => p.Points).SelectMany(x => x);
        }
        public Wire(string[] pathInstructions){
            foreach (var inst in pathInstructions)
            {
                Segments.Add(CreateSegment(inst).SetParent(this));
            }
        }

        private Segment CreateSegment(string instruction)
        {
            var origin = Segments.Count >0 ? Segments[^1].End : new LinePoint(0, 0);
            char dir = instruction[0];
            int distance = int.Parse(instruction[1..]);
            return new Segment(dir, distance, origin);
        }
    }
}