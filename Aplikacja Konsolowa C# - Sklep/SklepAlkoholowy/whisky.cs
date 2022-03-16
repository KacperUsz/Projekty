using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    class Whisky:Produkty
    {
        protected int Rocznik;
        protected override string DodatkoweInformacje => $"Rocznik: {Rocznik}";
        public Whisky(string nazwa, string procenty, int pojemnosc, double cena, ConsoleColor kolor, int wspolrzednaX, int rocznik) 
        : base(nazwa, procenty, pojemnosc, cena, kolor, wspolrzednaX)
        {
            Rocznik = rocznik;
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
 ███████████
█████████████
█████████████
█████████████
█████████████
█████████████
█████████████
█████████████
█████████████
█████████████
█████████████
                 ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = Kolor;
            Console.SetCursorPosition(WspolrzednaX, 20);
            Console.WriteLine($"{Nazwa}");
            Console.SetCursorPosition(5, 28);
            Console.WriteLine($"{Pojemnosc} ml");
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();

        }
    }
}
