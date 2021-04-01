using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradient_Generator
{
    public partial class GradientBar : Control
    {
        public GradientBar()
        {
            InitializeComponent();

            Size = new Size(50, 200);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, Width, Height));

            base.OnPaint(pe);
        }
    }
}
