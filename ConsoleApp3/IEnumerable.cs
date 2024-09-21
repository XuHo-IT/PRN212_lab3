﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }

    public class MyCollection<T> : IEnumerable<T> where T : class, new()
    {
        private List<T> myList = new List<T>();
        public void AddItem(params T[] items) => myList.AddRange(items);
        public IEnumerator<T> GetEnumerator() => myList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => myList.GetEnumerator();
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Person> collection = new MyCollection<Person>();
            var p1 = new Person { FirstName = "David", LastName = "Simpson", Age = 50 };
            var p2 = new Person { FirstName = "Marge", LastName = "Simpson", Age = 50 };
            var p3 = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 50 };
            var p4 = new Person { FirstName = "Jack", LastName = "Simpson", Age = 50 };
            collection.AddItem(p1, p2, p3, p4);

            foreach (var p in collection)
            {
                Console.WriteLine(p);
            }
        }
    }
}
