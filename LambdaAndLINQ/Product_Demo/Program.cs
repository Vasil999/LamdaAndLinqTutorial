using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> shoppingCard = new List<Product>()
            {
                new Product { Name = "Orange", Price = 3.99m, Qty = 3 },
                new Product { Name = "Tomato", Price = 3.49m, Qty = 2 },
                new Product { Name = "Cucamber", Price = 3.29m, Qty = 2.5 },
                new Product { Name = "Apple", Price = 4.99m, Qty = 1.4 },
                new Product { Name = "Kiwi", Price = 5.39m, Qty = 4 },
                new Product { Name = "Banana", Price = 6.29m, Qty = 5.1 },
                new Product { Name = "Milk", Price = 1.99m, Qty = 6 },
                new Product { Name = "Cheese", Price = 2.49m, Qty = 1 },
            };

            string promo = "Promotion";
            string nopromo = " NO Promotion";

            Console.WriteLine(
                shoppingCard.Any(p=>p.Name=="Tomato" && p.Qty >2) ? promo : nopromo
                );
            
            Console.WriteLine(string.Join(", ", 
                shoppingCard
                .Where(p=>p.Name != "Milk")
                .Select(p=>p.Name)));

            Console.WriteLine(string.Join(", ",
                shoppingCard
                .Take(5)
                .Select(p => p.Name)));

            Console.WriteLine(string.Join(", ",
                shoppingCard
                .Skip(5)
                .Select(p => p.Name)));

            Console.WriteLine(shoppingCard.FirstOrDefault().Name);
            
            Console.WriteLine(shoppingCard
                .Where(p => p.Price == shoppingCard.Max(p => p.Price))
                .FirstOrDefault().Name);
            
            Console.WriteLine(shoppingCard
                .ElementAt(2).Name);

            Console.WriteLine(shoppingCard
                .Average(p => p.Price*(decimal)p.Qty));



        }
    }
}
