using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Komis
    {
        List<Pojazd> pojazdy = new List<Pojazd>();
        Menu a = new Menu();
        private string[] rodzaje = { "Samochód", "Motocykl" };
        private int w;
        public void DodawaniePojazdu()
        {
            string marka, model;
            Console.Clear();
            a.konfiguracja(rodzaje, 1, 0);
            w = a.wyswietlanie();
            Console.Clear();
            Console.Write("Podaj markę pojazdu: ");
            marka = Console.ReadLine();
            Console.Write("Podaj model: ");
            model = Console.ReadLine();
            Console.Write("Podaj rok produkcji: ");
            decimal rok_prod = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj cenę: ");
            decimal c = Convert.ToInt32(Console.ReadLine());
            switch (w)
            {
                case 0:
                    pojazdy.Add(new Samochod(marka, model, rok_prod, c));
                    break;
                case 1:
                    pojazdy.Add(new Motocykl(marka, model, rok_prod, c));
                    break;
            }            
            Console.WriteLine("Pomyślnie dodano nowy pojazd do komisu!");
            Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować..");
            Console.ReadKey();
        }
        public void WyswietlaniePojazdow()
        {
            Console.Clear();
            for(int i = 0; i < pojazdy.Count; i++)
            {
                pojazdy[i].Wyswietl();
            }
            Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować..");
        }
    }
}
