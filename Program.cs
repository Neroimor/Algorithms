// See https://aka.ms/new-console-template for more information
using Algorithm;
using Algorithm.Multiplication;
using Algorithm.Sorting;
using System.Diagnostics;


Task.Run(() =>
{
    SchoolMultiplication schoolMultiplication = new SchoolMultiplication();
    string a = "5678";
    string b = "1234";
    schoolMultiplication.Multiply(a, b);

}).Wait();