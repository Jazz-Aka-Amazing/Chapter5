using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[8];
            for (int i = 0; i < grades.Length; i++)
            {
                Array.Sort(grades);
                Array.Reverse(grades);                      
                Console.WriteLine(grades.Length);

            }
        }
    }
}
