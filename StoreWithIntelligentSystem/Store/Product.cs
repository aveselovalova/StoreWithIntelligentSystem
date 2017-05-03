using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class Product
    {
        public int ProductID { get; private set; }
        public Products ProductName { get; set; }
        public decimal Price { get; set; }
        public Categories Category { get; set; }
        public int DiscountPercent { get; set; }
     
        public Product(int id, Products name, decimal price, Categories category, int percent)
        {
            ProductID = id;
            ProductName = name;
            Price = price;
            Category = category;
            DiscountPercent = (percent>100||percent<0)?0:percent;
        }
        public override string ToString()
        {
            return (DiscountPercent>0)? String.Format(ProductName + " !with " + DiscountPercent + " discount! " + Price) : String.Format(ProductName+" - "+Price);
        }
    }
}
