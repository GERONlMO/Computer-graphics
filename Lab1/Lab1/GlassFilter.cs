using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class GlassFilter : Filters
    {
        private Random random = new Random();
        private GraphicsUnit unit = new GraphicsUnit();

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double rDouble = (random.NextDouble() - 0.5) * 10;

            if (x + rDouble > sourceImage.GetBounds(ref unit).Left &&
                x + rDouble < sourceImage.Width &&
                y + rDouble > sourceImage.GetBounds(ref unit).Top &&
                y + rDouble < sourceImage.Height)
                return sourceImage.GetPixel((int)(x + rDouble), (int)(y + rDouble));
            return Color.Empty;
        }
    }
}
