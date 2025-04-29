using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Admintistration:Employee
    {
        public int Number_Documents;
        public override void add()
        {
            base.add();
            Console.WriteLine("Podaj liczbe napisanych dokumentow: ");
            Number_Documents = Convert.ToInt32(Console.ReadLine());
            position = "Administracja";
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("liczba napisanych dokumentow: "+ Number_Documents);
            

        }
    }
}
