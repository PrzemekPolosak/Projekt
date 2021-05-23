using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Menu
    {
        string[] text;
        int lk;
        int smenu;
        public void konfiguracja(string[] text, int lk, int smenu)
        {
            this.text = text;
            this.lk = lk;
            this.smenu = smenu;
        }
        public int wyswietlanie()
        {
            Console.Clear();
            int w = 0;
            ConsoleKeyInfo a = new ConsoleKeyInfo();

            while (a.Key != ConsoleKey.Enter)
            {
                Console.ResetColor();
                Console.SetCursorPosition(0, smenu);
                int i = 0;
                for (; i < this.text.Length / this.lk; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (i == w && w < this.text.Length / this.lk)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(this.text[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    for (int j = 1; j < this.lk; j++)
                    {
                        if (w == this.text.Length / this.lk * j + i)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(" " + this.text[this.text.Length / this.lk * j + i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine();
                }
                a = Console.ReadKey();
                if (a.Key == ConsoleKey.UpArrow && w > 0) { w--; }
                else if (a.Key == ConsoleKey.DownArrow && w < this.text.Length - 1) { w++; }
                else if (a.Key == ConsoleKey.RightArrow && w < this.text.Length - i) { w = w + this.text.Length / lk; }
                else if (a.Key == ConsoleKey.LeftArrow && w >= i) { w = w - this.text.Length / lk; }
                czyszczenie();
            }
            return w;
        }

        void czyszczenie()
        {
            Console.SetCursorPosition(0, smenu);
            for (int a = 0; a < this.text.Length / this.lk; a++)
            {
                Console.Write(new string(' ', Console.WindowWidth));
            }
        }
    }
}
