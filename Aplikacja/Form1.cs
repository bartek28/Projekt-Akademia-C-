using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class Form1 : Form
    {
        Person osoba = new Person();
        enum Kroki { witaj, imie, nazwisko, adres, telefon, wynik, koniec }
        Kroki krok = Kroki.witaj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // przycisk dalej
        {

            krok++;
            okno();

            if (krok == Kroki.koniec)
                this.Close();
        }


        private void button2_Click(object sender, EventArgs e) // przycisk wstecz
        {
            krok--;
            okno();
        }

        private void okno()
        {
            if (krok < Kroki.witaj)
                krok = 0;
            if (krok > Kroki.koniec)
                krok = Kroki.koniec;

            switch (krok)
            {
                case
                Kroki.witaj:
                    {
                        instrLabel.Text = "Witaj, naciśnij Dalej";
                        buttonW.Visible = false;
                        textBox.Visible = false;
                        break;
                    }
                case Kroki.imie:
                    {
                        buttonW.Visible = true;
                        textBox.Visible = true;
                        instrLabel.Text = "Imię:";
                        textBox.Text = osoba.Name;
                        break;
                    }
                case Kroki.nazwisko:
                    {
                        instrLabel.Text = "Nazwisko:";
                        textBox.Text = osoba.Surname;
                        break;
                    }
                case Kroki.adres:
                    {
                        instrLabel.Text = "Adres zamieszkania:";
                        textBox.Text = osoba.Adress;
                        break;
                    }
                case Kroki.telefon:
                    {
                        instrLabel.Text = "Numer telefonu:";
                        textBox.Text = osoba.MobileNumber;
                        textBox.Visible = true;
                        buttonD.Text = "Dalej";
                        dataLabel.Visible = false;
                        break;
                    }
                case Kroki.wynik:
                    {
                        textBox.Visible = false;
                        buttonD.Text = "Zamknij";
                        instrLabel.Text = "Podane dane:";
                        dataLabel.Visible = true;
                        dataLabel.Text = "Imię: " + osoba.Name + "\n" + "Nazwisko: " + osoba.Surname + "\n" + "Adres zamieszkania: " + osoba.Adress + "\n" + "Numer telefonu: " + osoba.MobileNumber;
                        break;
                    }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // pobranie zawartosci pola tekstowego
        {
            switch ((int)krok)
            {
                case 1: osoba.Name = textBox.Text; break;
                case 2: osoba.Surname = textBox.Text; break;
                case 3: osoba.Adress = textBox.Text; break;
                case 4: osoba.MobileNumber = textBox.Text; break;

            }


        }
    }
}
