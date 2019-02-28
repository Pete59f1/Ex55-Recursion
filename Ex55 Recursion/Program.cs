using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex55_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fakultet(6));
            Console.WriteLine(Fakultet(0));
            Console.Write("\n");

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.Write("\n");

            Console.WriteLine("Skriv en palindrom");
            Console.WriteLine(IsPalindrom(Console.ReadLine().ToLower()));
        }

        public static int Fakultet(int n)
        {
            int res = 1;
            if (n < 2)
            {
                return res;
            }
            else
            {
                return n * Fakultet(n - 1);
            }
        }

        public static int Fibonacci(int n)
        {
            if (n.Equals(0))
            {
                return 0;
            }
            else if (n.Equals(1))
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static bool IsPalindrom(string text)
        {
            text = string.Concat(text.Where(c => !char.IsWhiteSpace(c)));
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (!text[0].Equals(text[text.Length - 1]))
                {
                    return false;
                }
                else
                {
                    return IsPalindrom(text.Substring(1, text.Length - 2));
                }
            }
        }
    }
}
