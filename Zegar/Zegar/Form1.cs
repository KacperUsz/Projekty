using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar
{
    public partial class Form1 : Form
    {
        Point SrodekZegara;
        int dlugosc_g, dlugosc_m, dlugosc_s, KatObrotu;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SrodekZegara = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            dlugosc_g = 60;
            dlugosc_m = 90;
            dlugosc_s = 120;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            AntyAliasing(e);
            e.Graphics.FillEllipse(Brushes.LightGray, SrodekZegara.X - 150, SrodekZegara.Y - 150, 300, 300);
            RysowanieTarczy(e);


            ////                       godzinowa
            AntyAliasing(e);
            KatObrotu = ((DateTime.Now.Hour % 12) * 360 / 12) + ((DateTime.Now.Minute % 60) * 360 / 60 / 12);
            var g = e.Graphics.Transform;
            e.Graphics.TranslateTransform(SrodekZegara.X, SrodekZegara.Y);
            e.Graphics.RotateTransform(KatObrotu);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 0, 0, 0, 0 - dlugosc_g);
            e.Graphics.Transform = g;

            ////                        minutowa
            AntyAliasing(e);
            KatObrotu = ((DateTime.Now.Minute % 60) * 360 / 60) + ((DateTime.Now.Second % 60) * 360 / 60 / 60);
            var m = e.Graphics.Transform;
            e.Graphics.TranslateTransform(SrodekZegara.X, SrodekZegara.Y);
            e.Graphics.RotateTransform(KatObrotu);
            e.Graphics.DrawLine(new Pen(Color.Red, 3.5f), 0, 0, 0, 0 - dlugosc_m);
            e.Graphics.Transform = m;

            ////                        sekundowa
            AntyAliasing(e);
            KatObrotu = ((DateTime.Now.Second % 60) * 360 / 60);
            var s = e.Graphics.Transform;
            e.Graphics.TranslateTransform(SrodekZegara.X, SrodekZegara.Y);
            e.Graphics.RotateTransform(KatObrotu);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 0, 0, 0, 0 - dlugosc_s);
            e.Graphics.Transform = s;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            WyswietlanieCzasuLabel.Text = "Czas: " + DateTime.Now.ToString();
            this.Refresh();
        }
        private void RysowanieTarczy(PaintEventArgs cg)
        {
            Point przesuniecie = new Point(140, 130);
            cg.Graphics.DrawString("12", new Font("Ariel", 12), Brushes.Black, new PointF(140 + przesuniecie.X, 3 + przesuniecie.Y));
            cg.Graphics.DrawString("1", new Font("Ariel", 12), Brushes.Black, new PointF(218 + przesuniecie.X, 22 + przesuniecie.Y));
            cg.Graphics.DrawString("2", new Font("Ariel", 12), Brushes.Black, new PointF(263 + przesuniecie.X, 70 + przesuniecie.Y));
            cg.Graphics.DrawString("3", new Font("Ariel", 12), Brushes.Black, new PointF(285 + przesuniecie.X, 140 + przesuniecie.Y));
            cg.Graphics.DrawString("4", new Font("Ariel", 12), Brushes.Black, new PointF(263 + przesuniecie.X, 212 + przesuniecie.Y));
            cg.Graphics.DrawString("5", new Font("Ariel", 12), Brushes.Black, new PointF(218 + przesuniecie.X, 259 + przesuniecie.Y));
            cg.Graphics.DrawString("6", new Font("Ariel", 12), Brushes.Black, new PointF(142 + przesuniecie.X, 279 + przesuniecie.Y));
            cg.Graphics.DrawString("7", new Font("Ariel", 12), Brushes.Black, new PointF(70 + przesuniecie.X, 259 + przesuniecie.Y));
            cg.Graphics.DrawString("8", new Font("Ariel", 12), Brushes.Black, new PointF(22 + przesuniecie.X, 212 + przesuniecie.Y));
            cg.Graphics.DrawString("9", new Font("Ariel", 12), Brushes.Black, new PointF(1 + przesuniecie.X, 140 + przesuniecie.Y));
            cg.Graphics.DrawString("10", new Font("Ariel", 12), Brushes.Black, new PointF(22 + przesuniecie.X, 70 + przesuniecie.Y));
            cg.Graphics.DrawString("11", new Font("Ariel", 12), Brushes.Black, new PointF(70 + przesuniecie.X, 22 + przesuniecie.Y));
            cg.Graphics.FillEllipse(Brushes.Black, SrodekZegara.X - 4, SrodekZegara.Y - 4, 8, 8);
            cg.Graphics.DrawEllipse(new Pen(Color.Black, 4), SrodekZegara.X - 152, SrodekZegara.Y - 152, 302, 302);
        }
        private static void AntyAliasing(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
    }
}
