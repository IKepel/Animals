using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Fish
{
    public class Fish : Animal
    {
        public Fish(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This fish swims");
        }

        public sealed override void Speak()
        {
            Console.WriteLine("This fish can't speak");
        }
    }
}
