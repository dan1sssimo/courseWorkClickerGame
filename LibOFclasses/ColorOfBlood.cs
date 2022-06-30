using System;
using System.Drawing;


namespace LibOFclasses
{
    public abstract class ColorOfBlood
    {
        public static Random rnd = new Random();
        public static Color color;
        public static Color color2;
        public static int prozorist;
        public Color Color
        {
            set;
            get;
        }
        public Color Color2
        {
            set;
            get;
        }
        public int Prozorist
        {
            set;
            get;
        }
        public ColorOfBlood(Color color, Color color2, int prozorist)
        {
            ColorOfBlood.color2 = color2;
            ColorOfBlood.color = color;
            ColorOfBlood.prozorist = prozorist;
        }
        public ColorOfBlood(Color color, int opacity)
        {
            ColorOfBlood.color = color;
            ColorOfBlood.prozorist = opacity;
        }
        public ColorOfBlood() 
        {
            prozorist = rnd.Next(256);
            color = Color.FromArgb(prozorist, 255, 36, 0);
            prozorist = rnd.Next(256);
            color2 = Color.FromArgb(prozorist, rnd.Next(255), rnd.Next(36), 0);
        }
        public ColorOfBlood(ColorOfBlood obj)
        {
            Color = obj.Color;
            Color2 = obj.Color2;
            Prozorist = obj.Prozorist;
        }
        public abstract void Draw(Graphics g);
    }
}
