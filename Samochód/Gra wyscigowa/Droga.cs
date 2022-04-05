using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Gra_wyscigowa
{
    class Droga
    {
        public List<PointF> Punkty { get; set; }

        public List<RectangleF> Punkty2 { get; set; }

        private Pen BialaLinia;
        private Pen Asfalt;
        Image ObrazDrogi;
        public Droga()
        {

            ObrazDrogi = new Bitmap("asfalt2.jpg");
            Punkty = new List<PointF>();
            //Punkty2 = new List<RectangleF>();
            BialaLinia = new Pen(Color.White, 6);
            BialaLinia.DashStyle = DashStyle.Dash;
            Asfalt = new Pen(new TextureBrush(ObrazDrogi, new Rectangle(0,0, 180,180)), 180);


        }

        public void Rysuj(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawCurve(Asfalt, Punkty.ToArray());
            g.DrawCurve(BialaLinia, Punkty.ToArray());
            
        }



    }
}
