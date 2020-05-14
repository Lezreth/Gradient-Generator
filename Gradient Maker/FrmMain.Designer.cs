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
            this.PictPreview = new Cyotek.Windows.Forms.ImageBox();
            this.BtnRemoveColor = new System.Windows.Forms.Button();
            this.BtnAddColor = new System.Windows.Forms.Button();
            this.BtnGenerateGradient = new System.Windows.Forms.Button();
            this.ClrEdit = new Cyotek.Windows.Forms.ColorEditor();
            this.ClrWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LstColors = new System.Windows.Forms.ListView();
            this.PictColor = new Cyotek.Windows.Forms.ImageBox();
            this.LblWidth = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.NumHeight = new System.Windows.Forms.NumericUpDown();
            this.BtnMoveUp = new System.Windows.Forms.Button();
            this.BtnMoveDown = new System.Windows.Forms.Button();
            this.ClrManager = new Cyotek.Windows.Forms.ColorEditorManager();
            this.BtnDuplicate = new System.Windows.Forms.Button();
            this.ChkAutoGenerate = new System.Windows.Forms.CheckBox();
            this.TableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 6;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.Controls.Add(this.PictPreview, 0, 7);
            this.TableMain.Controls.Add(this.BtnRemoveColor, 0, 3);
            this.TableMain.Controls.Add(this.BtnAddColor, 0, 2);
            this.TableMain.Controls.Add(this.BtnGenerateGradient, 0, 0);
            this.TableMain.Controls.Add(this.ClrWheel, 2, 2);
            this.TableMain.Controls.Add(this.BtnSave, 0, 1);
            this.TableMain.Controls.Add(this.LstColors, 1, 0);
            this.TableMain.Controls.Add(this.PictColor, 2, 0);
            this.TableMain.Controls.Add(this.LblWidth, 4, 0);
            this.TableMain.Controls.Add(this.LblHeight, 4, 1);
            this.TableMain.Controls.Add(this.NumWidth, 5, 0);
            this.TableMain.Controls.Add(this.NumHeight, 5, 1);
            this.TableMain.Controls.Add(this.BtnMoveUp, 0, 5);
            this.TableMain.Controls.Add(this.BtnMoveDown, 0, 6);
            this.TableMain.Controls.Add(this.BtnDuplicate, 0, 4);
            this.TableMain.Controls.Add(this.ClrEdit, 3, 2);
            this.TableMain.Controls.Add(this.ChkAutoGenerate, 3, 0);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 8;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Size = new System.Drawing.Size(1084, 561);
            this.TableMain.TabIndex = 0;
            // 
            // PictPreview
            // 
            this.TableMain.SetColumnSpan(this.PictPreview, 6);
            this.PictPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictPreview.Location = new System.Drawing.Point(3, 307);
            this.PictPreview.Name = "PictPreview";
            this.PictPreview.Size = new System.Drawing.Size(1078, 251);
            this.PictPreview.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.PictPreview.TabIndex = 6;
            // 
            // BtnRemoveColor
            // 
            this.BtnRemoveColor.Enabled = false;
            this.BtnRemoveColor.Location = new System.Drawing.Point(3, 90);
            this.BtnRemoveColor.Name = "BtnRemoveColor";
            this.BtnRemoveColor.Size = new System.Drawing.Size(100, 23);
            this.BtnRemoveColor.TabIndex = 9;
            this.BtnRemoveColor.Text = "Remove Color";
            this.BtnRemoveColor.UseVisualStyleBackColor = true;
            this.BtnRemoveColor.Click += new System.EventHandler(this.BtnRemoveColor_Click);
            // 
            // BtnAddColor
            // 
            this.BtnAddColor.Location = new System.Drawing.Point(3, 61);
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
            // ClrEdit
            // 
            this.ClrEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableMain.SetColumnSpan(this.ClrEdit, 3);
            this.ClrEdit.Location = new System.Drawing.Point(516, 61);
            this.ClrEdit.MinimumSize = new System.Drawing.Size(300, 240);
            this.ClrEdit.Name = "ClrEdit";
            this.TableMain.SetRowSpan(this.ClrEdit, 5);
            this.ClrEdit.Size = new System.Drawing.Size(565, 240);
            this.ClrEdit.TabIndex = 8;
            this.ClrEdit.ColorChanged += new System.EventHandler(this.ClrEdit_ColorChanged);
            // 
            // ClrWheel
            // 
            this.ClrWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClrWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClrWheel.Location = new System.Drawing.Point(265, 61);
            this.ClrWheel.MinimumSize = new System.Drawing.Size(240, 240);
            this.ClrWheel.Name = "ClrWheel";
            this.TableMain.SetRowSpan(this.ClrWheel, 5);
            this.ClrWheel.Size = new System.Drawing.Size(245, 240);
            this.ClrWheel.TabIndex = 13;
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
            // LstColors
            // 
            this.LstColors.AutoArrange = false;
            this.LstColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstColors.HideSelection = false;
            this.LstColors.Location = new System.Drawing.Point(109, 3);
            this.LstColors.Name = "LstColors";
            this.TableMain.SetRowSpan(this.LstColors, 7);
            this.LstColors.ShowGroups = false;
            this.LstColors.Size = new System.Drawing.Size(150, 298);
            this.LstColors.TabIndex = 16;
            this.LstColors.UseCompatibleStateImageBehavior = false;
            this.LstColors.View = System.Windows.Forms.View.List;
            this.LstColors.SelectedIndexChanged += new System.EventHandler(this.LstColors_SelectedIndexChanged);
            // 
            // PictColor
            // 
            this.PictColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictColor.Location = new System.Drawing.Point(410, 3);
            this.PictColor.Name = "PictColor";
            this.TableMain.SetRowSpan(this.PictColor, 2);
            this.PictColor.Size = new System.Drawing.Size(100, 52);
            this.PictColor.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.PictColor.TabIndex = 15;
            // 
            // LblWidth
            // 
            this.LblWidth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(885, 8);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(70, 13);
            this.LblWidth.TabIndex = 4;
            this.LblWidth.Text = "Width (pixels)";
            // 
            // LblHeight
            // 
            this.LblHeight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(882, 37);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(73, 13);
            this.LblHeight.TabIndex = 10;
            this.LblHeight.Text = "Height (pixels)";
            // 
            // NumWidth
            // 
            this.NumWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumWidth.Location = new System.Drawing.Point(961, 4);
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
            // NumHeight
            // 
            this.NumHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumHeight.Location = new System.Drawing.Point(961, 33);
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
            // BtnMoveUp
            // 
            this.BtnMoveUp.Location = new System.Drawing.Point(3, 187);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(100, 23);
            this.BtnMoveUp.TabIndex = 17;
            this.BtnMoveUp.Text = "Move Up";
            this.BtnMoveUp.UseVisualStyleBackColor = true;
            this.BtnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.Location = new System.Drawing.Point(3, 217);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(100, 23);
            this.BtnMoveDown.TabIndex = 18;
            this.BtnMoveDown.Text = "Move Down";
            this.BtnMoveDown.UseVisualStyleBackColor = true;
            this.BtnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // ClrManager
            // 
            this.ClrManager.ColorEditor = this.ClrEdit;
            this.ClrManager.ColorWheel = this.ClrWheel;
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Enabled = false;
            this.BtnDuplicate.Location = new System.Drawing.Point(3, 119);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(100, 23);
            this.BtnDuplicate.TabIndex = 19;
            this.BtnDuplicate.Text = "Duplicate";
            this.BtnDuplicate.UseVisualStyleBackColor = true;
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // ChkAutoGenerate
            // 
            this.ChkAutoGenerate.AutoSize = true;
            this.ChkAutoGenerate.Checked = true;
            this.ChkAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAutoGenerate.Location = new System.Drawing.Point(516, 3);
            this.ChkAutoGenerate.Name = "ChkAutoGenerate";
            this.ChkAutoGenerate.Size = new System.Drawing.Size(178, 17);
            this.ChkAutoGenerate.TabIndex = 20;
            this.ChkAutoGenerate.Text = "Automatically Generate Gradient";
            this.ChkAutoGenerate.UseVisualStyleBackColor = true;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
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
        private Cyotek.Windows.Forms.ColorWheel ClrWheel;
        private System.Windows.Forms.Button BtnSave;
        private Cyotek.Windows.Forms.ImageBox PictColor;
        private System.Windows.Forms.ListView LstColors;
        private System.Windows.Forms.Button BtnMoveUp;
        private System.Windows.Forms.Button BtnMoveDown;
        private System.Windows.Forms.Button BtnDuplicate;
        private System.Windows.Forms.CheckBox ChkAutoGenerate;
    }
}

