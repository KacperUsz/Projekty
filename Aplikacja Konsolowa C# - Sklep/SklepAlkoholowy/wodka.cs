using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    class Wodka:Produkty
    {
        protected string Smak;
        protected override string DodatkoweInformacje => $"Smak: {Smak}";

        public Wodka(string nazwa, string procenty, int pojemnosc, double cena, ConsoleColor kolor, int wspolrzednaX, string smak) 
        : base(nazwa, procenty, pojemnosc, cena, kolor, wspolrzednaX)
        {
            Smak = smak;
        }
        public override void Rysuj()
        {
            Console.SetCursorPosition(0, 9);
            Console.ForegroundColor = Kolor;
            Informacje();
            Console.SetCursorPosition(0, 15);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"      
     ███
    █████
   ███████
 ███████████
█████████████
█████████████
█████████████
█████████████
█████████████
█████████████
 ███████████
                 ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = Kolor;
            Console.SetCursorPosition(WspolrzednaX, 20);
            Console.WriteLine($"{Nazwa}");
            Console.SetCursorPosition(5, 26);
            Console.WriteLine($"{Pojemnosc} ml");
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();

        }
    }
}
