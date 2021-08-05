using System.Collections.Generic;

namespace GalaxyLibrary
{
    public class Sector
    {
        public string Name { get; init; }
        public TwoDimensionalGridPosition Position { get; init; }
        public List<StarSystem> Systems { get; set; }
    }
}