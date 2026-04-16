namespace pong
{
    public partial class Form1 : Form
    {
        int layerY = 150;
        int iY = 150;

        int allX = 200;
        int allY = 200;

        int allspeedX = 4;
        int allspeedY = 4;

        int layerscore = 0;
        int iscore = 0;

        bool oveUp, oveDown;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, 10, layerY, 10, 80);
            g.FillRectangle(Brushes.White, this.ClientSize.Width - 20, iY, 10, 80);

            g.FillEllipse(Brushes.White, allX, allY, 10, 10);

            g.DrawString($"Gracz(TY): {layerscore}", new Font("Arial", 12), Brushes.White, 50, 10);
            g.DrawString($"AIAI(AI): {iscore}", new Font("Arial", 12), Brushes.White, 400, 10);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) oveUp = true;
            if (e.KeyCode == Keys.Down) oveDown = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) oveUp = false;
            if (e.KeyCode == Keys.Down) oveDown = false;
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            if (oveUp && layerY > 0) layerY -= 6;
            if (oveDown && layerY < this.ClientSize.Height - 80) layerY += 6;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        


    }
}
