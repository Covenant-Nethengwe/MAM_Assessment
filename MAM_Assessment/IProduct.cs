using System;
using System.Collections.Generic; 

namespace MAM_Assessment
{
    public interface IProduct
    {
        decimal CalculateTotalTax(decimal price);
        decimal CalculateTotalImportTax(decimal price);
        decimal CalculateImportTax(decimal price);
        void DisplayProducts(List<Product> products);
    }
}
