using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StringArtConsole
{
    static class CanvasPrinter
    {
        public static void PrintCanvas(RoundCanvas canvas)
        {
            using (var map = new Bitmap(1000, 1000))
            using (var gr = Graphics.FromImage(map))
            using (var brush = new SolidBrush(Color.Black))
            {

                foreach (var nail in canvas.Nails)
                {
                    var circleCentreX = (int)(nail.X);
                    var circleCentreY = (int)(nail.Y);

                    gr.FillEllipse(brush, circleCentreX - 3, circleCentreY - 3, 7, 7);

                }

                map.Save("circle.bmp");
            }
        }
    }
}
