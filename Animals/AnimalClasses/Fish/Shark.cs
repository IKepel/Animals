using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalClasses.Fish
{
    public class Shark : Fish
    {
        public Shark(string name, int age) : base(name, age) 
        {
        }

        public override void Move()
        {
            Console.WriteLine("This shark swims");
        }
    }
}
