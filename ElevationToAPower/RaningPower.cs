using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ElevationToAPower
{
    internal class RaningPower
    {
        public RaningPower()
        {
            Runing().Wait();
        }
        private async Task Runing()
        {
            Task.Run(() =>
            {
                StandardPower<int> standardPower = new StandardPower<int>();
                int a = 2;
                int n = 3;
                Console.WriteLine($"Standard Power: {a} raised to the power of {n} is {standardPower.Pow(a, n)}");


            }).Wait();
        }
    }
}
