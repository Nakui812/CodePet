using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePet
{
    public partial class Form1 : Form
    {
        // Statistiche del Tamagotchi
        private int hunger = 50;
        private int happiness = 50;
        private int energy = 50;
        private int cleanliness = 50;

        // Stato attuale
        private string currentState = "idle";
        private int frame = 0;

        

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            pixelProgressBar1.PixelColor = Color.OrangeRed;
            pixelProgressBar2.PixelColor = Color.HotPink;
            pixelProgressBar3.PixelColor = Color.DodgerBlue;
            
            Timer animationTimer = new Timer();
            animationTimer.Interval = 200;
            animationTimer.Tick += (s, e) => {
                pixelProgressBar1.Animate();
                pixelProgressBar2.Animate();
                pixelProgressBar3.Animate();
            };
            animationTimer.Start();
            pixelProgressBar1.Size = new Size(120, 12);
            pixelProgressBar2.Size = new Size(120, 12);
            pixelProgressBar3.Size = new Size(120, 12);
        }

        private void InitializeGame()
        {
            // Configura i progress bar
            pixelProgressBar1.Maximum = 100;
            pixelProgressBar2.Maximum = 100;
            pixelProgressBar3.Maximum = 100;

            // Imposta il timer per l'update del gioco
            Timer gameTimer = new Timer();
            gameTimer.Interval = 1000; // 1 secondo
            gameTimer.Tick += GameUpdate;
            gameTimer.Start();

            // Timer per l'animazione
            Timer animationTimer = new Timer();
            animationTimer.Interval = 300; // 0.3 secondi
            animationTimer.Tick += AnimateTamagotchi;
            animationTimer.Start();

            UpdateStats();
            DrawTamagotchi();
        }
        private void GameUpdate(object sender, EventArgs e)
        {
            // Diminuisci gradualmente le statistiche
            hunger = Math.Max(0, hunger - 2);
            happiness = Math.Max(0, happiness - 1);
            energy = Math.Max(0, energy - 1);
            cleanliness = Math.Max(0, cleanliness - 1);

            // Cambia stato casualmente
            if (new Random().Next(0, 100) < 5)
            {
                string[] states = { "idle", "happy", "sad", "eating", "sleeping" };
                currentState = states[new Random().Next(0, states.Length)];
            }

            UpdateStats();
            DrawTamagotchi();

        }
        private void AnimateTamagotchi(object sender, EventArgs e)
        {
            frame = (frame + 1) % 2; // Alterna tra 0 e 1 per l'animazione
            DrawTamagotchi();
        }

        private void UpdateStats()
        {
            pixelProgressBar1.Value = hunger;
            pixelProgressBar2.Value = energy;
            pixelProgressBar3.Value = happiness;
        }

        private void DrawTamagotchi()
        {
            Bitmap bmp = new Bitmap(pbPet.Width, pbPet.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);

                // Disegna lo sfondo
                g.FillRectangle(Brushes.White, 50, 50, 200, 200);

                // Disegna il Tamagotchi in pixel art
                DrawPixelArtTamagotchi(g, currentState, frame);
            }

            pbPet.Image = bmp;
        }
        private void DrawPixelArtTamagotchi(Graphics g, string state, int frame)
        {
            // Definiamo alcuni colori
            Color bodyColor = Color.FromArgb(255, 200, 150); // Colore pelle
            Color eyeColor = Color.Black;
            Color sadColor = Color.Blue;
            Color happyColor = Color.Red;
            Color eatingColor = Color.Green;

            // Corpo base (sempre visibile)
            g.FillRectangle(new SolidBrush(bodyColor), 100, 100, 100, 100); // Corpo
            g.FillEllipse(new SolidBrush(bodyColor), 100, 80, 40, 40); // Testa sinistra
            g.FillEllipse(new SolidBrush(bodyColor), 160, 80, 40, 40); // Testa destra

            // Occhi (variano in base allo stato)
            if (state == "sleeping")
            {
                // Occhi chiusi
                g.DrawLine(new Pen(eyeColor, 3), 120, 100, 130, 100);
                g.DrawLine(new Pen(eyeColor, 3), 170, 100, 180, 100);
            }
            else
            {
                // Occhi aperti
                g.FillRectangle(new SolidBrush(eyeColor), 120, 95, 10, 10);
                g.FillRectangle(new SolidBrush(eyeColor), 170, 95, 10, 10);
            }

            // Bocca (varia in base allo stato)
            switch (state)
            {
                case "happy":
                    g.DrawArc(new Pen(happyColor, 3), 130, 120, 40, 20, 0, 180);
                    break;
                case "sad":
                    g.DrawArc(new Pen(sadColor, 3), 130, 140, 40, 20, 180, 180);
                    break;
                case "eating":
                    // Animazione mangiare
                    if (frame == 0)
                    {
                        g.FillRectangle(new SolidBrush(eatingColor), 140, 130, 20, 10);
                    }
                    else
                    {
                        g.FillRectangle(new SolidBrush(eatingColor), 140, 125, 20, 15);
                    }
                    break;
                case "sleeping":
                    // Zzz per dormire
                    g.DrawString("Zzz", new Font("Arial", 12), Brushes.Blue, 140, 150);
                    break;
                default: // idle
                    g.DrawLine(new Pen(eyeColor, 2), 140, 130, 160, 130);
                    break;
            }
        }

        private void btnMangia_Click(object sender, EventArgs e)
        {
            hunger = Math.Min(100, hunger + 20);
            cleanliness = Math.Max(0, cleanliness - 10);
            currentState = "eating";
            frame = 0;
            UpdateStats();
            DrawTamagotchi();
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            happiness = Math.Min(100, happiness + 15);
            energy = Math.Max(0, energy - 10);
            currentState = "happy";
            UpdateStats();
            DrawTamagotchi();
        }

        private void btnDormi_Click(object sender, EventArgs e)
        {
            energy = Math.Min(100, energy + 30);
            hunger = Math.Max(0, hunger - 10);
            currentState = "sleeping";
            UpdateStats();
            DrawTamagotchi();
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            cleanliness = Math.Min(100, cleanliness + 30);
            happiness = Math.Min(100, happiness + 5);
            UpdateStats();
            DrawTamagotchi();
        }
    }

    public class PixelProgressBar : Control
    {
        private int _value = 50;
        public int Value
        {
            get => _value;
            set { _value = (value < 0) ? 0 : (value > 100) ? 100 : value; }
        }

        private Color _pixelColor = Color.LimeGreen;
        public Color PixelColor
        {
            get => _pixelColor;
            set { _pixelColor = value; Invalidate(); }
        }

        public int Maximum { get; internal set; }

        public PixelProgressBar()
        {
            this.Size = new Size(100, 15);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Calcola quanti blocchi disegnare
            int blockSize = 6; // Dimensione di ogni blocco pixel
            int spacing = 2;   // Spazio tra i blocchi
            int totalBlocks = 10; // Numero totale di blocchi visibili

            int filledBlocks = (int)Math.Round((double)Value / 100 * totalBlocks);

            // Disegna lo sfondo
            g.Clear(Color.FromArgb(70, 70, 70)); // Grigio scuro

            // Disegna i blocchi pieni
            for (int i = 0; i < filledBlocks; i++)
            {
                int x = i * (blockSize + spacing);
                g.FillRectangle(new SolidBrush(PixelColor),
                               x, 0,
                               blockSize, this.Height);
            }

            // Disegna i blocchi vuoti (opzionale)
            for (int i = filledBlocks; i < totalBlocks; i++)
            {
                int x = i * (blockSize + spacing);
                g.FillRectangle(new SolidBrush(Color.FromArgb(100, 100, 100)),
                               x, 0,
                               blockSize, this.Height);
            }

            // Bordo pixel art
            g.DrawRectangle(new Pen(Color.Black, 1),
                            0, 0,
                            this.Width - 1, this.Height - 1);
        }

        private int _animationOffset = 0;
        public void Animate()
        {
            _animationOffset = (_animationOffset + 1) % 3;
            Invalidate();
        }

       
    }
}
