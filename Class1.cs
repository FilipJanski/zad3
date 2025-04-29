using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Employee
    {
        public int id;
        public string name;
        public int age;
        public string position;
        public virtual void add()
        {
            Console.WriteLine("Podaj id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj imie i nazwisko: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void show()
        {

            Console.WriteLine("ID: "+id);
            Console.WriteLine("Imie i nazwisko: " + name);
            Console.WriteLine("Wiek: " + age);
            Console.WriteLine("zawod: " + position);
        }
    }
}
