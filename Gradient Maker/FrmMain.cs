using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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


        private List<Color> GenerateGradient(Color Color1, Color Color2, int GradientSize)
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

        private void BtnGenerateGradient_Click(object sender, EventArgs e)
        {
            if (LstColors.Items.Count < 2) { return; }

            List<Color> Colors = new List<Color>();
            foreach (string item in LstColors.Items)
            {
                string[] Codes = item.Split(',');
                Colors.Add(Color.FromArgb(int.Parse(Codes[0]), int.Parse(Codes[1]), int.Parse(Codes[2]), int.Parse(Codes[3])));
            }

            List<Color> Gradient = new List<Color>();
            for (int i = 0; i < LstColors.Items.Count - 1; i++)
            {
                int GSize = (int)NumWidth.Value / (Colors.Count - 1);
                Gradient.AddRange(GenerateGradient(Colors[i], Colors[i + 1], GSize));
            }

            using Bitmap bitmap = new Bitmap(Gradient.Count, (int)NumHeight.Value);
            using Graphics graphics = Graphics.FromImage(bitmap);

            for (int X = 0; X < Gradient.Count; X++)
            { graphics.DrawLine(new Pen(Gradient[X]), X, 0, X, (int)NumHeight.Value - 1); }

            graphics.Save();
            PictPreview.Image = new Bitmap(bitmap);
        }

        private void BtnAddColor_Click(object sender, EventArgs e)
        {
            _ = LstColors.Items.Add(ClrEdit.Color.A + "," + ClrEdit.Color.R + "," + ClrEdit.Color.G + "," + ClrEdit.Color.B);
        }

        private void BtnRemoveColor_Click(object sender, EventArgs e)
        {
            if (LstColors.SelectedIndex > -1)
            { LstColors.Items.RemoveAt(LstColors.SelectedIndex); }
        }

        private void ClrEdit_ColorChanged(object sender, EventArgs e)
        {
            using Bitmap bitmap = new Bitmap(PictColor.Width, PictColor.Height);
            using Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(new SolidBrush(ClrEdit.Color), new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            graphics.Save();

            PictColor.Image = new Bitmap(bitmap);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClrEdit.Color = Color.FromArgb(255, 225, 50, 50);
            ClrEdit_ColorChanged(sender, e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            { PictPreview.Image.Save(dialog.FileName, ImageFormat.Png); }
        }
    }
}
