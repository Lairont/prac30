using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PrintedProducts> printedProducts = new List<PrintedProducts>();
            printedProducts.Add(new Magazine("Наука", 1500, 200));
            printedProducts.Add(new Newspaper("Известия", 21, 2050, 150));

            foreach (var product in printedProducts)
            {
                product.Info();
                Console.WriteLine($"Стоимость тиража: {product.TotalCost()} руб.");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
