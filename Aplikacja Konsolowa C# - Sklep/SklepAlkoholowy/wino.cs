using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    class Wino : Produkty
    {
        protected string BarwaWina;
        protected string Rodzaj;
        protected override string DodatkoweInformacje => $"Wino {BarwaWina}, {Rodzaj}";

        public Wino (string nazwa, string procenty, int pojemnosc, double cena, ConsoleColor kolor, int wspolrzednaX, 
        string barwaWina, string rodzaj) : base(nazwa, procenty, pojemnosc, cena, kolor, wspolrzednaX)
        {
            BarwaWina = barwaWina;
            Rodzaj = rodzaj;
        }
        public override void Rysuj()
        {
            Console.SetCursorPosition(0, 9);
            Console.ForegroundColor = Kolor;
            Informacje();
            Console.SetCursorPosition(0, 15);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"      
     █████
     █████
     █████
     █████
     █████
   █████████
 █████████████
███████████████
███████████████
███████████████
 █████████████
  ███████████
                 ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = Kolor;
            Console.SetCursorPosition(WspolrzednaX, 23);
            Console.WriteLine($"{Nazwa}");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine($"{Pojemnosc} ml");
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
    
       }
    }
}
