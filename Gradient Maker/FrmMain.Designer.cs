namespace Gradient_Maker
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblWidth = new System.Windows.Forms.Label();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.PictPreview = new Cyotek.Windows.Forms.ImageBox();
            this.BtnRemoveColor = new System.Windows.Forms.Button();
            this.BtnAddColor = new System.Windows.Forms.Button();
            this.BtnGenerateGradient = new System.Windows.Forms.Button();
            this.LstColors = new System.Windows.Forms.ListBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.NumHeight = new System.Windows.Forms.NumericUpDown();
            this.PictColor = new System.Windows.Forms.PictureBox();
            this.ClrEdit = new Cyotek.Windows.Forms.ColorEditor();
            this.ClrWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.ClrManager = new Cyotek.Windows.Forms.ColorEditorManager();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictColor)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 5;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.Controls.Add(this.LblWidth, 2, 0);
            this.TableMain.Controls.Add(this.NumWidth, 3, 0);
            this.TableMain.Controls.Add(this.PictPreview, 0, 4);
            this.TableMain.Controls.Add(this.BtnRemoveColor, 0, 3);
            this.TableMain.Controls.Add(this.BtnAddColor, 0, 2);
            this.TableMain.Controls.Add(this.BtnGenerateGradient, 0, 0);
            this.TableMain.Controls.Add(this.LstColors, 1, 0);
            this.TableMain.Controls.Add(this.LblHeight, 2, 1);
            this.TableMain.Controls.Add(this.NumHeight, 3, 1);
            this.TableMain.Controls.Add(this.PictColor, 4, 0);
            this.TableMain.Controls.Add(this.ClrEdit, 3, 2);
            this.TableMain.Controls.Add(this.ClrWheel, 2, 2);
            this.TableMain.Controls.Add(this.BtnSave, 0, 1);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 5;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Size = new System.Drawing.Size(1084, 561);
            this.TableMain.TabIndex = 0;
            // 
            // LblWidth
            // 
            this.LblWidth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(410, 8);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(70, 13);
            this.LblWidth.TabIndex = 4;
            this.LblWidth.Text = "Width (pixels)";
            // 
            // NumWidth
            // 
            this.NumWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumWidth.Location = new System.Drawing.Point(486, 4);
            this.NumWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumWidth.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumWidth.Name = "NumWidth";
            this.NumWidth.Size = new System.Drawing.Size(120, 20);
            this.NumWidth.TabIndex = 5;
            this.NumWidth.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // PictPreview
            // 
            this.TableMain.SetColumnSpan(this.PictPreview, 5);
            this.PictPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictPreview.Location = new System.Drawing.Point(3, 308);
            this.PictPreview.Name = "PictPreview";
            this.PictPreview.Size = new System.Drawing.Size(1078, 250);
            this.PictPreview.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.PictPreview.TabIndex = 6;
            // 
            // BtnRemoveColor
            // 
            this.BtnRemoveColor.Location = new System.Drawing.Point(3, 91);
            this.BtnRemoveColor.Name = "BtnRemoveColor";
            this.BtnRemoveColor.Size = new System.Drawing.Size(100, 23);
            this.BtnRemoveColor.TabIndex = 9;
            this.BtnRemoveColor.Text = "Remove Color";
            this.BtnRemoveColor.UseVisualStyleBackColor = true;
            this.BtnRemoveColor.Click += new System.EventHandler(this.BtnRemoveColor_Click);
            // 
            // BtnAddColor
            // 
            this.BtnAddColor.Location = new System.Drawing.Point(3, 62);
            this.BtnAddColor.Name = "BtnAddColor";
            this.BtnAddColor.Size = new System.Drawing.Size(100, 23);
            this.BtnAddColor.TabIndex = 3;
            this.BtnAddColor.Text = "Add Color";
            this.BtnAddColor.UseVisualStyleBackColor = true;
            this.BtnAddColor.Click += new System.EventHandler(this.BtnAddColor_Click);
            // 
            // BtnGenerateGradient
            // 
            this.BtnGenerateGradient.Location = new System.Drawing.Point(3, 3);
            this.BtnGenerateGradient.Name = "BtnGenerateGradient";
            this.BtnGenerateGradient.Size = new System.Drawing.Size(100, 23);
            this.BtnGenerateGradient.TabIndex = 1;
            this.BtnGenerateGradient.Text = "Generate";
            this.BtnGenerateGradient.UseVisualStyleBackColor = true;
            this.BtnGenerateGradient.Click += new System.EventHandler(this.BtnGenerateGradient_Click);
            // 
            // LstColors
            // 
            this.LstColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstColors.FormattingEnabled = true;
            this.LstColors.IntegralHeight = false;
            this.LstColors.Location = new System.Drawing.Point(109, 3);
            this.LstColors.Name = "LstColors";
            this.TableMain.SetRowSpan(this.LstColors, 4);
            this.LstColors.Size = new System.Drawing.Size(120, 299);
            this.LstColors.TabIndex = 0;
            // 
            // LblHeight
            // 
            this.LblHeight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(407, 37);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(73, 13);
            this.LblHeight.TabIndex = 10;
            this.LblHeight.Text = "Height (pixels)";
            // 
            // NumHeight
            // 
            this.NumHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumHeight.Location = new System.Drawing.Point(486, 34);
            this.NumHeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumHeight.Name = "NumHeight";
            this.NumHeight.Size = new System.Drawing.Size(120, 20);
            this.NumHeight.TabIndex = 11;
            this.NumHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // PictColor
            // 
            this.PictColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PictColor.Location = new System.Drawing.Point(931, 3);
            this.PictColor.Name = "PictColor";
            this.TableMain.SetRowSpan(this.PictColor, 2);
            this.PictColor.Size = new System.Drawing.Size(150, 53);
            this.PictColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictColor.TabIndex = 12;
            this.PictColor.TabStop = false;
            // 
            // ClrEdit
            // 
            this.ClrEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableMain.SetColumnSpan(this.ClrEdit, 2);
            this.ClrEdit.Location = new System.Drawing.Point(486, 62);
            this.ClrEdit.MinimumSize = new System.Drawing.Size(300, 240);
            this.ClrEdit.Name = "ClrEdit";
            this.TableMain.SetRowSpan(this.ClrEdit, 2);
            this.ClrEdit.Size = new System.Drawing.Size(595, 240);
            this.ClrEdit.TabIndex = 8;
            this.ClrEdit.ColorChanged += new System.EventHandler(this.ClrEdit_ColorChanged);
            // 
            // ClrWheel
            // 
            this.ClrWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClrWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClrWheel.Location = new System.Drawing.Point(235, 62);
            this.ClrWheel.MinimumSize = new System.Drawing.Size(240, 240);
            this.ClrWheel.Name = "ClrWheel";
            this.TableMain.SetRowSpan(this.ClrWheel, 2);
            this.ClrWheel.Size = new System.Drawing.Size(245, 240);
            this.ClrWheel.TabIndex = 13;
            // 
            // ClrManager
            // 
            this.ClrManager.ColorEditor = this.ClrEdit;
            this.ClrManager.ColorWheel = this.ClrWheel;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(3, 32);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.TableMain);
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "FrmMain";
            this.Text = "Gradient Generator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.ListBox LstColors;
        private System.Windows.Forms.Button BtnGenerateGradient;
        private System.Windows.Forms.Button BtnAddColor;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.NumericUpDown NumWidth;
        private Cyotek.Windows.Forms.ImageBox PictPreview;
        private Cyotek.Windows.Forms.ColorEditor ClrEdit;
        private System.Windows.Forms.Button BtnRemoveColor;
        private Cyotek.Windows.Forms.ColorEditorManager ClrManager;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.NumericUpDown NumHeight;
        private System.Windows.Forms.PictureBox PictColor;
        private Cyotek.Windows.Forms.ColorWheel ClrWheel;
        private System.Windows.Forms.Button BtnSave;
    }
}

