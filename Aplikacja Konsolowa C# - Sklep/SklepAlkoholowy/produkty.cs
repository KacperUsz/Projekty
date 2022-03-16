using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    abstract class Produkty
    {
        public string Nazwa { get; private set; }
        protected string Procenty { get; private set; }
        protected int Pojemnosc { get; private set; }
        public double Cena { get; private set; }
        protected ConsoleColor Kolor { get; private set; }
        protected int WspolrzednaX { get; private set; }

        protected virtual string DodatkoweInformacje { get; } = string.Empty;

        public Produkty(string nazwa, string procenty, int pojemnosc, double cena, ConsoleColor kolor, int wspolrzednaX)
        {
            Nazwa = nazwa;
            Procenty = procenty;
            Pojemnosc = pojemnosc;
            Cena = cena;
            Kolor = kolor;
            WspolrzednaX = wspolrzednaX;
        }
        public Produkty()
        {
            
        }
        public abstract void Rysuj();
        //metoda abstrakcyjna - rysowanie butelki i informacje o produkcie
        public virtual double Kupno() // tu się wykonuje cały zakup
        {
            int sztuki=0;
            Rysuj();
            Console.WriteLine("Ile sztuk chcialbys kupic: ");
            Console.WriteLine($"\n<<<{sztuki}>>>");
            sztuki = IleSztuk(sztuki);
            if (sztuki <= 0 || sztuki > 1000000) { return 0; }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Dodano do rachunku: \n{Nazwa} | sztuki: {sztuki} | {sztuki * Cena}zł");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\npowracanie do menu...");
            Thread.Sleep(2000);
            Console.ResetColor();
            return sztuki * Cena;
        }
        public virtual void Informacje()
        {
            Console.WriteLine($"nazwa: {Nazwa}");
            Console.WriteLine($"procenty: {Procenty}%");
            Console.WriteLine($"pojemnosc: {Pojemnosc}ml");
            Console.WriteLine($"cena: {Cena}zł");
            if (!string.IsNullOrEmpty(DodatkoweInformacje))
            {
                Console.WriteLine(DodatkoweInformacje);
            }

        }
        public int IleSztuk(int sztuki)
        {
            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0,2);
                Console.WriteLine($"<<<{sztuki}>>>    <--->    {sztuki * Cena}zł         ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nstrzałka w prawo - więcej");
                Console.WriteLine("strzałka w lewo - mniej");
                Console.WriteLine("enter - zatwierdź");
                Console.WriteLine("escape - anuluj");
                Console.ResetColor();
                var klawisz = Console.ReadKey(true);
                if (klawisz.Key == ConsoleKey.RightArrow)
                {
                    sztuki++;
                }
                else if (klawisz.Key == ConsoleKey.LeftArrow)
                {
                    sztuki--;
                }
                else if (klawisz.Key == ConsoleKey.Enter) 
                {
                    return sztuki;
                }
                else if (klawisz.Key == ConsoleKey.Escape) {return 0;}
            } while (sztuki > -1);

            return sztuki;
        }
    }
}
