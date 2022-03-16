using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    class Menu
    {
        private string[] elementy = new string[0];

        public void Konfiguruj(string[] elementyMenu)
        {
            if (elementyMenu != null)
            {
                elementy = elementyMenu;

            }
        }

        public int Otworz()
        {
            int wybrany = 0;
            Console.CursorVisible = false;
            ConsoleKeyInfo klawisz;
            do
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < elementy.Length; i++)
                {
                    if (i == wybrany)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    int dlugosc = 0;
                    for (int j = 0; j < elementy.Length; j++)
                    {
                        if (dlugosc < elementy[j].Length)
                        {
                            dlugosc = elementy[j].Length;
                        }
                    }
                    Console.WriteLine(elementy[i].PadRight(dlugosc));
                }

                klawisz = Console.ReadKey(true);
                if (klawisz.Key == ConsoleKey.DownArrow && wybrany < elementy.Length - 1)
                {
                    wybrany++;
                }
                else if (klawisz.Key == ConsoleKey.UpArrow && wybrany > 0)
                {
                    wybrany--;
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    wybrany = -1;
                }

            } while (klawisz.Key != ConsoleKey.Escape && klawisz.Key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            return wybrany;
        }
    }
}
