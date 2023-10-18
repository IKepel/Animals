using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Mammal
{
    public class Cat : Mammal
    {
        public Cat(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This cat prowls");
        }

        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
}
