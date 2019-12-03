namespace Day_3.Geometry
{
    public class Segment
    {
        public LinePoint Start { get; private set; }
        public LinePoint End { get; private set; }
        public Wire ParentWire { get; private set; }
        
        public LinePoint[] Points
        {
            get => new LinePoint[] { Start, End };
        }

        public Segment SetParent(Wire parent)
        {
            ParentWire = parent;
            return this;
        }

        public Segment(char direction, int distance, LinePoint origin)
        {
            Start = origin;
            End = origin + (LinePoint.Direction[direction] * distance);
            Start.ParentSegment = End.ParentSegment = this;
        }
    }
}