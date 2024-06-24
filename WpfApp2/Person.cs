using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Person(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }
    }
}
