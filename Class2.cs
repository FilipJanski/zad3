using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class IT:Employee
    {
        public int Number_Lines;
        public override void add()
        {
            base.add();
            Console.WriteLine("Podaj liczbe napisanych lini kodu: ");
            Number_Lines = Convert.ToInt32(Console.ReadLine());
            position = "IT";
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("liczba napisanych lini kodu: " + Number_Lines);
        }
    }
}
