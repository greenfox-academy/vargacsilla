﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "AXxBXxCXx";
            Console.WriteLine(SwapXToY(s));
            Console.ReadLine();
        }

        private static string SwapXToY(string s)
        {
            if (s.Length == 0)
                return s;
            else if (s[0] == 'x')
            {
                return s = "y" + SwapXToY(s.Substring(1));
            }
            else
                return s = s[0] + SwapXToY(s.Substring(1));

        }
    }
}
