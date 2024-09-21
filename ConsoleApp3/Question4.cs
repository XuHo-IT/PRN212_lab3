using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Question4
    {
        class GenericSwap<T>
        {
            public static void Swap(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }

        class Program
        {
            static void Main()
            {
                int x = 5, y = 10;
                GenericSwap<int>.Swap(ref x, ref y);
                Console.WriteLine($"x: {x}, y: {y}");

                string str1 = "Hello", str2 = "World";
                GenericSwap<string>.Swap(ref str1, ref str2);
                Console.WriteLine($"str1: {str1}, str2: {str2}");
            }
        }
    }
}
