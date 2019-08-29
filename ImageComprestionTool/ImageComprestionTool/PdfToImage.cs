using ImageComprestionTool.Methods;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComprestionTool.Properties
{
    /// <summary>
    /// PdfToImage form
    /// </summary>
    public partial class PdfToImage : Form
    {
        private string File;
        /// <summary>
        /// PdfToImage Startup
        /// </summary>
        public PdfToImage()
        {
            InitializeComponent();
            MagickNET.SetGhostscriptDirectory(String.Format(AppDomain.CurrentDomain.BaseDirectory + "PDFTools"));
        }
        /// <summary>
        /// Load PDF into App
        /// </summary>
        /// <see cref="ImageActions.LoadPDF(PictureBox, out string)"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadPDF_Click(object sender, EventArgs e)
        {
            var Image = new ImageActions();
            Image.LoadPDF(pboxPDF, out File);
            txtPDFName.Text = File;
        }

        private void txtPDFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PdfToImage_Load(object sender, EventArgs e)
        {

        }

        private void PdfToImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        /// <summary>
        /// Save PDF as image button
        /// </summary>
        /// <see cref="ImageActions.SavePdfImage(PictureBox, string)"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePdfImage_Click(object sender, EventArgs e)
        {
            var Image = new ImageActions();
            Image.SavePdfImage(pboxPDF, txtPDFName.Text);
        }
    }
}
