using System.Collections.Generic;

namespace Rubiks.Factory
{
    abstract class FaceCreator
    {
        protected readonly Colour faceColour;

        protected FaceCreator(Colour faceColour)
        {
            this.faceColour = faceColour;
        }

        public Face CreateInstance()
        {
            var face = new Face(faceColour);

            foreach (var coordinate in GetCoordinates)
            {
                Position existingPosition;

                if (!FaceFactory.CoordinatesCache.TryGetValue(coordinate, out existingPosition))
                    FaceFactory.CoordinatesCache[coordinate] = existingPosition = new Position(coordinate);

                face.Positions.Add(existingPosition);
            }

            return face;
        }

        protected abstract IEnumerable<Colour> GetCoordinates { get; }
    }
}