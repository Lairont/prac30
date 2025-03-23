using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Ukrainian : Person
    {
        public Ukrainian(string name) { Name = name; }
        public override void SayHello()
        {
            Console.WriteLine($"{Name} Привіт");
        }
    }
}
