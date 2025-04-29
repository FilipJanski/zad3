using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IT itEmployee = new IT();
            Console.WriteLine("Dodawanie pracownika IT:");
            itEmployee.add();
            Console.WriteLine("\nDane pracownika IT:");
            itEmployee.show();

            Console.WriteLine("\n-----------------------------\n");

            Admintistration adminEmployee = new Admintistration();
            Console.WriteLine("Dodawanie pracownika Administracji:");
            adminEmployee.add();
            Console.WriteLine("\nDane pracownika Administracji:");
            adminEmployee.show();

            Console.ReadLine();
        }
    }
}
