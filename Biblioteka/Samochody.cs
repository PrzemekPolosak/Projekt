using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    enum rodzajPojazdu { Samochod, Motocykl };
    public class Pojazd
    {
        protected string marka;
        protected string model;
        protected decimal rok_produkcji;
        protected decimal cena;
        protected int rodzaj = 0;

        public Pojazd(string marka, string model, decimal rok_produkcji, decimal cena)
        {
            this.marka = marka;
            this.model = model;
            this.rok_produkcji = rok_produkcji;
            this.cena = cena;
        }
        public string Marka
        {
            get { return marka; }

            private set
            {
                if (value.Length < 101)
                    marka = value;
                else Console.WriteLine("Za dluga nazwa marki!");
            }
        }
        public string Model
        {
            get { return model; }

            private set
            {
                if (value.Length < 101)
                    model = value;
                else Console.WriteLine("Za dluga nazwa modelu!");
            }
        }
        public decimal Rok_produkcji
        {
            get { return rok_produkcji; }

            set
            {
                if (value >= 1990 && value <= 2020)
                    rok_produkcji = value;
                else Console.WriteLine("Data produkcji spoza zakresu!");
            }
        }
        public decimal Cena
        {
            get { return cena; }

            set
            {
                if (value >= 0)
                    cena = value;
                else Console.WriteLine("Cena jest ujemna!");
            }
        }
        public decimal CenaBrutto
        {
            get
            {
                return cena * 1.23m;
            }
        }        
        public virtual void Wyswietl()
        {
            Console.WriteLine(marka + " " + model + " Rok produkcji: " + rok_produkcji + " Cena: " + cena + "zł Cena brutto: " + CenaBrutto + "zł");
        }
        public virtual void przypiszRodzaj(int liczba) { }        
    }
    public class Samochod : Pojazd
    {
        public Samochod(string marka, string model, decimal rok_produkcji, decimal cena) : base(marka, model, rok_produkcji, cena)
        {
            przypiszRodzaj (0);
        }
        public override void przypiszRodzaj(int liczba)
        {
            rodzaj = liczba;
        }
        public override void Wyswietl()
        {            
            Console.Write(Enum.GetName(typeof(rodzajPojazdu), rodzaj) + " ");
            base.Wyswietl();
        }
    }
    public class Motocykl : Pojazd
    {
        public Motocykl(string marka, string model, decimal rok_produkcji, decimal cena) : base(marka, model, rok_produkcji, cena)
        {
            przypiszRodzaj(1);
        }
        public override void przypiszRodzaj(int liczba)
        {
            rodzaj = liczba;
        }
        public override void Wyswietl()
        {            
            Console.Write(Enum.GetName(typeof(rodzajPojazdu), rodzaj) + " ");
            base.Wyswietl();
        }
    }
}
