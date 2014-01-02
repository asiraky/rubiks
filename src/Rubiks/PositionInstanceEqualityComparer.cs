using System.Collections.Generic;

namespace Rubiks
{
    public class PositionInstanceEqualityComparer : IEqualityComparer<Position>
    {
        private static readonly IEqualityComparer<Position> instance = new PositionInstanceEqualityComparer();

        public static IEqualityComparer<Position> Instance
        {
            get { return instance; }
        }

        private PositionInstanceEqualityComparer()
        {
        }

        public bool Equals(Position x, Position y)
        {
            return x.InstanceId.Equals(y.InstanceId);
        }

        public int GetHashCode(Position obj)
        {
            return obj.GetHashCode();
        }
    }
}