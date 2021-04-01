using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace Gradient_Generator
{
    /// <summary>
    /// Types of gradients that can be generated.
    /// </summary>
    public enum GradientType { Linear, Radial/*, Angle*/, Reflected, Diamond }

    /// <summary>
    /// Gradient generation methods.
    /// </summary>
    public static class GradientGenSystem
    {

        /// <summary>
        /// Generate a color gradient transitioning from the first color to the second.
        /// </summary>
        /// <param name="Color1">First color in the gradient. Appears on the left side.</param>
        /// <param name="Color2">Second color in the gradient. Appears on the right side.</param>
        /// <param name="GradientSize">Width of the gradient in pixels.</param>
        /// <returns>List of colors transitioning from the left color to the right color.</returns>
        private static List<CAnchor> GenerateGradient(CAnchor Color1, CAnchor Color2)
        {
            int aMin = Color1.AnchorColor.A;
            int aMax = Color2.AnchorColor.A;
            int rMin = Color1.AnchorColor.R;
            int rMax = Color2.AnchorColor.R;
            int gMin = Color1.AnchorColor.G;
            int gMax = Color2.AnchorColor.G;
            int bMin = Color1.AnchorColor.B;
            int bMax = Color2.AnchorColor.B;

            List<CAnchor> ColorList = new List<CAnchor>();
            int GradientSize = Color2.Pixel - Color1.Pixel;

            for (int i = 0; i <= GradientSize; i++)
            {
                int aAverage = aMin + ((aMax - aMin) * i / GradientSize);
                int rAverage = rMin + ((rMax - rMin) * i / GradientSize);
                int gAverage = gMin + ((gMax - gMin) * i / GradientSize);
                int bAverage = bMin + ((bMax - bMin) * i / GradientSize);
                ColorList.Add(new CAnchor(Color.FromArgb(aAverage, rAverage, gAverage, bAverage), i + Color1.Pixel));
            }

            return ColorList;
        }

        /// <summary>
        /// Generate the gradient between the supplied colors and return the result as a bitmap.
        /// </summary>
        /// <param name="Colors">List of the colors and their pixel locations.</param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="Shape"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static Bitmap GradientBitmap(List<CAnchor> Colors, int Width, int Height, GradientType Shape, CancellationToken Token)
        {
            if (Colors is null) { return null; }

            //  Traverse the list sending pairs to the generator, i.e. 1 & 2, then 2 & 3, then 3 & 4.
            //  Add the gradient to the composite list.
            List<CAnchor> Gradient = new List<CAnchor>();

            //  Add the pixel color values from pixel 0 to the pixel location of the first color.
            Gradient.AddRange(GenerateGradient(new CAnchor(Colors[0].AnchorColor, 0), Colors[0]));

            for (int i = 0; i < Colors.Count - 1; i++)
            {
                if (Token.IsCancellationRequested) { return null; }

                List<CAnchor> NRange = GenerateGradient(Colors[i], Colors[i + 1]);
                Gradient.AddRange(NRange.GroupBy(x => x.Pixel).Select(x => x.First()).ToList());
            }

            //  Add the pixel color values from pixel 0 to the pixel location of the first color.
            List<CAnchor> LRange = GenerateGradient(Colors.Last(), new CAnchor(Colors.Last().AnchorColor, Width));
            Gradient.AddRange(LRange.GroupBy(x => x.Pixel).Select(x => x.First()).ToList());

            //!  -------------------------------------------------------------------------------------------------------

            //  Generate the bitmap.
            using Bitmap bitmap = new Bitmap(Gradient.Count, Height);
            using Graphics graphics = Graphics.FromImage(bitmap);

            //  Create a linear gradient from the composite gradient list
            double Radius = Math.Sqrt(Math.Pow(Width / 2.0, 2.0) + Math.Pow(Height / 2.0, 2.0));
            if (Shape == GradientType.Linear || Shape == GradientType.Reflected || Shape == GradientType.Diamond)
            {
                for (int X = 0; X < Gradient.Count; X++)
                {
                    if (Token.IsCancellationRequested) { return null; }

                    switch (Shape)
                    {
                        case GradientType.Linear:
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), X, 0, X, Height - 1);
                            break;
                        //case GradientType.Angle:  //  Required Location Unknown
                        //    graphics.DrawLine(new Pen(Gradient[X]),
                        //        Width / 2, Height / 2, Convert.ToSingle(Radius * Math.Cos(X * Math.PI / 180)), Convert.ToSingle(Radius * Math.Sin(X * Math.PI / 180)));
                        //    break;
                        case GradientType.Reflected:
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), Convert.ToSingle((Width / 2.0) - X), 0, Convert.ToSingle((Width / 2.0) - X), Height);
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), Convert.ToSingle((Width / 2.0) + X), 0, Convert.ToSingle((Width / 2.0) + X), Height);
                            break;
                        case GradientType.Diamond:
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), (Width / 2) - X, Width / 2, Width / 2, (Width / 2) - X);
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), (Width / 2) - X, Width / 2, Width / 2, (Width / 2) + X);
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), (Width / 2) + X, Width / 2, Width / 2, (Width / 2) - X);
                            graphics.DrawLine(new Pen(Gradient[X].AnchorColor), (Width / 2) + X, Width / 2, Width / 2, (Width / 2) + X);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                for (int X = Gradient.Count - 1; X >= 0; X--)
                {
                    if (Token.IsCancellationRequested) { return null; }

                    switch (Shape)
                    {
                        case GradientType.Radial:
                            graphics.FillEllipse(new SolidBrush(Gradient[X].AnchorColor), (Width / 2) - X, (Height / 2) - X, X * 2, X * 2);
                            break;
                        //case GradientType.Angle:  //  Required Location Unknown
                        //    graphics.DrawLine(new Pen(Gradient[X]),
                        //        Width / 2, Height / 2, Convert.ToSingle(Radius * Math.Cos(X * Math.PI / 180)), Convert.ToSingle(Radius * Math.Sin(X * Math.PI / 180)));
                        //    break;
                        default:
                            break;
                    }
                }
            }




            //  Save & display the gradient
            graphics.Save();

            return new Bitmap(bitmap);
        }
    }
}
