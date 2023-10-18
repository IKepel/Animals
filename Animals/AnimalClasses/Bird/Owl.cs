using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This Owl flies");
        }

        public override void Speak()
        {
            Console.WriteLine("This Owl makes a sound");
        }
    }
}
