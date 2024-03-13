using System;
using System.Collections.Generic;

namespace MAM_Assessment
{
    public class Product : IProduct
    {
        private readonly int tax = 10;
        private readonly int importTax = 5;

        decimal price;
        int quantity;
        string description;

        decimal Price { get => price; set => price = value; }
        string Description { get => description; set => description = value; }
        int Quantity { get => quantity; set => quantity = value; }

        public Product(decimal price, string description, int quantity)
        {
            Price = price;
            Description = description;
            Quantity = quantity;
        }

        public Product()
        {

        }

        /// <summary>
        /// Calculates tax on goods that are NOT type Book, Food or Madical
        /// </summary>
        /// <returns>The total tax.</returns>
        /// <param name="price">Price.</param>
        public decimal CalculateTotalTax(decimal price)
        {
            decimal totalTax = 0;

            decimal taxValue = (price * tax) / 100;
            decimal roundOff = taxValue / (decimal)0.05;
            decimal wholeNumber = (decimal)Math.Round((decimal)roundOff, MidpointRounding.AwayFromZero);

            totalTax = wholeNumber * (decimal)0.05;


            return totalTax;
        }

        /// <summary>
        /// Calculates the import tax on all goods.
        /// </summary>
        /// <returns>The import tax.</returns>
        /// <param name="price">Price.</param>
        public decimal CalculateImportTax(decimal price)
        {
            decimal totalTax = 0;

            decimal taxValue = (price * importTax) / 100;
            decimal roundOff = taxValue / (decimal)0.05;
            decimal wholeNumber = (decimal)Math.Round((decimal)roundOff, MidpointRounding.AwayFromZero);

            totalTax = wholeNumber * (decimal)0.05;


            return totalTax;
        }

        /// <summary>
        /// Calculates tax on imported goods that are NOT type Book, Food or Madical
        /// </summary>
        /// <returns>The total import tax.</returns>
        /// <param name="price">Price.</param>
        public decimal CalculateTotalImportTax(decimal price)
        {
            decimal totalTax = 0;

            decimal taxValue = (price * (tax + importTax)) / 100;
            decimal roundOff = taxValue / (decimal)0.05;
            int wholeNumber = (int)Math.Round((decimal)roundOff, MidpointRounding.AwayFromZero);

            totalTax = wholeNumber * (decimal)0.05;


            return totalTax;
        }

        /// <summary>
        /// Displays the products.
        /// </summary>
        /// <param name="products">Products.</param>
        public void DisplayProducts(List<Product> products)
        {
            decimal totalPrice = 0;
            decimal importTotalTax = 0;
            decimal importTaxTaxed = 0;
            decimal totalTax = 0;

            foreach (Product product in products)
            {

                if (product.Description.ToLower().Contains("imported"))
                {
                    if (!(product is Book || product is Food || product is Madical))
                    {
                        importTotalTax += CalculateTotalImportTax(product.Price);
                        product.price += importTotalTax;
                    }
                    else
                    {
                        importTaxTaxed += CalculateImportTax(product.Price);
                        product.price += importTaxTaxed;
                    }
                }

                if (!product.Description.ToLower().Contains("imported") && !(product is Book || product is Food || product is Madical))
                {
                    totalTax += CalculateTotalTax(product.Price);
                    product.price += totalTax;
                }

                totalPrice += product.Price;
                Console.WriteLine($"{product.Quantity} {product.Description} {product.Price}");
            }

            Console.WriteLine($"Sales Taxes: { totalTax + importTotalTax + importTaxTaxed}");
            Console.WriteLine($"Total: { totalPrice }");
        }
    }
}
