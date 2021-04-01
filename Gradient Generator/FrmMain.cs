using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gradient_Generator;

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
        #region Constants

        /// <summary>
        /// Error message for when a file cannot be loaded.
        /// </summary>
        private static string FileLoadError => "Could not load the configuration.  The file might be in the wrong format.";

        #endregion
        #region Constructor, Form Load, Form Closing

        public FrmMain(string Filename = default)
        {
            InitializeComponent();

            Show();

            if (!string.IsNullOrEmpty(Filename))
            { LoadColorList(Filename); }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClrEdit.Color = Color.FromArgb(255, 225, 50, 50);
            ClrEdit_ColorChanged(sender, e);
            LstColors.SmallImageList = ColorList;

            LstGradientType.Items.AddRange(Enum.GetNames(typeof(GradientType)));
            LstGradientType.SelectedIndex = 0;
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
            List<CAnchor> Colors = new List<CAnchor>();
            foreach (ListViewItem item in LstColors.Items)
            {
                Colors.Add(new CAnchor(Color.FromArgb(int.Parse(item.Text), int.Parse(item.SubItems[0].Text), int.Parse(item.SubItems[1].Text), int.Parse(item.SubItems[2].Text)),
                    int.Parse(item.SubItems[3].Text)));
            }

            _ = Enum.TryParse(LstGradientType.Text, out GradientType GType);

            Task task = Task.Run(() => GradientGenSystem.GradientBitmap(Colors, (int)NumWidth.Value, (int)NumHeight.Value,
                GType, TokenSource.Token), TokenSource.Token)
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

        /// <summary>
        /// Save the color list to a configuration file.
        /// </summary>
        /// <param name="Filename">Name of the file to save the list to.</param>
        private void SaveConfiguration(string Filename)
        {
            StringBuilder builder = new StringBuilder();
            _ = builder.AppendLine(NumWidth.Value.ToString());
            _ = builder.AppendLine(NumHeight.Value.ToString());

            foreach (ListViewItem item in LstColors.Items)
            { _ = builder.AppendLine(item.Text); }

            File.WriteAllText(Filename, builder.ToString());
        }

        /// <summary>
        /// Load a color list from the specified file.
        /// </summary>
        /// <param name="Filename">Name of the file to load.</param>
        private void LoadColorList(string Filename)
        {
            try
            {
                decimal OldWidth = NumWidth.Value;
                decimal OldHeight = NumHeight.Value;

                List<string> FileContents = new List<string>(File.ReadAllLines(Filename));
                if (decimal.TryParse(FileContents[0], out decimal FWidth))
                { NumWidth.Value = FWidth; }
                else
                {
                    NumWidth.Value = OldWidth;
                    _ = MessageBox.Show(FileLoadError);
                    return;
                }

                if (decimal.TryParse(FileContents[1], out decimal FHeight))
                { NumHeight.Value = FHeight; }
                else
                {
                    NumWidth.Value = OldWidth;
                    NumHeight.Value = OldHeight;
                    _ = MessageBox.Show(FileLoadError);
                    return;
                }

                FileContents.RemoveRange(0, 2);
                LstColors.Items.Clear();
                foreach (string item in FileContents)
                {
                    //  Traverse the remaining items in the list and parse them into color codes, then add them to the list view
                    string[] Codes = item.Split(',');
                    if (int.TryParse(Codes[0], out int A) && int.TryParse(Codes[1], out int R) && int.TryParse(Codes[2], out int G) && int.TryParse(Codes[3], out int B))
                    { AddColor(Color.FromArgb(A, R, G, B)); }
                    else
                    {
                        _ = MessageBox.Show(FileLoadError);
                        return;
                    }
                }
            }
            catch (Exception)
            { _ = MessageBox.Show(FileLoadError); }
        }

        /// <summary>
        /// Add a new color to the list and optionally (re)generate the gradient.
        /// </summary>
        /// <param name="NColor">Color to add.</param>
        private void AddColor(Color NColor)
        {
            //  Generate a unique ID for the color
            string ID = KeyGenerator.GetKey().ToString();

            //  Create an icon for the new color and associate the ID to it
            ColorList.Images.Add(ID, new Bitmap(GetThumbnail(NColor, 32, 32)));

            //  Create a list item and add it to the list along with the ID of the new icon
            _ = LstColors.Items.Add(new ListViewItem(new string[] { NColor.A.ToString(), NColor.R.ToString(), NColor.G.ToString(), NColor.B.ToString() }, ID));

            //  Generate a gradient
            GetGradient();
        }

        #endregion
        #region UI Event Handlers

        private void BtnGenerateGradient_Click(object sender, EventArgs e)
        {
            GetGradient();
        }

        private void BtnAddColor_Click(object sender, EventArgs e)
        {
            AddColor(ClrEdit.Color);
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

                //  Generate a gradient
                GetGradient();
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
            {
                PictPreview.Image.Save(dialog.FileName, ImageFormat.Png);

                if (ChkSaveConfig.Checked)
                {
                    FileInfo info = new FileInfo(dialog.FileName);
                    SaveConfiguration(info.FullName.Replace(info.Extension, ".ColorList"));
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog
            { Filter = "Color List (*.ColorList)|*.ColorList" };

            if (dialog.ShowDialog() == DialogResult.OK)
            { LoadColorList(dialog.FileName); }
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            MoveListViewItems(LstColors, MoveDirection.Up);

            //  Generate a gradient
            GetGradient();
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            MoveListViewItems(LstColors, MoveDirection.Down);

            //  Generate a gradient
            GetGradient();
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LstColors.SelectedItems)
            { _ = LstColors.Items.Add((ListViewItem)item.Clone()); }

            //  Generate a gradient
            GetGradient();
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
