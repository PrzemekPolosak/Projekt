using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;

namespace Połosak_Przemysław_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Komis k = new Biblioteka.Komis();
            Menu m = new Menu();
            string[] lista = { "Dodaj pojazd", "Wyświetl pojazdy", "Wyjdź" };
            m.konfiguracja(lista, 1, 0);
            int wybor = m.wyswietlanie();
            while (wybor != 2)
            {
                switch (wybor)
                {
                    case 0:
                        k.DodawaniePojazdu();
                        wybor = m.wyswietlanie();
                        break;
                    case 1:
                        k.WyswietlaniePojazdow();
                        Console.ReadKey();
                        wybor = m.wyswietlanie();
                        break;
                    case 2:
                        break;
                }
            }
        }
    }
}
