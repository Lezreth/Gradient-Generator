using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gradient_Generator
{
    /// <summary>
    /// Color anchor.
    /// </summary>
    public class CAnchor
    {
        /// <summary>
        /// Color of the anchor.
        /// </summary>
        public Color AnchorColor { get; set; }

        /// <summary>
        /// Pixel location of the anchor.
        /// </summary>
        public int Pixel { get; set; }

        /// <summary>
        /// Create a new color anchor with the specified parameters.
        /// </summary>
        /// <param name="color">Color to make the anchor.</param>
        /// <param name="pixel">Pixel location of the anchor.</param>
        public CAnchor(Color color, int pixel)
        {
            AnchorColor = color;
            Pixel = pixel;
        }
    }
}
