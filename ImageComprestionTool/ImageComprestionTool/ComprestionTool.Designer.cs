namespace ImageComprestionTool
{
    partial class ComprestionTool
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
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.lblQuality = new System.Windows.Forms.Label();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.AddImage = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.SaveImage = new System.Windows.Forms.SaveFileDialog();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lstFormats = new System.Windows.Forms.ListBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnHalf = new System.Windows.Forms.Button();
            this.lstcolorSpace = new System.Windows.Forms.ListBox();
            this.btnOpenPdfForm = new System.Windows.Forms.Button();
            this.btnCopyToClip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // numQuality
            // 
            this.numQuality.Location = new System.Drawing.Point(61, 240);
            this.numQuality.Name = "numQuality";
            this.numQuality.Size = new System.Drawing.Size(120, 20);
            this.numQuality.TabIndex = 1;
            this.numQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numQuality.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(61, 221);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(39, 13);
            this.lblQuality.TabIndex = 1;
            this.lblQuality.Text = "Quality";
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(61, 624);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(75, 23);
            this.btnShowImage.TabIndex = 5;
            this.btnShowImage.Text = "ShowImage";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(152, 624);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "SaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(61, 271);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(61, 317);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height";
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(291, 90);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(258, 239);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxImage.TabIndex = 9;
            this.pboxImage.TabStop = false;
            // 
            // AddImage
            // 
            this.AddImage.FileName = "ofdAddImage";
            this.AddImage.Title = "AddImage";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(61, 90);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "LoadImage";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(61, 141);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(224, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // SaveImage
            // 
            this.SaveImage.FileName = "sfdSaveImage";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(61, 289);
            this.numWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(119, 20);
            this.numWidth.TabIndex = 2;
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(61, 339);
            this.numHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(118, 20);
            this.numHeight.TabIndex = 3;
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // lstFormats
            // 
            this.lstFormats.FormattingEnabled = true;
            this.lstFormats.Items.AddRange(new object[] {
            "PNG",
            "GIF",
            "JPEG",
            "BMP",
            "TIFF"});
            this.lstFormats.Location = new System.Drawing.Point(61, 518);
            this.lstFormats.Name = "lstFormats";
            this.lstFormats.Size = new System.Drawing.Size(118, 95);
            this.lstFormats.TabIndex = 4;
            this.lstFormats.SelectedIndexChanged += new System.EventHandler(this.lstFormats_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(61, 188);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(150, 20);
            this.txtSize.TabIndex = 1;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(58, 170);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 16;
            this.lblSize.Text = "Size";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(62, 122);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 13);
            this.lblFileName.TabIndex = 17;
            this.lblFileName.Text = "FileName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bytes";
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(61, 669);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 19);
            this.btnDouble.TabIndex = 19;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnHalf
            // 
            this.btnHalf.Location = new System.Drawing.Point(152, 668);
            this.btnHalf.Name = "btnHalf";
            this.btnHalf.Size = new System.Drawing.Size(74, 19);
            this.btnHalf.TabIndex = 20;
            this.btnHalf.Text = "Half";
            this.btnHalf.UseVisualStyleBackColor = true;
            this.btnHalf.Click += new System.EventHandler(this.btnHalf_Click);
            // 
            // lstcolorSpace
            // 
            this.lstcolorSpace.FormattingEnabled = true;
            this.lstcolorSpace.Items.AddRange(new object[] {
            "sRGB",
            "RGB",
            "scRGB",
            "CMY",
            "CMYK",
            "Gray",
            "LinearGRAY",
            "HCL",
            "HCLp",
            "HSB",
            "HSI",
            "HSL",
            "HSV",
            "HWB",
            "Lab",
            "LCH",
            "LCHab",
            "LCHuv",
            "Log",
            "LMS",
            "Luv",
            "OHTA",
            "Rec601YCbCr",
            "Rec709YCbCr",
            "Transparent",
            "XyY",
            "XYZ",
            "YCbCr",
            "YCC",
            "YDbDr",
            "YIQ",
            "YPbPr",
            "YUV"});
            this.lstcolorSpace.Location = new System.Drawing.Point(61, 388);
            this.lstcolorSpace.Name = "lstcolorSpace";
            this.lstcolorSpace.Size = new System.Drawing.Size(117, 95);
            this.lstcolorSpace.TabIndex = 21;
            this.lstcolorSpace.SelectedIndexChanged += new System.EventHandler(this.lstcolorSpace_SelectedIndexChanged);
            // 
            // btnOpenPdfForm
            // 
            this.btnOpenPdfForm.Location = new System.Drawing.Point(59, 52);
            this.btnOpenPdfForm.Name = "btnOpenPdfForm";
            this.btnOpenPdfForm.Size = new System.Drawing.Size(76, 23);
            this.btnOpenPdfForm.TabIndex = 22;
            this.btnOpenPdfForm.Text = "ConvertPDF";
            this.btnOpenPdfForm.UseVisualStyleBackColor = true;
            this.btnOpenPdfForm.Click += new System.EventHandler(this.btnOpenPdfForm_Click);
            // 
            // btnCopyToClip
            // 
            this.btnCopyToClip.Location = new System.Drawing.Point(150, 90);
            this.btnCopyToClip.Name = "btnCopyToClip";
            this.btnCopyToClip.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToClip.TabIndex = 23;
            this.btnCopyToClip.Text = "Copy Image";
            this.btnCopyToClip.UseVisualStyleBackColor = true;
            this.btnCopyToClip.Click += new System.EventHandler(this.btnCopyToClip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Colour Scheme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Image Format";
            // 
            // ComprestionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(632, 706);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopyToClip);
            this.Controls.Add(this.btnOpenPdfForm);
            this.Controls.Add(this.lstcolorSpace);
            this.Controls.Add(this.btnHalf);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lstFormats);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnShowImage);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.numQuality);
            this.Name = "ComprestionTool";
            this.Text = "Compress My Image";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComprestionTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.OpenFileDialog AddImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.SaveFileDialog SaveImage;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.ListBox lstFormats;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnHalf;
        private System.Windows.Forms.Button btnOpenPdfForm;
        private System.Windows.Forms.ListBox lstcolorSpace;
        private System.Windows.Forms.Button btnCopyToClip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

