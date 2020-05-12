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
            this.ListColors = new System.Windows.Forms.ListBox();
            this.BtnGenerateColors = new System.Windows.Forms.Button();
            this.PictPreview = new System.Windows.Forms.PictureBox();
            this.BtnAddColor = new System.Windows.Forms.Button();
            this.TableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 2;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableMain.Controls.Add(this.ListColors, 0, 2);
            this.TableMain.Controls.Add(this.BtnGenerateColors, 1, 2);
            this.TableMain.Controls.Add(this.PictPreview, 0, 3);
            this.TableMain.Controls.Add(this.BtnAddColor, 0, 1);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 4;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableMain.Size = new System.Drawing.Size(800, 450);
            this.TableMain.TabIndex = 0;
            // 
            // ListColors
            // 
            this.ListColors.FormattingEnabled = true;
            this.ListColors.IntegralHeight = false;
            this.ListColors.Location = new System.Drawing.Point(3, 227);
            this.ListColors.Name = "ListColors";
            this.ListColors.Size = new System.Drawing.Size(120, 96);
            this.ListColors.TabIndex = 0;
            // 
            // BtnGenerateColors
            // 
            this.BtnGenerateColors.Location = new System.Drawing.Point(403, 227);
            this.BtnGenerateColors.Name = "BtnGenerateColors";
            this.BtnGenerateColors.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerateColors.TabIndex = 1;
            this.BtnGenerateColors.Text = "Generate";
            this.BtnGenerateColors.UseVisualStyleBackColor = true;
            this.BtnGenerateColors.Click += new System.EventHandler(this.BtnGenerateColors_Click);
            // 
            // PictPreview
            // 
            this.PictPreview.Location = new System.Drawing.Point(3, 339);
            this.PictPreview.Name = "PictPreview";
            this.PictPreview.Size = new System.Drawing.Size(100, 50);
            this.PictPreview.TabIndex = 2;
            this.PictPreview.TabStop = false;
            // 
            // BtnAddColor
            // 
            this.BtnAddColor.Location = new System.Drawing.Point(3, 115);
            this.BtnAddColor.Name = "BtnAddColor";
            this.BtnAddColor.Size = new System.Drawing.Size(75, 23);
            this.BtnAddColor.TabIndex = 3;
            this.BtnAddColor.Text = "Add Color";
            this.BtnAddColor.UseVisualStyleBackColor = true;
            this.BtnAddColor.Click += new System.EventHandler(this.BtnAddColor_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableMain);
            this.Name = "FrmMain";
            this.Text = "Gradient Generator";
            this.TableMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.ListBox ListColors;
        private System.Windows.Forms.Button BtnGenerateColors;
        private System.Windows.Forms.PictureBox PictPreview;
        private System.Windows.Forms.Button BtnAddColor;
    }
}

