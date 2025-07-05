using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Multiplication
{
    internal class SchoolMultiplication : IMultiplication
    {
        public int Multiply(string a, string b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException(nameof(a));
            if(string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                throw new ArgumentNullException(nameof(a));

            return Procces(a, b);

            throw new NotImplementedException();
        }

        private int Procces(string a, string b)
        {
            char[] oneMultiplier = a.ToCharArray();
            char[] twoMultiplier = b.ToCharArray();

            for (int i = 0; i < oneMultiplier.Length; i++)
            {

            }


            return 0;
        }
    }
}
