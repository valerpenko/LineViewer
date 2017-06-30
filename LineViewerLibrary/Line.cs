using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LineViewerLibrary
{
    public class Line
    {
        private double x1, y1;
        private double x2, y2;
        private Color color;
      

        public Line(double px1, double py1, double x2, double y2)
        {   x1 = px1;
            y1 = py1;
            this.x2 = x2;
            this.y2 = y2;

            Random r = new Random();
            int c = r.Next(0, 7);
            switch (c)
            {
                case 0: color= Color.Red; break;
                case 1: color = Color.Orange; break;
                case 2: color = Color.Yellow; break;
                default: color = Color.Green; break;
            }
        }
        public PointF P1()
        {
            return new PointF(Convert.ToSingle(x1), Convert.ToSingle(y1));
        }
        public PointF P2()
        {
            return new PointF(Convert.ToSingle(x2), Convert.ToSingle(y2));
        }
        public Color LineColor()
        {
            return color;
        }
    }
}
