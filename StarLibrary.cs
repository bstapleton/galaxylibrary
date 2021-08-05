using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GalaxyLibrary
{
    public static class StarLibrary
    {
        /**
         * Returns the heat scale of a star from 0.0 to 9.9
         */
        public static double HeatScale()
        {
            Random r = new Random();
            return Math.Round(((double)r.NextDouble() * 10), 1);
        }

        /**
         * Returns the class of star in a single-star system based on real-world probability
         */
        public static char Class()
        {
            Random r = new Random();
            int systemProbability = r.Next(0, 10000000);

            return systemProbability switch
            {
                < 3 => 'O',
                < 13000 => 'B',
                < 60000 => 'A',
                < 300000 => 'F',
                < 760000 => 'G',
                < 1210000 => 'K',
                _ => 'M'
            };
        }
        
        /**
         * Greek alphabet
         */
        private static readonly Collection<string> GreekAlphabet = new Collection<string>(
            new string[]
            {
                "Alpha",
                "Beta",
                "Gamma",
                "Delta",
                "Epsilon",
                "Zeta",
                "Eta",
                "Theta",
                "Iota",
                "Kappa",
                "Lambda",
                "Mu",
                "Nu",
                "Xi",
                "Omicron",
                "Pi",
                "Rho",
                "Sigma",
                "Tau",
                "Upsilon",
                "Phi",
                "Chi",
                "Psi",
                "Omega"
            }
        );
        
        /**
         * Bayer designation for star system naming, utilising Greek alphabet, then uppercase English alphabet
         * characters, and finally lowercase English alphabet characters.
         */
        public static IList<string> BayerDesignationList()
        {
            Collection<string> designationList = new Collection<string>();
            
            foreach (string s in GreekAlphabet)
            {
                designationList.Add(s);
            }

            
            for (int i = 0; i < 2; i++)
            {
                char[] alphabet = Enumerable.Range(i == 0 ? 'A' : 'a', 26).Select(x => (char)x).ToArray();

                foreach (char c in alphabet)
                {
                    designationList.Add(c.ToString());
                }
            }

            return designationList;
        }
    }
}