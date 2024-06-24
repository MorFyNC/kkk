using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class DBManager
    {
        private static PersonsEntities entities = new PersonsEntities();
        public static List<Person> Get()
        {
            return entities.Person.ToList();
        }

        public static void Add(Person person)
        {
            entities.Person.Add(person);
            entities.SaveChanges();
        }

        public static void Remove(Person person)
        {
            entities.Person.Remove(person);
            entities.SaveChanges();
        }
    }
}
