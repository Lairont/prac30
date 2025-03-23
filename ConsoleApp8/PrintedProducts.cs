using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class PrintedProducts
    {
        private string name;

        public PrintedProducts() { }

        public PrintedProducts(string name) { Name = name; }

        public string Name { get => name; set => name = value; }
        public abstract void Info();
        public abstract double TotalCost();
    }
}
