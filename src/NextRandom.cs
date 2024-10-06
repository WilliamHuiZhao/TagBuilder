using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagBuilder
{
    public static class NextRandom
    {
        private static Random random = new Random();
        public static float NextRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
        public static int NextRandomInteger(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
