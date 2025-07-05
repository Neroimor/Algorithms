using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Multiplication
{
    internal class SchoolMultiplication : IMultiplication
    {
        public string Multiply(string a, string b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException(nameof(a));
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                throw new ArgumentNullException(nameof(a));

            return Procces(a, b);

        }

        private string Procces(string a, string b)
        {
            char[] oneMultiplier = a.ToCharArray();
            char[] twoMultiplier = b.ToCharArray();
            string[] arrIntermediate = new string[twoMultiplier.Length];

            for (int i = twoMultiplier.Length - 1; i > -1; i--)
            {
                int temp = 0;
                int value = twoMultiplier[i];

                StringBuilder stringBuilder = new StringBuilder();
                for (int j = oneMultiplier.Length - 1; j > -1; j--)
                {
                    int crosA = int.Parse(oneMultiplier[j].ToString());
                    int crosB = int.Parse(twoMultiplier[i].ToString());
                    int cros = (crosA * crosB) + temp;

                    string crosValue = cros.ToString();
                    char[] chars = crosValue.ToCharArray();

                    if (j == 0)
                    {
                        Array.Reverse(chars);
                        string IntermediateValue = new string(chars);

                        stringBuilder.Append(IntermediateValue);
                    }
                    else if (chars.Length > 1)
                    {
                        temp = int.Parse(chars[0].ToString());
                        stringBuilder.Append(chars[1]);
                    }
                    else
                    {
                        temp = 0;
                        stringBuilder.Append(chars[0]);
                    }


                }


                char[] tempres = stringBuilder.ToString().ToCharArray();
                Array.Reverse(tempres);
                arrIntermediate[i] = new string(tempres);
            }

            StringBuilder result = new StringBuilder();
            string sum = string.Empty;

            Array.Reverse(arrIntermediate);

            int count = 1;

            if (arrIntermediate.Length<2)
            {
                return arrIntermediate[0];
            }
            int max = arrIntermediate[0].Length;
            for (int i = 1; i < arrIntermediate.Length; i++)
            {
              
                for (int j = 0; j < count; j++)
                {
                    arrIntermediate[i]=arrIntermediate[i]+ " ";
                }
                if (arrIntermediate[i].Length > arrIntermediate[i-1].Length)
                {
                    max = arrIntermediate[i].Length;
                }
                count++;
            }

            char[,] matrix = new char[max, max];

            for (int i = 0; i < arrIntermediate.Length; i++)
            {
                char[] temp = arrIntermediate[i].ToCharArray();
                int delta = max - temp.Length;
                for (int j = delta; j < max; j++)
                {
                    matrix[i, j] = temp[j-delta];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }


            return SumColumns(matrix);
        }

        string SumColumns(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var resultDigits = new List<char>();
            int carry = 0;


            for (int j = cols - 1; j >= 0; j--)
            {
                int columnSum = carry;
                for (int i = 0; i < rows; i++)
                {
                    char c = matrix[i, j];
                    if (c >= '0' && c <= '9')
                    {
                        columnSum += c - '0';
                    }
                }

                int digit = columnSum % 10;
                carry = columnSum / 10;
                resultDigits.Add((char)('0' + digit));
            }

   
            while (carry > 0)
            {
                resultDigits.Add((char)('0' + (carry % 10)));
                carry /= 10;
            }

  
            resultDigits.Reverse();
            return new string(resultDigits.ToArray());
        }
    }
}
