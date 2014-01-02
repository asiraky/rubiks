using System;

namespace Rubiks
{
    public class Position
    {
        public Position(Colour coordinate)
        {
            Coordinate = coordinate;
            InstanceId = Guid.NewGuid();
        }

        public Colour Coordinate { get; set; }

        public Piece Piece { get; set; }

        public Guid InstanceId { get; private set; }
    }
}