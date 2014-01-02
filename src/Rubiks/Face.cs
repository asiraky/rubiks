using System.Collections.Generic;

namespace Rubiks
{
    public class Face
    {
        public Face(Colour centreColour)
        {
            CentreColour = centreColour;
            Positions = new List<Position>(8);
        }

        public Colour CentreColour { get; set; }

        public List<Position> Positions { get; set; }

        //TODO
        public Face[] AdjacentFaces { get; set; }

        public void RotateClockwise()
        {
            Positions[0].Piece = Positions[6].Piece;
            Positions[1].Piece = Positions[7].Piece;

            for (var i = 0; i < Positions.Count; i++)
            {
                if (i > 2)
                    Positions[i].Piece = Positions[i - 2].Piece;
            }

            foreach (var face in AdjacentFaces)
            {
                foreach (var pos in face.Positions)
                {
                    if (pos.Coordinate.HasFlag(CentreColour))
                    {
                        // subtract by two, but keep on same face
                    }
                    else
                    {

                    }
                }
            }
        }

        public void RotateCounterClockwise()
        {
            Positions[6].Piece = Positions[0].Piece;
            Positions[7].Piece = Positions[1].Piece;

            for (var i = 0; i < Positions.Count; i++)
            {
                if (i < 6)
                    Positions[i].Piece = Positions[i + 2].Piece;
            }
        }
    }
}