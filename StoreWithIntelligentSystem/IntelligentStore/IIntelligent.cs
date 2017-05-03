using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public interface IIntelligent
    {
        IEnumerable<string> GetsNecessaryProducts(Buyer buyer, List<Product> production);
    }
}
