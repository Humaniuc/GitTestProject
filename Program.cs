using System;
using System.Collections.Generic;

namespace GitLearnTestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 1, 8, 6, 7, 3, 6, 5 };
            ints.Sort();
            foreach (var item in ints)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}
