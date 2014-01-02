using System.Collections.Generic;

namespace Rubiks.Factory
{
    class BlueFaceCreator : FaceCreator
    {
        public BlueFaceCreator()
            : base(Colour.Blue)
        {
        }

        protected override IEnumerable<Colour> GetCoordinates
        {
            get
            {
                yield return faceColour | Colour.Orange | Colour.White;
                yield return faceColour | Colour.Orange;
                yield return faceColour | Colour.Orange | Colour.Yellow;
                yield return faceColour | Colour.Yellow;
                yield return faceColour | Colour.Yellow | Colour.Red;
                yield return faceColour | Colour.Red;
                yield return faceColour | Colour.Red | Colour.White;
                yield return faceColour | Colour.White;
            }
        }
    }
}