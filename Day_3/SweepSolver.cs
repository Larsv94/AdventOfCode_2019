using Day_3.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_3
{
    class SweepSolver
    {
        public IEnumerable<LinePoint> AllLinePoints { get; set; }
        public SweepSolver(IEnumerable<LinePoint> WireOne, IEnumerable<LinePoint> WireTwo)
        {
            WireOne = Prune(WireOne, WireTwo);
        }

        private IEnumerable<LinePoint> Prune(IEnumerable<LinePoint> original, IEnumerable<LinePoint> constraint)
        {
            (int maxX, int maxY) = (constraint.Max(p => p.X), constraint.Max(p => p.Y));
            (int minX, int minY) = (constraint.Min(p => p.X), constraint.Min(p => p.Y));
            return original.Where(p => p.X <= maxX && p.X >= minX).Where(p => p.Y <= maxY && p.Y >= minY);
        }
    }
}
