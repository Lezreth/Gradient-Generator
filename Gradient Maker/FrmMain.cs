using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradient_Maker
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void GenerateGradient(Color Color1, Color Color2, int GradientSize)
        {
            int rMax = Color1.R;
            int rMin = Color2.R;
            int gMax = Color1.G;
            int gMin = Color2.G;
            int bMax = Color1.B;
            int bMin = Color2.B;

            List<Color> ColorList = new List<Color>();
            for (int i = 0; i < GradientSize; i++)
            {
                int rAverage = rMin + ((rMax - rMin) * i / GradientSize);
                int gAverage = gMin + ((gMax - gMin) * i / GradientSize);
                int bAverage = bMin + ((bMax - bMin) * i / GradientSize);
                ColorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }
        }

        private void BtnGenerateColors_Click(object sender, EventArgs e)
        {
            GenerateGradient();
        }

        private void BtnAddColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new ColorDialog();

        }
    }
}
