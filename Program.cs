using System.Drawing;
using System;
using System.Collections.Generic;
using Entities;

namespace lambda1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            list.Add(new Product("Celular", 1050.00));

            Comparison<Product> comp = CompareProducts;

            list.Sort(comp); // isso é um delegate com base numa sobrecarga do metodo sort

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
