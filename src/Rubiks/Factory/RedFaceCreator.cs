using System.Collections.Generic;

namespace Rubiks.Factory
{
    class RedFaceCreator : FaceCreator
    {
        public RedFaceCreator()
            : base(Colour.Red)
        {
        }

        protected override IEnumerable<Colour> GetCoordinates
        {
            get
            {
                yield return faceColour | Colour.Blue | Colour.White;
                yield return faceColour | Colour.Blue;
                yield return faceColour | Colour.Blue | Colour.Yellow;
                yield return faceColour | Colour.Yellow;
                yield return faceColour | Colour.Yellow | Colour.Green;
                yield return faceColour | Colour.Green;
                yield return faceColour | Colour.Green | Colour.White;
                yield return faceColour | Colour.White;
            }
        }
    }
}