using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class Store
    {
        public List<Product> Production { get; set; }
        public Store(List<Product> products)
        {
            Production = products;
        }
    }
}
