using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    public class Program
    {
        public static bool TriangleExeption (int sideA, int sideB, int sideC)
        {
            if (sideA+ sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA && sideA >= 0 && sideB >= 0 && sideC >= 0)
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
