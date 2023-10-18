using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Bird
{
    public class Eagle : Bird
    {
        public Eagle(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This eagle flies");
        }

        public override void Speak()
        {
            Console.WriteLine("This eagle makes a sound");
        }
    }
}
