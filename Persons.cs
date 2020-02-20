using System;

namespace Professions
{
    class Person
    {
        private string name;
        private string lastName;
        private string profession;

        public Person(String name, string lastName, string profession)
        {
            this.name = name;
            this.lastName = lastName;
            this.profession = profession;
        }

        public void presentation()
        {
            Console.WriteLine("Hello, my name is {0} {1} and my profession is {2}", this.name, this.lastName, this.profession);
        }

    }
}