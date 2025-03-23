using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Person 
    {
        public string Name { get; set; }
        public abstract void SayHello();
    }
}
