using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    class Sklep
    {
        protected List<Piwo> piwa;
        protected List<Wino> wina;
        protected List<Wodka> wodki;
        protected List<Whisky> whisky;
        public Sklep()
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            //                                             PIWO
            piwa = new List<Piwo>();
            piwa.Add(new Piwo("Heineken", "5", 500, 4.29, ConsoleColor.DarkGreen, 4, 5));
            piwa.Add(new Piwo("Carlsberg", "5", 500, 3.79, ConsoleColor.DarkGreen, 3, 8));
            piwa.Add(new Piwo("Harnaś", "6", 500, 2.59, ConsoleColor.DarkYellow, 4, 7));
            piwa.Add(new Piwo("Tatra", "6", 500, 2.39, ConsoleColor.DarkYellow, 5, 4));
            piwa.Add(new Piwo("Tyskie", "5.2", 500, 3.29, ConsoleColor.White, 4, 5));
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //                                       WINO
            wina = new List<Wino>();
            wina.Add(new Wino("Sophia", "11", 750, 12.49, ConsoleColor.DarkMagenta, 4, "Różowe", "słodkie"));
            wina.Add(new Wino("Fresco", "10", 750, 10.99, ConsoleColor.DarkRed, 4, "Czerwone", "półsłodkie"));
            wina.Add(new Wino("Carlo Rossi", "11", 750, 28.90, ConsoleColor.White, 2, "Białe", "wytrawne"));
            wina.Add(new Wino("Liebfraumilch", "9,5", 1500, 38.49, ConsoleColor.White, 1, "Białe", "półsłodkie"));
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //                                       WÓDKA
            wodki = new List<Wodka>();
            wodki.Add(new Wodka("Żubrówka", "40", 1000, 43.09, ConsoleColor.White, 3, "czysta"));
            wodki.Add(new Wodka("Soplica", "30", 500, 26.49, ConsoleColor.Red, 3, "żurawinowy"));
            wodki.Add(new Wodka("Absolut", "40", 500, 35.00, ConsoleColor.White, 3, "czysta"));
            wodki.Add(new Wodka("Bocian", "40", 700, 44.99, ConsoleColor.White, 4, "czysta"));
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //                                       WHISKY
            whisky = new List<Whisky>();
            whisky.Add(new Whisky("JackDaniels", "40", 1000, 134.99, ConsoleColor.DarkYellow, 1, 2000));
            whisky.Add(new Whisky("Ballantines", "40", 500, 45.99, ConsoleColor.DarkYellow, 1, 2005));
            whisky.Add(new Whisky("Metaxa 5*", "38", 1000, 89.99, ConsoleColor.DarkYellow, 2, 1997));
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
        private double DoZaplaty;
        List<string> paragon = new List<string> { };
        
        public void Przywitanie()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
╔═╗       ╔═╗  ╦╔═  ╦    ╔═╗  ╔═╗      ╔╦╗  ╔═╗  ╔╗╔  ╔═╗  ╔═╗  ╔═╗  ╦    ╔═╗  ╦ ╦  ╦ ╦
║╣   ───  ╚═╗  ╠╩╗  ║    ║╣   ╠═╝      ║║║  ║ ║  ║║║  ║ ║  ╠═╝  ║ ║  ║    ║ ║  ║║║  ╚╦╝
╚═╝       ╚═╝  ╩ ╩  ╩═╝  ╚═╝  ╩        ╩ ╩  ╚═╝  ╝╚╝  ╚═╝  ╩    ╚═╝  ╩═╝  ╚═╝  ╚╩╝   ╩ 
               ");
            Console.WriteLine("\n\n\n\n\nPlanujesz dużą imprezę? Weselę? A może poprostu potrzebujesz alkoholu dla siebię?" +
                "\nJuż teraz możesz kupić alkohol w dobrych cenach, nie ruszając się z domu." +
                "\nSprawdź naszą ofertę!");
            Console.ResetColor();
            Dowolnyprzycisk();
        }
       
        public void Start()
        {
            Menu menuGlowne = new Menu();
            menuGlowne.Konfiguruj(new string[]
                {"PIWO",
                 "WINO",
                 "WÓDKA",
                 "WHISKY",
                 "WYŚWIETL ZAMÓWIENIE",
                 "RESETUJ ZAMÓWIENIE",
                 "PRZEJDŹ DO KASY"
                });
           
            int decyzja;
            do
            {
                CzyscEkran();
                decyzja = menuGlowne.Otworz();

                if (decyzja == 0)
                {
                    CzyscEkran();
                    MenuPiwa();
                }
                else if (decyzja == 1)
                {
                    CzyscEkran();
                    MenuWina();
                }
                else if (decyzja == 2)
                {
                    CzyscEkran();
                    MenuWodki();
                }
                else if (decyzja == 3)
                {
                    CzyscEkran();
                    MenuWhisky();
                }
                else if (decyzja == 4)
                {
                    CzyscEkran();
                    WyswietlZamowienie();
                    Dowolnyprzycisk();
                }
                else if (decyzja == 5)
                {
                    CzyscEkran();
                    ResetZamowienia();
                }
            } while (decyzja != 6 && decyzja != -1);
           
            CzyscEkran();
            if (DoZaplaty > 0) 
            {
                WyswietlZamowienie();
                Console.WriteLine($"\n\nDo zapłaty: {DoZaplaty}zł.");
            }
            else { Console.WriteLine("Liczymy że następnym razem zdecydujesz się na zakupy!");}
            Console.ReadKey();
        }

        public void MenuPiwa()
        {
            string[] piwa_nazwa = GenerujNazwyAlkoholu(piwa.Cast<Produkty>().ToList());
            Menu menuPiw = new Menu();
            menuPiw.Konfiguruj(piwa_nazwa);
            int decyzja;
            do
            {
                CzyscEkran();
                decyzja = menuPiw.Otworz();


                if (decyzja < piwa_nazwa.Length-1 && decyzja != -1) { CzyscEkran(); Kup(piwa[decyzja]); }


            } while (decyzja != piwa_nazwa.Length-1 && decyzja != -1);
        }
        public void MenuWina()
        {
            string[] wina_nazwa = GenerujNazwyAlkoholu(wina.Cast<Produkty>().ToList());
            Menu menuWin = new Menu();
            menuWin.Konfiguruj(wina_nazwa);
            int decyzja;
            do
            {
                CzyscEkran();
                decyzja = menuWin.Otworz();

                if (decyzja < wina_nazwa.Length-1 && decyzja != -1) { CzyscEkran(); Kup(wina[decyzja]); }
            } while (decyzja != wina_nazwa.Length-1 && decyzja != -1);
        }
         public void MenuWodki()
         {
            string[] wodki_nazwy = GenerujNazwyAlkoholu(wodki.Cast<Produkty>().ToList());
            Menu menuWodki = new Menu();
             menuWodki.Konfiguruj(wodki_nazwy);
             int decyzja;
             do
             {
                 CzyscEkran();
                 decyzja = menuWodki.Otworz();
                if (decyzja < wodki_nazwy.Length-1 && decyzja != -1) { CzyscEkran(); Kup(wodki[decyzja]); }
            } while (decyzja != wodki_nazwy.Length-1 && decyzja != -1);
        }

         public void MenuWhisky()
         {
            string[] whisky_nazwa = GenerujNazwyAlkoholu(whisky.Cast<Produkty>().ToList());
            Menu menuWhisky = new Menu();
             menuWhisky.Konfiguruj(whisky_nazwa);
             int decyzja;
             do
             {
                 CzyscEkran();
                 decyzja = menuWhisky.Otworz();

                if (decyzja < whisky_nazwa.Length-1 && decyzja != -1) { CzyscEkran(); Kup(whisky[decyzja]); }
            } while (decyzja != whisky_nazwa.Length-1 && decyzja != -1);
         }

        private string[] GenerujNazwyAlkoholu(List<Produkty> produkty)
        {
            string[] produkty_nazwa = new string[produkty.Count + 1];
            produkty_nazwa[produkty_nazwa.Length - 1] = "Wróć do menu";
            for (int i = 0; i < produkty.Count; i++)
            {
                produkty_nazwa[i] = produkty[i].Nazwa;
            }

            return produkty_nazwa;
        }
        public void Kup(Produkty obiekt)
        {
            double rachunek = obiekt.Kupno();
            if (rachunek > 0)
            {
                DoZaplaty += rachunek;
                paragon.Add($"{obiekt.Nazwa}, sztuk: {rachunek / obiekt.Cena}, {rachunek} zł\n-----------------------------------");
            }
        }
        public void ResetZamowienia()
        {
            if (DoZaplaty > 0)
            {
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Resetowanie Zamówienia, proszę czekać\n");
                for (int i = 0; i < 37; i++)
                {
                    Thread.Sleep(100);
                    Console.Write("█");
                }
                paragon.Clear();
                DoZaplaty = 0;
                Console.ResetColor();
                Console.WriteLine($"\n\nAktualna wartość koszyka {DoZaplaty}zł");
                Dowolnyprzycisk();
            }
            else {Console.WriteLine("Wygląda na to że twoje zamówienie jest już puste"); Dowolnyprzycisk(); }
        }

        public static void Dowolnyprzycisk()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nNaciśnij dowolny przycisk...");
            Console.ReadKey();
            Console.ResetColor();
        }

        public static void CzyscEkran()
        {
            Console.ResetColor();
            Console.Clear();
        }
         public void WyswietlZamowienie()
         {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("           <<<PARAGON>>>\n");
             foreach (var produkt in paragon)
             {
                Console.WriteLine(produkt);
             }
            Console.ResetColor();
         }
    }
}
