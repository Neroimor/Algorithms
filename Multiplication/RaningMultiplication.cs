using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Multiplication
{
    internal class RaningMultiplication
    {

        public RaningMultiplication()
        {
            Runing().Wait();
        }
        private async Task Runing()
        {


            Task.Run(() =>
            {
                SchoolMultiplication schoolMultiplication = new SchoolMultiplication();
                string a = "5678";
                string b = "1234";
                Console.WriteLine(schoolMultiplication.Multiply(a, b));

            }).Wait();



            Task.Run(() =>
            {
                Karatsuba schoolMultiplication = new Karatsuba();
                string a = "5678";
                string b = "1234";
                Console.WriteLine(schoolMultiplication.Multiply(a, b));

            }).Wait();

        }
    }
}
