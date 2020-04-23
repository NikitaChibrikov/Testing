using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    public class Program
    {
        public static bool TriangleExeption (int a, int b, int c)
        {
            if (a+b>c && a+c>b && c+b>a && a>=0 && b>=0 && c >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Unit-testing in C#.");
        }
    }
}
