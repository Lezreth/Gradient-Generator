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
        /// <summary>
        /// List of color icons shown in their respective row in LstColors.
        /// </summary>
        private ImageList ColorList { get; set; } = new ImageList();

        /// <summary>
        /// Key generator for tracking icons in the color list.
        /// </summary>
        private RandomNumGenerator KeyGenerator { get; set; } = new RandomNumGenerator();

        /// <summary>
        /// Direction to move the selected item(s) in the list.
        /// </summary>
        private enum MoveDirection { Up = -1, Down = 1 };

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Move the selected item(s) in the list.
        /// </summary>
        /// <param name="sender">ListView that contains the item(s) to move.</param>
        /// <param name="direction">Direction to move the item(s).</param>
        private static void MoveListViewItems(ListView sender, MoveDirection direction)
        {
            int dir = (int)direction;
            int opp = dir * -1;

            bool valid = sender.SelectedItems.Count > 0 &&
                ((direction == MoveDirection.Down && (sender.SelectedItems[sender.SelectedItems.Count - 1].Index < sender.Items.Count - 1))
                || (direction == MoveDirection.Up && (sender.SelectedItems[0].Index > 0)));

            if (valid)
            {
                foreach (ListViewItem item in sender.SelectedItems)
                {
                    int index = item.Index + dir;
                    sender.Items.RemoveAt(item.Index);
                    _ = sender.Items.Insert(index, item);
                }
            }
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
            //  Need at least 2 colors to create a gradient
            if (LstColors.Items.Count < 2) { return; }

            //  Create a color from each item in the list
            List<Color> Colors = new List<Color>();
            foreach (ListViewItem item in LstColors.Items)
            {
                string[] Codes = item.Text.Split(',');
                Colors.Add(Color.FromArgb(int.Parse(Codes[0]), int.Parse(Codes[1]), int.Parse(Codes[2]), int.Parse(Codes[3])));
            }

            //  Traverse the list sending pairs to the generator, i.e. 1 & 2, then 2 & 3, then 3 & 4
            //  Add the gradient to the composite list
            List<Color> Gradient = new List<Color>();
            for (int i = 0; i < LstColors.Items.Count - 1; i++)
            {
                int GSize = (int)NumWidth.Value / (Colors.Count - 1);
                Gradient.AddRange(GenerateGradient(Colors[i], Colors[i + 1], GSize));
            }

            using Bitmap bitmap = new Bitmap(Gradient.Count, (int)NumHeight.Value);
            using Graphics graphics = Graphics.FromImage(bitmap);

            //  Create a linear gradient from the composite gradient list
            for (int X = 0; X < Gradient.Count; X++)
            { graphics.DrawLine(new Pen(Gradient[X]), X, 0, X, (int)NumHeight.Value - 1); }

            //  Save & display the gradient
            graphics.Save();
            PictPreview.Image = new Bitmap(bitmap);
        }

        private void BtnAddColor_Click(object sender, EventArgs e)
        {
            using Bitmap bitmap = new Bitmap(32, 32);
            using Graphics graphics = Graphics.FromImage(bitmap);

            //  Create a preview icon of the selected color
            graphics.FillRectangle(new SolidBrush(ClrEdit.Color), new Rectangle(0, 0, 32, 32));
            graphics.Save();

            //  Generate a unique ID for the color
            string ID = KeyGenerator.GetKey().ToString();

            //  Create an icon for the new color and associate the ID to it
            ColorList.Images.Add(ID, new Bitmap(bitmap));

            //  Create a list item and add it to the list along with the ID of the new icon
            string ColorText = ClrEdit.Color.A + "," + ClrEdit.Color.R + "," + ClrEdit.Color.G + "," + ClrEdit.Color.B;
            _ = LstColors.Items.Add(ColorText, ID);

            //  If we have at least 2 colors in the list, generate a gradient
            if (LstColors.Items.Count > 1)
            { BtnGenerateGradient_Click(sender, e); }
        }

        private void BtnRemoveColor_Click(object sender, EventArgs e)
        {
            if (LstColors.SelectedItems.Count > 0)
            {
                while (LstColors.SelectedItems.Count > 0)
                {
                    double Key = double.Parse(LstColors.SelectedItems[0].ImageKey);
                    KeyGenerator.RemoveKey(Key);
                    LstColors.Items.RemoveAt(LstColors.SelectedItems[0].Index);
                }
            }
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
            LstColors.SmallImageList = ColorList;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            { PictPreview.Image.Save(dialog.FileName, ImageFormat.Png); }
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            MoveListViewItems(LstColors, MoveDirection.Up);
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            MoveListViewItems(LstColors, MoveDirection.Down);
        }
    }
}
