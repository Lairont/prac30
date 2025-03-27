using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Magazine : PrintedProducts
    {
        private int edition;
        private int price;

        public int Edition { get => edition; set => edition = value; }
        public int Price { get => price; set => price = value; }

        public Magazine() { }
        public Magazine(string name, int edition, int price) : base(name)
        {
            this.Edition = edition;
            this.Price = price;
            this.Name = name;
        }
        public override double TotalCost()
        {
            return Price * Edition;
        }
        public override void Info()
        {
            Console.WriteLine($"Журнал: {Name}\nЦена: {Price}\nТираж: {Edition}");
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
