using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Mammal
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age) 
        { 
        }

        public override void Move()
        {
            Console.WriteLine("This mammal moves");
        }

        public override void Speak()
        {
            Console.WriteLine("This mammal speaks");
        }
    }
}
