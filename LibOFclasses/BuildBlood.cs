using System.Drawing;
using System.Drawing.Drawing2D;

namespace LibOFclasses
{
    public class BuildBlood: ColorOfBlood
    {
        protected int y1, x1, shuruna;
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Shuruna { get; set; }
        public BuildBlood(Color color, Color color2, int prozorist, int x1, int y1) : base(color, color2, prozorist)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public BuildBlood() : base()
        {
            x1 = rnd.Next(400);
            y1 = rnd.Next(600);
            shuruna = rnd.Next(6);
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new LinearGradientBrush(new System.Drawing.Rectangle(0, 0, 375, 375), Color.FromArgb(0,255,0), Color.FromArgb(prozorist, 255,35), LinearGradientMode.ForwardDiagonal);
            g.FillEllipse(brush, x1, y1, shuruna, shuruna);
        }
    }
}
