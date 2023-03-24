using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string initialName, int initialAge)
        {
            this.age = initialAge;
            this.name = initialName;
        }

        public void PrintPerson()
        {
            Console.WriteLine(this.name + ", age " + this.age + " years");
        }
    }
}
