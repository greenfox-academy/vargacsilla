﻿using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            int[] p1 = new int[3] { 1, 2, 3 };
            int[] p2 = new int[2] { 4, 5};
            Console.WriteLine("Is p2 longer than p1?");
            Console.WriteLine(p1.Length < p2.Length);
            Console.ReadLine();
        }
    }
}
