using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gradient_Maker
{
    public class GradientGenerator
    {
        /// <summary>
        /// Generate a color gradient transitioning from the first color to the second.
        /// </summary>
        /// <param name="Color1">First color in the gradient. Appears on the left side.</param>
        /// <param name="Color2">Second color in the gradient. Appears on the right side.</param>
        /// <param name="GradientSize">Width of the gradient in pixels.</param>
        /// <returns>List of colors transitioning from the left color to the right color.</returns>
        private static List<Color> GenerateGradient(Color Color1, Color Color2, int GradientSize)
        {
            int aMin = Color1.A;
            int aMax = Color2.A;
            int rMin = Color1.R;
            int rMax = Color2.R;
            int gMin = Color1.G;
            int gMax = Color2.G;
            int bMin = Color1.B;
            int bMax = Color2.B;

            List<Color> ColorList = new List<Color>();
            for (int i = 0; i < GradientSize; i++)
            {
                int aAverage = aMin + ((aMax - aMin) * i / GradientSize);
                int rAverage = rMin + ((rMax - rMin) * i / GradientSize);
                int gAverage = gMin + ((gMax - gMin) * i / GradientSize);
                int bAverage = bMin + ((bMax - bMin) * i / GradientSize);
                ColorList.Add(Color.FromArgb(aAverage, rAverage, gAverage, bAverage));
            }

            return ColorList;
        }

        /// <summary>
        /// Generate the gradient between the supplied colors and return the result as a bitmap.
        /// </summary>
        /// <param name="Colors"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static Bitmap GradientBitmap(List<Color> Colors, int Width, int Height, CancellationToken Token)
        {
            if (Colors is null) { return null; }

            //  Traverse the list sending pairs to the generator, i.e. 1 & 2, then 2 & 3, then 3 & 4
            //  Add the gradient to the composite list
            List<Color> Gradient = new List<Color>();
            for (int i = 0; i < Colors.Count - 1; i++)
            {
                if (Token.IsCancellationRequested) { return null; }

                int GSize = Width / (Colors.Count - 1);
                Gradient.AddRange(GenerateGradient(Colors[i], Colors[i + 1], GSize));
            }

            using Bitmap bitmap = new Bitmap(Gradient.Count, Height);
            using Graphics graphics = Graphics.FromImage(bitmap);

            //  Create a linear gradient from the composite gradient list
            for (int X = 0; X < Gradient.Count; X++)
            {
                if (Token.IsCancellationRequested) { return null; }

                graphics.DrawLine(new Pen(Gradient[X]), X, 0, X, Height - 1);
            }

            //  Save & display the gradient
            graphics.Save();

            return new Bitmap(bitmap);
        }
    }
}
