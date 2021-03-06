﻿namespace Gradient_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.PictPreview = new Cyotek.Windows.Forms.ImageBox();
            this.ClrWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.PictColor = new Cyotek.Windows.Forms.ImageBox();
            this.LblWidth = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.NumHeight = new System.Windows.Forms.NumericUpDown();
            this.ClrEdit = new Cyotek.Windows.Forms.ColorEditor();
            this.ChkAutoGenerate = new System.Windows.Forms.CheckBox();
            this.LstColors = new System.Windows.Forms.ListView();
            this.ColA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMoveDown = new System.Windows.Forms.Button();
            this.BtnMoveUp = new System.Windows.Forms.Button();
            this.BtnDuplicate = new System.Windows.Forms.Button();
            this.BtnRemoveColor = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkSaveConfig = new System.Windows.Forms.CheckBox();
            this.BtnAddColor = new System.Windows.Forms.Button();
            this.BtnGenerateGradient = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.LstGradientType = new System.Windows.Forms.ComboBox();
            this.ClrManager = new Cyotek.Windows.Forms.ColorEditorManager();
            this.ColPixel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).BeginInit();
            this.TableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 7;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableMain.Controls.Add(this.PictPreview, 0, 3);
            this.TableMain.Controls.Add(this.ClrWheel, 2, 2);
            this.TableMain.Controls.Add(this.PictColor, 3, 0);
            this.TableMain.Controls.Add(this.LblWidth, 5, 0);
            this.TableMain.Controls.Add(this.LblHeight, 5, 1);
            this.TableMain.Controls.Add(this.NumWidth, 6, 0);
            this.TableMain.Controls.Add(this.NumHeight, 6, 1);
            this.TableMain.Controls.Add(this.ClrEdit, 4, 2);
            this.TableMain.Controls.Add(this.ChkAutoGenerate, 4, 0);
            this.TableMain.Controls.Add(this.LstColors, 0, 0);
            this.TableMain.Controls.Add(this.TableButtons, 1, 0);
            this.TableMain.Controls.Add(this.LstGradientType, 2, 0);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 5;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableMain.Size = new System.Drawing.Size(1084, 561);
            this.TableMain.TabIndex = 0;
            // 
            // PictPreview
            // 
            this.TableMain.SetColumnSpan(this.PictPreview, 7);
            this.PictPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictPreview.Location = new System.Drawing.Point(3, 307);
            this.PictPreview.Name = "PictPreview";
            this.PictPreview.Size = new System.Drawing.Size(1078, 150);
            this.PictPreview.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.PictPreview.TabIndex = 9;
            // 
            // ClrWheel
            // 
            this.ClrWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableMain.SetColumnSpan(this.ClrWheel, 2);
            this.ClrWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClrWheel.Location = new System.Drawing.Point(332, 61);
            this.ClrWheel.MinimumSize = new System.Drawing.Size(240, 240);
            this.ClrWheel.Name = "ClrWheel";
            this.ClrWheel.Size = new System.Drawing.Size(245, 240);
            this.ClrWheel.TabIndex = 4;
            // 
            // PictColor
            // 
            this.PictColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictColor.Location = new System.Drawing.Point(477, 3);
            this.PictColor.Name = "PictColor";
            this.TableMain.SetRowSpan(this.PictColor, 2);
            this.PictColor.Size = new System.Drawing.Size(100, 52);
            this.PictColor.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.PictColor.TabIndex = 8;
            // 
            // LblWidth
            // 
            this.LblWidth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(885, 7);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(70, 13);
            this.LblWidth.TabIndex = 2;
            this.LblWidth.Text = "Width (pixels)";
            // 
            // LblHeight
            // 
            this.LblHeight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(882, 36);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(73, 13);
            this.LblHeight.TabIndex = 3;
            this.LblHeight.Text = "Height (pixels)";
            // 
            // NumWidth
            // 
            this.NumWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumWidth.Location = new System.Drawing.Point(961, 3);
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
            this.NumWidth.TabIndex = 0;
            this.NumWidth.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // NumHeight
            // 
            this.NumHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumHeight.Location = new System.Drawing.Point(961, 32);
            this.NumHeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumHeight.Name = "NumHeight";
            this.NumHeight.Size = new System.Drawing.Size(120, 20);
            this.NumHeight.TabIndex = 1;
            this.NumHeight.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // ClrEdit
            // 
            this.ClrEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableMain.SetColumnSpan(this.ClrEdit, 3);
            this.ClrEdit.Location = new System.Drawing.Point(583, 61);
            this.ClrEdit.MinimumSize = new System.Drawing.Size(300, 240);
            this.ClrEdit.Name = "ClrEdit";
            this.ClrEdit.Size = new System.Drawing.Size(498, 240);
            this.ClrEdit.TabIndex = 5;
            this.ClrEdit.ColorChanged += new System.EventHandler(this.ClrEdit_ColorChanged);
            // 
            // ChkAutoGenerate
            // 
            this.ChkAutoGenerate.AutoSize = true;
            this.ChkAutoGenerate.Checked = true;
            this.ChkAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAutoGenerate.Location = new System.Drawing.Point(583, 3);
            this.ChkAutoGenerate.Name = "ChkAutoGenerate";
            this.ChkAutoGenerate.Size = new System.Drawing.Size(178, 17);
            this.ChkAutoGenerate.TabIndex = 7;
            this.ChkAutoGenerate.Text = "Automatically Generate Gradient";
            this.ChkAutoGenerate.UseVisualStyleBackColor = true;
            // 
            // LstColors
            // 
            this.LstColors.AutoArrange = false;
            this.LstColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColA,
            this.ColR,
            this.ColG,
            this.ColB,
            this.ColPixel});
            this.LstColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstColors.FullRowSelect = true;
            this.LstColors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstColors.HideSelection = false;
            this.LstColors.Location = new System.Drawing.Point(3, 3);
            this.LstColors.MinimumSize = new System.Drawing.Size(160, 4);
            this.LstColors.Name = "LstColors";
            this.TableMain.SetRowSpan(this.LstColors, 3);
            this.LstColors.ShowGroups = false;
            this.LstColors.Size = new System.Drawing.Size(200, 298);
            this.LstColors.TabIndex = 6;
            this.LstColors.UseCompatibleStateImageBehavior = false;
            this.LstColors.View = System.Windows.Forms.View.Details;
            this.LstColors.SelectedIndexChanged += new System.EventHandler(this.LstColors_SelectedIndexChanged);
            // 
            // ColA
            // 
            this.ColA.Text = "A";
            this.ColA.Width = 40;
            // 
            // ColR
            // 
            this.ColR.Text = "R";
            this.ColR.Width = 30;
            // 
            // ColG
            // 
            this.ColG.Text = "G";
            this.ColG.Width = 30;
            // 
            // ColB
            // 
            this.ColB.Text = "B";
            this.ColB.Width = 30;
            // 
            // TableButtons
            // 
            this.TableButtons.ColumnCount = 1;
            this.TableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableButtons.Controls.Add(this.BtnMoveDown, 0, 8);
            this.TableButtons.Controls.Add(this.BtnMoveUp, 0, 7);
            this.TableButtons.Controls.Add(this.BtnDuplicate, 0, 6);
            this.TableButtons.Controls.Add(this.BtnRemoveColor, 0, 5);
            this.TableButtons.Controls.Add(this.BtnSave, 0, 1);
            this.TableButtons.Controls.Add(this.ChkSaveConfig, 0, 2);
            this.TableButtons.Controls.Add(this.BtnAddColor, 0, 4);
            this.TableButtons.Controls.Add(this.BtnGenerateGradient, 0, 3);
            this.TableButtons.Controls.Add(this.BtnLoad, 0, 0);
            this.TableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableButtons.Location = new System.Drawing.Point(209, 3);
            this.TableButtons.Name = "TableButtons";
            this.TableButtons.RowCount = 9;
            this.TableMain.SetRowSpan(this.TableButtons, 3);
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableButtons.Size = new System.Drawing.Size(117, 298);
            this.TableButtons.TabIndex = 10;
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.Location = new System.Drawing.Point(3, 271);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(110, 23);
            this.BtnMoveDown.TabIndex = 7;
            this.BtnMoveDown.Text = "Move Down";
            this.BtnMoveDown.UseVisualStyleBackColor = true;
            this.BtnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.Location = new System.Drawing.Point(3, 242);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(110, 23);
            this.BtnMoveUp.TabIndex = 6;
            this.BtnMoveUp.Text = "Move Up";
            this.BtnMoveUp.UseVisualStyleBackColor = true;
            this.BtnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Enabled = false;
            this.BtnDuplicate.Location = new System.Drawing.Point(3, 192);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(110, 23);
            this.BtnDuplicate.TabIndex = 5;
            this.BtnDuplicate.Text = "Duplicate Selected";
            this.BtnDuplicate.UseVisualStyleBackColor = true;
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // BtnRemoveColor
            // 
            this.BtnRemoveColor.Enabled = false;
            this.BtnRemoveColor.Location = new System.Drawing.Point(3, 163);
            this.BtnRemoveColor.Name = "BtnRemoveColor";
            this.BtnRemoveColor.Size = new System.Drawing.Size(110, 23);
            this.BtnRemoveColor.TabIndex = 4;
            this.BtnRemoveColor.Text = "Remove Color";
            this.BtnRemoveColor.UseVisualStyleBackColor = true;
            this.BtnRemoveColor.Click += new System.EventHandler(this.BtnRemoveColor_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(3, 32);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save Gradient";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkSaveConfig
            // 
            this.ChkSaveConfig.AutoSize = true;
            this.ChkSaveConfig.Checked = true;
            this.ChkSaveConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSaveConfig.Location = new System.Drawing.Point(3, 61);
            this.ChkSaveConfig.Name = "ChkSaveConfig";
            this.ChkSaveConfig.Size = new System.Drawing.Size(93, 17);
            this.ChkSaveConfig.TabIndex = 1;
            this.ChkSaveConfig.Text = "Also Save List";
            this.ChkSaveConfig.UseVisualStyleBackColor = true;
            // 
            // BtnAddColor
            // 
            this.BtnAddColor.Location = new System.Drawing.Point(3, 134);
            this.BtnAddColor.Name = "BtnAddColor";
            this.BtnAddColor.Size = new System.Drawing.Size(110, 23);
            this.BtnAddColor.TabIndex = 3;
            this.BtnAddColor.Text = "Add Color";
            this.BtnAddColor.UseVisualStyleBackColor = true;
            this.BtnAddColor.Click += new System.EventHandler(this.BtnAddColor_Click);
            // 
            // BtnGenerateGradient
            // 
            this.BtnGenerateGradient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGenerateGradient.Location = new System.Drawing.Point(3, 94);
            this.BtnGenerateGradient.Name = "BtnGenerateGradient";
            this.BtnGenerateGradient.Size = new System.Drawing.Size(110, 23);
            this.BtnGenerateGradient.TabIndex = 2;
            this.BtnGenerateGradient.Text = "Generate";
            this.BtnGenerateGradient.UseVisualStyleBackColor = true;
            this.BtnGenerateGradient.Click += new System.EventHandler(this.BtnGenerateGradient_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(3, 3);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(110, 23);
            this.BtnLoad.TabIndex = 8;
            this.BtnLoad.Text = "Load List";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // LstGradientType
            // 
            this.LstGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstGradientType.FormattingEnabled = true;
            this.LstGradientType.Location = new System.Drawing.Point(332, 3);
            this.LstGradientType.Name = "LstGradientType";
            this.LstGradientType.Size = new System.Drawing.Size(121, 21);
            this.LstGradientType.TabIndex = 11;
            // 
            // ClrManager
            // 
            this.ClrManager.ColorEditor = this.ClrEdit;
            this.ClrManager.ColorWheel = this.ClrWheel;
            // 
            // ColPixel
            // 
            this.ColPixel.Text = "Pixel";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnAddColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.TableMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "FrmMain";
            this.Text = "Gradient Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).EndInit();
            this.TableButtons.ResumeLayout(false);
            this.TableButtons.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel TableButtons;
        private System.Windows.Forms.CheckBox ChkSaveConfig;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ComboBox LstGradientType;
        private System.Windows.Forms.ColumnHeader ColA;
        private System.Windows.Forms.ColumnHeader ColR;
        private System.Windows.Forms.ColumnHeader ColG;
        private System.Windows.Forms.ColumnHeader ColB;
        private System.Windows.Forms.ColumnHeader ColPixel;
    }
}

