namespace Rubiks
{
    public abstract class Piece
    {
    }

    public class CornerPiece : Piece
    {
        public CornerPiece(Colour aFace, Colour bFace, Colour cFace)
        {
            AFace = aFace;
            BFace = bFace;
            CFace = cFace;
        }

        public Colour AFace { get; set; }
        public Colour BFace { get; set; }
        public Colour CFace { get; set; }
    }

    public class EdgePiece : Piece
    {
        public EdgePiece(Colour dFace, Colour eFace)
        {
            DFace = dFace;
            EFace = eFace;
        }

        public Colour DFace { get; set; }
        public Colour EFace { get; set; }
    }
}