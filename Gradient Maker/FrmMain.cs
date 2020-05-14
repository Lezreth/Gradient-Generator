using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradient_Maker
{
    public partial class FrmMain : Form
    {
        #region Properties

        /// <summary>
        /// List of color icons shown in their respective row in LstColors.
        /// </summary>
        private ImageList ColorList { get; set; } = new ImageList();

        /// <summary>
        /// Key generator for tracking icons in the color list.
        /// </summary>
        private RandomNumGenerator KeyGenerator { get; set; } = new RandomNumGenerator();

        /// <summary>
        /// Source for a token to allow the asynchronous operations to be canceled.
        /// </summary>
        private CancellationTokenSource TokenSource { get; set; } = new CancellationTokenSource();

        #endregion
        #region Enumerations

        /// <summary>
        /// Direction to move the selected item(s) in the list.
        /// </summary>
        private enum MoveDirection { Up = -1, Down = 1 };

        #endregion
        #region Constructor, Form Load, Form Closing

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClrEdit.Color = Color.FromArgb(255, 225, 50, 50);
            ClrEdit_ColorChanged(sender, e);
            LstColors.SmallImageList = ColorList;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TokenSource.Cancel();
        }

        #endregion
        #region Methods

        /// <summary>
        /// Move the selected item(s) in the list.
        /// </summary>
        /// <param name="sender">ListView that contains the item(s) to move.</param>
        /// <param name="direction">Direction to move the item(s).</param>
        private static void MoveListViewItems(ListView sender, MoveDirection direction)
        {
            int dir = (int)direction;

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

        /// <summary>
        /// Generate the gradient and display it in the picture box.
        /// </summary>
        private async void GetGradient()
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

            Task task = Task.Run(() => GradientGenerator.GradientBitmap(Colors, (int)NumWidth.Value, (int)NumHeight.Value, TokenSource.Token), TokenSource.Token)
                .ContinueWith((prev) => { if (prev.Result != null) { PictPreview.Image = new Bitmap(prev.Result); } });
            await Task.WhenAll(task);
        }

        /// <summary>
        /// Create a thumbnail image of the specified color and size.
        /// </summary>
        /// <param name="TColor">Color of the thumbnail.</param>
        /// <param name="TWidth">Width of the thumbnail.</param>
        /// <param name="THeight">Height of the thumbnail.</param>
        /// <returns>Thumbnail image.</returns>
        private Bitmap GetThumbnail(Color TColor, int TWidth, int THeight)
        {
            using Bitmap bitmap = new Bitmap(TWidth, THeight);
            using Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(new SolidBrush(TColor), new Rectangle(0, 0, TWidth, THeight));
            graphics.Save();

            return new Bitmap(bitmap);
        }

        #endregion
        #region UI Event Handlers

        private void BtnGenerateGradient_Click(object sender, EventArgs e)
        {
            GetGradient();
        }

        private void BtnAddColor_Click(object sender, EventArgs e)
        {
            //  Generate a unique ID for the color
            string ID = KeyGenerator.GetKey().ToString();

            //  Create an icon for the new color and associate the ID to it
            ColorList.Images.Add(ID, new Bitmap(GetThumbnail(ClrEdit.Color, 32, 32)));

            //  Create a list item and add it to the list along with the ID of the new icon
            string ColorText = ClrEdit.Color.A + "," + ClrEdit.Color.R + "," + ClrEdit.Color.G + "," + ClrEdit.Color.B;
            _ = LstColors.Items.Add(ColorText, ID);

            //  If we have at least 2 colors in the list, generate a gradient
            if (LstColors.Items.Count > 1 && ChkAutoGenerate.Checked)
            { GetGradient(); }
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

                //  If we have at least 2 colors in the list, generate a gradient
                if (LstColors.Items.Count > 1 && ChkAutoGenerate.Checked)
                { GetGradient(); }
            }
        }

        private async void ClrEdit_ColorChanged(object sender, EventArgs e)
        {
            Color color = ClrEdit.Color;
            int bWidth = PictColor.Width;
            int bHeight = PictColor.Height;

            Bitmap bitmap = await Task.Run(() => GetThumbnail(color, bWidth, bHeight), TokenSource.Token).ConfigureAwait(true);
            PictColor.Image = new Bitmap(bitmap);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog
            { Filter = "PNG Files (*.png)|*.png" };

            if (dialog.ShowDialog() == DialogResult.OK)
            { PictPreview.Image.Save(dialog.FileName, ImageFormat.Png); }
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            MoveListViewItems(LstColors, MoveDirection.Up);

            //  If we have at least 2 colors in the list, generate a gradient
            if (LstColors.Items.Count > 1 && ChkAutoGenerate.Checked)
            { GetGradient(); }
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            MoveListViewItems(LstColors, MoveDirection.Down);

            //  If we have at least 2 colors in the list, generate a gradient
            if (LstColors.Items.Count > 1 && ChkAutoGenerate.Checked)
            { GetGradient(); }
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LstColors.SelectedItems)
            { _ = LstColors.Items.Add((ListViewItem)item.Clone()); }

            //  If we have at least 2 colors in the list, generate a gradient
            if (LstColors.Items.Count > 1 && ChkAutoGenerate.Checked)
            { GetGradient(); }
        }

        private void LstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstColors.SelectedItems.Count > 0)
            {
                BtnRemoveColor.Enabled = true;
                BtnDuplicate.Enabled = true;
            }
            else
            {
                BtnRemoveColor.Enabled = false;
                BtnDuplicate.Enabled = false;
            }
        }

        #endregion
    }
}
