using System;

namespace Orientator
{
    struct Point
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Point(double w, double h)
        {
            Height = h;
            Width = w;
        }

        private static Point DeltasA2B(Point a, Point b)
        {
            double corr = Math.Cos(a.Height * Math.PI / 180);
            Point diffs = new Point((b.Width - a.Width)*corr, b.Height - a.Height);

            return diffs;
        }

        public static string GetAngle(Point a, Point b)
        {            
            Point diff = DeltasA2B(a, b);
            double angle = Math.Abs(Math.Atan(diff.Height / diff.Width)*180/Math.PI);

            if (diff.Height >= 0) angle = 90 - angle;
            else angle = 90 + angle;

            angle = Math.Round(angle,1);

            return ((diff.Width < 0) ? $"W {angle}" : $"E {angle}");
        }
    }
}
