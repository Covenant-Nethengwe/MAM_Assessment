using System;
using System.Collections.Generic; 

namespace MAM_Assessment
{
    public interface IProduct
    {
        double CalculateTotalTax(double price);
        double CalculateTotalImportTax(double price);
        double CalculateImportTax(double price);
        void DisplayProducts(List<Product> products);
    }
}
