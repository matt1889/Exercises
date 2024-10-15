using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week2
    {
        public static void Exercise1() //method
        {
            Console.Write("Input a number : "); //delcare
            int n;
            n = Convert.ToInt32(Console.ReadLine());//assign
            int r = n % 2;
            if (r == 0)
            { Console.Write("Even "); }
            else
            { Console.Write("Odd "); }
        }
    }
}
