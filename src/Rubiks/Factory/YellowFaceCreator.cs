using System.Collections.Generic;

namespace Rubiks.Factory
{
    class YellowFaceCreator : FaceCreator
    {
        public YellowFaceCreator()
            : base(Colour.Yellow)
        {
        }

        protected override IEnumerable<Colour> GetCoordinates
        {
            get
            {
                yield return faceColour | Colour.Blue | Colour.Red;
                yield return faceColour | Colour.Red;
                yield return faceColour | Colour.Red | Colour.Green;
                yield return faceColour | Colour.Green;
                yield return faceColour | Colour.Green | Colour.Orange;
                yield return faceColour | Colour.Orange;
                yield return faceColour | Colour.Orange | Colour.Blue;
                yield return faceColour | Colour.Blue;
            }
        }
    }
}