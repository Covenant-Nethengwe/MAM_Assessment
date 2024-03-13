using System;
using System.Collections.Generic;

namespace MAM_Assessment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Product> products1 = new List<Product>
            {
                new Book(12.49, "Book at:", 1),
                new Entertainment(14.99, "Music CD at:", 1),
                new Food(0.85, "Chocolate bar at:", 1),

            };

            List<Product> products2 = new List<Product>
            {
                new Food(10.00, "Imported box of chocolates at:", 1),
                new Cosmetics(47.50, "Imported bottle of perfume at:", 1),
            };

            List<Product> product3 = new List<Product>
            {
                new Cosmetics(27.99, "Imported bottle of perfume at:", 1),
                new Cosmetics(18.99, "Bottle of perfume at:", 1),
                new Madical(9.75, "Packet of paracetamol at:", 1),
                new Food(11.25, "Box of imported chocolates at:", 1),
            };

            Product p = new Product();

            Console.WriteLine("=============================================");
            Console.WriteLine("Output 1:");
            p.DisplayProducts(products1);
            Console.WriteLine("=============================================");

            Console.WriteLine();

            Console.WriteLine("=============================================");
            Console.WriteLine("Output 2:");
            p.DisplayProducts(products2);
            Console.WriteLine("=============================================");

            Console.WriteLine();

            Console.WriteLine("=============================================");
            Console.WriteLine("Output 3");
            p.DisplayProducts(product3);
            Console.WriteLine("=============================================");

            Console.ReadKey();
        }
    }
}
