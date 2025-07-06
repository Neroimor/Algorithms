using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Multiplication
{
    internal class Karatsuba : IMultiplication
    {
        public string Multiply(string a, string b)
        {
            return KaratsubaCross(int.Parse(a),int.Parse(b)).ToString();
        }

        private int KaratsubaCross(int x, int y)
        {
            if (x < 10 || y < 10)
                return x * y;

            int n1 = x.ToString().Length, n2 = y.ToString().Length;
            int n = Math.Max(n1, n2);
            if (n % 2 != 0) n++;
            int half = n / 2;


            string value1 = x.ToString().PadLeft(n, '0');
            string value2 = y.ToString().PadLeft(n, '0');
            string tempA = value1.Substring(0, half);
            string tempB = value1.Substring(half);
            string tempC = value2.Substring(0, half);
            string tempD = value2.Substring(half);
    


            int a = int.Parse(tempA);
            int b = int.Parse(tempB);
            int c = int.Parse(tempC);
            int d = int.Parse(tempD);
            int p = a + b;
            int q = c+d;
            int pq = KaratsubaCross(p, q);
            int ac = KaratsubaCross(a, c);
            int bd = KaratsubaCross(b, d);
            int adbc = pq-ac-bd;




            return (int)Math.Pow(10,n)*ac+(int)Math.Pow(10,n/2)*adbc+bd;
        }
    }
}
