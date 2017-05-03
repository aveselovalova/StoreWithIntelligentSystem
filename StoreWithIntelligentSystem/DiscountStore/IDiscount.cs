using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public interface IDiscount
    {
        List<Product> MakeADiscount(List<Product> production);
    }
}
