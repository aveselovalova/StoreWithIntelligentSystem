using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class IntelligentStoreSystem:Store
    {
        IntelligentSystem intelligent = new IntelligentSystem();
        public IntelligentStoreSystem(List<Product> production) : base(production) { }

        public IEnumerable<string> GetsNecessaryProducts(Buyer buyer)
        {
            return intelligent.GetsNecessaryProducts(buyer, Production);
        }
    }
}
