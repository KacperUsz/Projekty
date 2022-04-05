using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_wyscigowa
{
    public partial class MapaForm : Form
    {
        Droga droga;
        Pojazd auto;
        public MapaForm()
        {
            droga = new Droga();
            auto = new Pojazd();
            InitializeComponent();
            // dodane różne punkty do narysowania drogi
            droga.Punkty.Add(new PointF(0, 150));
            droga.Punkty.Add(new PointF(1600, 150));
            droga.Punkty.Add(new PointF(1600, 500));
            droga.Punkty.Add(new PointF(300, 500));
            droga.Punkty.Add(new PointF(300, 860));
            droga.Punkty.Add(new PointF(2000, 860));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            auto.Dzialaj(0.02);
            Refresh();
        }

        private void MapaForm_Paint(object sender, PaintEventArgs e)
        {
            droga.Rysuj(e.Graphics);
            auto.Rysuj(e.Graphics);
            PredkoscLabel.Text = "Predkosc " + auto.V/5 + " km/h";
        }

        private void MapaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                auto.Gaz();
            }
            else if (e.KeyCode == Keys.S)
            {
                auto.Hamuj();
            }
            else if (e.KeyCode == Keys.A)
            {
                auto.SkrecLewo();
            }
            else if (e.KeyCode == Keys.D)
            {
                auto.SkrecPrawo();
            }
        }

        
    }
}
