using System;

namespace person
{
    public class Person : IComparable
    {
        public int Idade { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            var anotherPerson = obj as Person;

            return this.Name.CompareTo(anotherPerson.Name);
        }
    }
}