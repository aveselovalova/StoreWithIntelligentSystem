using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class Buyer:Worker
    {
        public decimal Cash { get; set; }
        public Buyer(int id, string name, string lastName, Professions profession, decimal cash) :base(id,name,lastName,profession)
        {
            Cash = cash;
        }
    }
}
