using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class DiscountStoreSystem:Store
    {
        DiscountSystem discount = new DiscountSystem();
        public DiscountStoreSystem(List<Product> production) : base(production) { }
       
        public List<Product> MakeADiscount()
        {
            return discount.MakeADiscount(Production);
        }
    }
}
