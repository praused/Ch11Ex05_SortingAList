using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex05_SortingAList
{
    class Person : IComparable
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person otherPerson = obj as Person;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException("Object to compare is not a Person.");
            }
        }
    }
}
