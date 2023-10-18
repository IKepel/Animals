using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Mammal
{
    public class Dog : Mammal
    {
        public Dog(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This dog runs");
        }

        public override void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
