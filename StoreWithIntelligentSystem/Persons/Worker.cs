using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class Worker : Person
    {
        public Professions Profesion { get; set; }
        public Worker(int id, string name, string lastName, Professions profession) : base(id, name, lastName)
        {
            Profesion = profession;
        }
        

    }

}
    