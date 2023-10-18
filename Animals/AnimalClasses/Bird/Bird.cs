using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Bird
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This bird flies");
        }
        public override void Speak()
        {
            Console.WriteLine("This bird makes a sound");
        }
    }
}
