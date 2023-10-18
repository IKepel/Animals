using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Move()
        {
            Console.WriteLine("This animal moves");
        }

        public virtual void Speak()
        {
            Console.WriteLine("This animal speaks");
        }
    }
}
