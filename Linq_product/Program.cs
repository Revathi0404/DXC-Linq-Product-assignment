using System;
using System.Collections.Generic;
using System.Linq;


namespace Linq_product
{
    class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>();

          
            SeedData(productList);

            
            var productNamesBetween20kAnd40k = productList
                .Where(p => p.Price >= 20000 && p.Price <= 40000)
                .Select(p => p.ProductName);
            Console.WriteLine("Product names where Price is between 20000 to 40000:");
            foreach (var productName in productNamesBetween20kAnd40k)
            {
                Console.WriteLine(productName);
            }

          
            var productsWithNameContainingA = productList
                .Where(p => p.ProductName.Contains("a"));
            Console.WriteLine("\nProducts where ProductName contains letter a:");
            foreach (var product in productsWithNameContainingA)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, Brand: {product.Brand}, Quantity: {product.Quantity}, Price: {product.Price}");
            }

          
            var productsSortedByName = productList
                .OrderBy(p => p.ProductName);
            Console.WriteLine("\nAll products sorted by name:");
            foreach (var product in productsSortedByName)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}, Brand: {product.Brand}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
            
            var highestPrice = productList
                .Max(p => p.Price);
            Console.WriteLine($"\nHighest price: {highestPrice}");

         
            var productWithP003Exists = productList
                .Any(p => p.ProductId == "P003");
            Console.WriteLine($"\nProduct with ProductId P003 exists: {productWithP003Exists}");
        }

        static void SeedData(List<Product> productList)
        {
            productList.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            productList.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            productList.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            productList.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            productList.Add(new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 });
        }
    }

    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
