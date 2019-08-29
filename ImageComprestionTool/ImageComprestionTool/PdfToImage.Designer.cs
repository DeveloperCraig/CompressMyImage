namespace ImageComprestionTool.Properties
{
    partial class PdfToImage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPDFName = new System.Windows.Forms.TextBox();
            this.btnLoadPDF = new System.Windows.Forms.Button();
            this.pboxPDF = new System.Windows.Forms.PictureBox();
            this.btnSavePdfImage = new System.Windows.Forms.Button();
            this.sfdSavePdfImage = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bytes";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 93);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 13);
            this.lblFileName.TabIndex = 34;
            this.lblFileName.Text = "FileName";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(9, 141);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 33;
            this.lblSize.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(12, 159);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(150, 20);
            this.txtSize.TabIndex = 24;
            // 
            // txtPDFName
            // 
            this.txtPDFName.Enabled = false;
            this.txtPDFName.Location = new System.Drawing.Point(12, 112);
            this.txtPDFName.Name = "txtPDFName";
            this.txtPDFName.ReadOnly = true;
            this.txtPDFName.Size = new System.Drawing.Size(224, 20);
            this.txtPDFName.TabIndex = 22;
            this.txtPDFName.TextChanged += new System.EventHandler(this.txtPDFName_TextChanged);
            // 
            // btnLoadPDF
            // 
            this.btnLoadPDF.Location = new System.Drawing.Point(12, 61);
            this.btnLoadPDF.Name = "btnLoadPDF";
            this.btnLoadPDF.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPDF.TabIndex = 23;
            this.btnLoadPDF.Text = "LoadPDF";
            this.btnLoadPDF.UseVisualStyleBackColor = true;
            this.btnLoadPDF.Click += new System.EventHandler(this.btnLoadPDF_Click);
            // 
            // pboxPDF
            // 
            this.pboxPDF.Location = new System.Drawing.Point(276, 58);
            this.pboxPDF.Name = "pboxPDF";
            this.pboxPDF.Size = new System.Drawing.Size(258, 239);
            this.pboxPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxPDF.TabIndex = 32;
            this.pboxPDF.TabStop = false;
            // 
            // btnSavePdfImage
            // 
            this.btnSavePdfImage.Location = new System.Drawing.Point(12, 276);
            this.btnSavePdfImage.Name = "btnSavePdfImage";
            this.btnSavePdfImage.Size = new System.Drawing.Size(74, 21);
            this.btnSavePdfImage.TabIndex = 36;
            this.btnSavePdfImage.Text = "SaveImage";
            this.btnSavePdfImage.UseVisualStyleBackColor = true;
            this.btnSavePdfImage.Click += new System.EventHandler(this.btnSavePdfImage_Click);
            // 
            // PdfToImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(623, 549);
            this.Controls.Add(this.btnSavePdfImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPDFName);
            this.Controls.Add(this.btnLoadPDF);
            this.Controls.Add(this.pboxPDF);
            this.Name = "PdfToImage";
            this.Text = "PdfToImage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PdfToImage_FormClosed);
            this.Load += new System.EventHandler(this.PdfToImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPDFName;
        private System.Windows.Forms.Button btnLoadPDF;
        private System.Windows.Forms.PictureBox pboxPDF;
        private System.Windows.Forms.Button btnSavePdfImage;
        private System.Windows.Forms.SaveFileDialog sfdSavePdfImage;
    }
}