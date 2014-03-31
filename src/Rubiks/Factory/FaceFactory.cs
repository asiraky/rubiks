using System.Collections.Generic;
using System.Linq;

namespace Rubiks.Factory
{
    class FaceFactory : List<FaceCreator>
    {
        private static Dictionary<Colour, Position> coordinatesCache;

        public FaceFactory()
        {
            coordinatesCache = new Dictionary<Colour, Position>(20);

            Add(new WhiteFaceCreator());
            Add(new RedFaceCreator());
            Add(new YellowFaceCreator());
            Add(new BlueFaceCreator());
            Add(new GreenFaceCreator());
            Add(new OrangeFaceCreator());
        }

        public static Dictionary<Colour, Position> CoordinatesCache
        {
            get { return coordinatesCache; }
        }

        public IEnumerable<Face> CreateInstances()
        {
            return from creator in this
                   select creator.CreateInstance();
        }
    }
}