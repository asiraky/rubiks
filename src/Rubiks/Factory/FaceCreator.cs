using System;
using System.Collections.Generic;
using System.Linq;

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

                existingPosition.Piece = GetPieceFor(coordinate);
                face.Positions.Add(existingPosition);
            }

            return face;
        }

        private static Piece GetPieceFor(Colour coordinate)
        {
            var numberOfSetBits = NumberOfSetBits((int)coordinate);

            //switch (numberOfSetBits)
            //{
            //    case 2:
            //        return 
            //    case 3:
            //}

            return new CornerPiece(Colour.White, Colour.Red, Colour.Blue);
        }

        private static int NumberOfSetBits(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }

        protected abstract IEnumerable<Colour> GetCoordinates { get; }
    }

    public static class EnumExtensions
    {
        public static IEnumerable<Enum> EnumerateSetValues(this Enum value)
        {
            return GetFlags(value, GetFlagValues(value.GetType()).ToArray());
        }

        private static IEnumerable<Enum> GetFlags(Enum value, IList<Enum> values)
        {
            var bits = Convert.ToUInt32(value);
            var results = new List<Enum>();

            for (var i = values.Count - 1; i >= 0; i--)
            {
                var mask = Convert.ToUInt32(values[i]);

                if (i == 0 && mask == 0)
                    break;

                if ((bits & mask) != mask)
                    continue;

                results.Add(values[i]);
                bits -= mask;
            }

            if (bits != 0)
                return Enumerable.Empty<Enum>();

            if (Convert.ToUInt32(value) != 0)
                return results.Reverse<Enum>();

            if (bits == Convert.ToUInt32(value) && values.Count > 0 && Convert.ToUInt32(values[0]) == 0)
                return values.Take(1);

            return Enumerable.Empty<Enum>();
        }

        private static IEnumerable<Enum> GetFlagValues(Type enumType)
        {
            var maxLength = Enum.GetValues(enumType).Length;

            if (maxLength % 2 != 0)
                throw new ArgumentException("Only flag values that are divisors of 2 are supported");

            uint flag = 1;

            for (var i = 1; i <= maxLength; i *= 2)
            {
                
            }

            foreach (var value in Enum.GetValues(enumType).Cast<Enum>())
            {
                var bits = Convert.ToUInt32(value);

                if (bits == 0)
                    continue;

                while (flag < bits)
                    flag <<= 1;

                if (flag == bits)
                    yield return value;
            }
        }
    }
}