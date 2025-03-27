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
            //1 способ
            //PrintedProducts pressa = new Magazine("Информация образования", 100, 25);
            //pressa.Info();
            //Console.WriteLine("Стоимость тиража:" + pressa.TotalCost() + "руб.");

            //2 способ
            //List<PrintedProducts> printedProducts = new List<PrintedProducts>();
            //printedProducts.Add(new Magazine("Наука", 1500, 200));
            //printedProducts.Add(new Newspaper("Известия", 21, 2050, 150));

            //foreach (var product in printedProducts)
            //{
            //    product.Info();
            //    Console.WriteLine($"Стоимость тиража: {product.TotalCost()} руб.");
            //    Console.WriteLine();
            //}

            List<PrintedProducts> pressa = new List<PrintedProducts>();
            bool flag = true;

            do
            {
                Console.Write("Введите название печатной продукции: ");
                string metka = Console.ReadLine();

                switch (metka)
                {
                    case "m":
                    case "M":
                        pressa.Add(Magazine.Enter()); 
                        break;

                    case "n":
                    case "N":
                        pressa.Add(Newspaper.Enter()); 
                        break;

                    default:
                        Console.WriteLine("Нет такой.");
                        flag = false; 
                        break;
                }

                if (flag) 
                {
                    Console.WriteLine("\nСписок продукции:");
                    foreach (PrintedProducts pr in pressa)
                    {
                        pr.Info();
                        Console.WriteLine("Стоимость тиража: " + pr.TotalCost() + " руб.");
                    }
                }

             } 
                    while (flag); 

            Console.ReadLine();

        }
    }
}
