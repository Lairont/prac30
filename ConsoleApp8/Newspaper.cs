using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Newspaper : PrintedProducts
    {
        private int listcount;
        private int edition;
        private int listprice;

        public int Listcount { get => listcount; set => listcount = value; }
        public int Edition { get => edition; set => edition = value; }
        public int Listprice { get => listprice; set => listprice = value; }

        public Newspaper() { }
        public Newspaper(string name, int listcount, int edition, int listprice) : base(name)
        {
            this.Listcount = listcount;
            this.Edition = edition;
            this.Listprice = listprice;
            this.Name = name;
        }

        public override double TotalCost()
        {
            return Listcount * Edition * Listprice;
        }
        public override void Info()
        {
            Console.WriteLine($"Газета: {Name}\nКол-во листов: {Listcount}\nТираж: {Edition}\nЦена: {Listprice}");
        }

        public static Magazine Enter()
        {
            Console.Clear();
            Console.Write("Введите название журнала: ");
            string name = Console.ReadLine();
            Console.Write("Введите тираж журнала: ");
            int edition = int.Parse(Console.ReadLine());
            Console.Write("Введите цену журнала: ");
            int price = int.Parse(Console.ReadLine());
            return new Magazine
                (name, edition, price);
        }
    }
}