using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAlkoholowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Sklep sklep = new Sklep();
            sklep.Przywitanie();
            sklep.Start();
        }
    }
}
