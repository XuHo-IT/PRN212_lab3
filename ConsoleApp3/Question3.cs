using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Question3
    {

        class Program
        {
            static void Main()
            {
                Hashtable daysOfWeek = new Hashtable();
                daysOfWeek.Add(1, "Monday");
                daysOfWeek.Add(2, "Tuesday");

                if (daysOfWeek.ContainsKey(2))
                {
                    Console.WriteLine("Tuesday is found.");
                }
                else
                {
                    Console.WriteLine("Tuesday is not found.");
                }

                foreach (DictionaryEntry entry in daysOfWeek)
                {
                    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                }
            }
        }
    }
}
