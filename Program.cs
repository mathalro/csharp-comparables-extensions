using System;
using System.Collections.Generic;
using extensions;
using person;

namespace programs
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();

            personList.AddRange(
                new Person
                {
                    Idade = 10,
                    Name = "Matheus"
                },
                new Person
                {
                    Idade = 15,
                    Name = "Eduarda"
                },
                new Person
                {
                    Idade = 20,
                    Name = "Regiana"
                }
            );

            personList.Sort();

            foreach (var person in personList)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
