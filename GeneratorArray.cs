using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class GeneratorArray
    {
        private Random _random = new Random();

        public int[] Generate(int size, int maxValue, int minValue)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = _random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        public double[] Generate(int size, double maxValue, double minValue)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = _random.NextDouble();
            }
            return array;
        }
    }
}
