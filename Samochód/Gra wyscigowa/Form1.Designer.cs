namespace Gra_wyscigowa
{
    partial class MapaForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PredkoscLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PredkoscLabel
            // 
            this.PredkoscLabel.AutoSize = true;
            this.PredkoscLabel.BackColor = System.Drawing.Color.Transparent;
            this.PredkoscLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PredkoscLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PredkoscLabel.ForeColor = System.Drawing.Color.LightPink;
            this.PredkoscLabel.Location = new System.Drawing.Point(0, 0);
            this.PredkoscLabel.Name = "PredkoscLabel";
            this.PredkoscLabel.Size = new System.Drawing.Size(140, 24);
            this.PredkoscLabel.TabIndex = 0;
            this.PredkoscLabel.Text = "Predkosc: ";
            this.PredkoscLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MapaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PredkoscLabel);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "MapaForm";
            this.Text = "Mapa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MapaForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapaForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PredkoscLabel;
    }
}

