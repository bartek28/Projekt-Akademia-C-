using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MobileNumber { get; set; }
        public string Adress { get; set; }

        public Person() { }

        public Person(string imie,string nazwisko, string telefon, string adres)
        {
            this.Name = imie;
            this.Surname = nazwisko;
            this.MobileNumber = telefon;
            this.Adress = adres;
        }
    }
}
