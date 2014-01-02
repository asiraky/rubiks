using System;

namespace Rubiks
{
    [Flags]
    public enum Colour
    {
        White = 1,
        Blue = 2,
        Orange = 4,
        Yellow = 8,
        Green = 16,
        Red = 32
    }
}