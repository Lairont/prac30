using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russian("Никита"));
            people.Add(new Ukrainian("Богдан"));
            people.Add(new American("Maxim"));

            foreach (Person person in people)
            {
                person.SayHello();
            }
            Console.ReadLine();
        }
    }
}
