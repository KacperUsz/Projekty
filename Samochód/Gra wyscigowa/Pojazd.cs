using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Gra_wyscigowa
{
    class Pojazd
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double V { get; set; }
        public double Kierunek { get; set; }

        Image Obraz;

        public Pojazd()
        {
            Obraz = Image.FromFile("auto_czerwone.png");
            X = 60;
            Y = 200;
            V = 0;
            Kierunek = 0f;
        }

        public void Rysuj(Graphics g)
        {
            var m = g.Transform;
            // … tu kod przesuwający, obracający i 
            // rysujący auto; 
            g.TranslateTransform((float)X, (float)Y);
            g.RotateTransform((float)Kierunek+90f);
            g.ScaleTransform(0.5f, 0.5f);
            g.DrawImage(Obraz, -Obraz.Width/2, -Obraz.Height/2);
            g.Transform=m;
        }
        public void Dzialaj(double dt)
        {
            double dx, dy; 

            //obliczenie przesunięcia w osi x przy prędkości v w czasie dt jadąc w 
            //kierunku „kierunek” 
            dx = V * Math.Cos(Kierunek * Math.PI / 180)*dt; 

            //obliczenie przesunięcia w osi y przy prędkości v w czasie dt jadąc w kierunku 
            //„kierunek” 
            dy = V * Math.Sin(Kierunek * Math.PI / 180)*dt; 
            X += dx; 
            Y += dy;
        }
        
        public void Gaz()
        {
            if(V!=500)
            V += 10;
        }
        public void Hamuj()
        {
            if (V!=0)
            V -= 10;
        }
        public void SkrecLewo()
        { 
            Kierunek -= 6;
        }
        public void SkrecPrawo()
        {
            Kierunek += 6;
        }

    }
}
