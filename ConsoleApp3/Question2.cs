using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Question2
    {

        class Product
        {
            public string Name { get; set; }
            public double Cost { get; set; }
            public int Quantity { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Cost: {Cost}, Quantity: {Quantity}";
            }
        }

        class Program
        {
            static void Main()
            {
                ArrayList products = new ArrayList();
                products.Add(new Product { Name = "Product 1", Cost = 10.0, Quantity = 5 });
                products.Add(new Product { Name = "Product 2", Cost = 20.0, Quantity = 3 });
         

                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
