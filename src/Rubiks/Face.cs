using System.Collections.Generic;

namespace Rubiks
{
    public class Face
    {
        private readonly Colour centreColour;
        private readonly List<Position> positions;

        public Face(Colour centreColour)
        {
            this.centreColour = centreColour;
            positions = new List<Position>(8);
        }

        public Colour CentreColour
        {
            get { return centreColour; }
        }

        public List<Position> Positions
        {
            get { return positions; }
        }

        public void RotateClockwise()
        {
            var count = positions.Count;
            
            positions[0].Piece = positions[6].Piece;
            positions[1].Piece = positions[7].Piece;
            
            for (var i = 0; i < count; i++)
            {
                if (i > 2)
                    positions[i].Piece = positions[i - 2].Piece;
            }
        }

        public void RotateCounterClockwise()
        {
            var count = positions.Count;

            positions[6].Piece = positions[0].Piece;
            positions[7].Piece = positions[1].Piece;

            for (var i = 0; i < count; i++)
            {
                if (i < 6)
                    positions[i].Piece = positions[i + 2].Piece;
            }
        }
    }
}