using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class Person
    {
        public int PersonId { get; protected set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(int id, string name, string lastName)
        {
            PersonId = id;
            Name = name;
            LastName = lastName;
        }
    }
}
