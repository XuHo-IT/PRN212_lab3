using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Question1
    {
        class GenericCalculator<T>
        {
            public static T Add(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                return da + db;
            }

            public static T Subtract(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                return da - db;
            }

            public static T Multiply(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                return da * db;
            }

            public static T Divide(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                return da / db;
            }
        }

        class Program
        {
            static void Main()
            {
                int intResult = GenericCalculator<int>.Add(1, 2);
                double doubleResult = GenericCalculator<double>.Divide(1.0, 2.0);
                string stringResult = GenericCalculator<string>.Add("Hello", " world");

                Console.WriteLine("intResult: " + intResult);
                Console.WriteLine("doubleResult: " + doubleResult);
                Console.WriteLine("stringResult: " + stringResult);
            }
        }
    }
}
