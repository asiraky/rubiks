using System.Collections.Generic;
using Rubiks.Factory;

namespace Rubiks
{
    public class Cube
    {
        public Cube()
        {
            Faces = new FaceFactory().CreateInstances();
        }

        public IEnumerable<Face> Faces { get; set; }
    }
}