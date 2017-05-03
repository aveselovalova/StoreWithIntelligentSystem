using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class DiscountSystem: IDiscount
    {
        public List<Product> MakeADiscount(List<Product> production)
        {
            var productDiscounts = ProductDiscount();
            var categoryDiscount = CategoryDiscount();
            List<string> listWithNewPriecies = new List<string>();

            List<Product> listWithDiscountPrieses = new List<Product>();

            foreach (var product in production)
            {
                int prodPercent = 0;
                int categPercent = 0;
                if (categoryDiscount.TryGetValue(product.Category, out categPercent))
                {
                    if (productDiscounts.TryGetValue(product.ProductName, out prodPercent))
                    {
                        var discount = DiscountComparer(prodPercent, categPercent);
                        listWithDiscountPrieses.Add(new Product(product.ProductID, product.ProductName, Discount(product.Price, discount), product.Category, discount));
                    }
                    else
                        listWithDiscountPrieses.Add(new Product(product.ProductID, product.ProductName, Discount(product.Price, categPercent), product.Category, categPercent));
                }
                else if (productDiscounts.TryGetValue(product.ProductName, out prodPercent))
                    listWithDiscountPrieses.Add(new Product(product.ProductID, product.ProductName, Discount(product.Price, prodPercent), product.Category, prodPercent));
                else
                    listWithDiscountPrieses.Add(product);   
            }
          
            return listWithDiscountPrieses;
        }
        private int DiscountComparer(int first, int twice)
        {
            return (first > twice) ? first : twice;
        }
        private decimal Discount(decimal oldPrice, int discount)
        {
            return (discount>0 && discount<100)?(oldPrice - oldPrice * discount / 100):oldPrice;
        }
        protected Dictionary<Products, int> ProductDiscount()
        {
            var discountsProd = new Dictionary<Products, int>();
            discountsProd.Add(Products.Oven, 20);
            discountsProd.Add(Products.Ball, 5);
            return discountsProd;
        }
        protected Dictionary<Categories, int> CategoryDiscount()
        {
            var discountsCategory = new Dictionary<Categories, int>();
            discountsCategory.Add(Categories.Food, 5);
            discountsCategory.Add(Categories.Cooking, 70);
            return discountsCategory;
        }
    }
    
}
