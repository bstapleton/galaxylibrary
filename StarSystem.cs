using System.Numerics;

namespace GalaxyLibrary
{
    public class StarSystem
    {
        public string Name { get; init; }
        public ThreeDimensionalGridPosition Position { get; init; }
        public char Type { get; init; }
        public double Temperature { get; init; }
    }
}