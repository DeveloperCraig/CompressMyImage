using System;
using System.ComponentModel;
using System.Windows.Forms;
using ImageComprestionTool.Methods;
using ImageComprestionTool.Properties;
using ImageMagick;

namespace ImageComprestionTool
{
    /// <summary>
    /// ComprestionTool form
    /// </summary>
    public partial class ComprestionTool : Form
    {        
        private string File;        
        private new int Width;        
        private new int Height;        
        private new long Size;

        /// <summary>
        /// ComprestionTool Startup
        /// </summary>
        public ComprestionTool()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Start-up Form Data
        /// </summary>
        /// <info>
        /// This is all just setting up the setting for the application, setting defult values and declaring a place for
        /// Temp data to go to make it easyer for the users to see
        /// </info>
        private void ComprestionTool_Load(object sender, EventArgs e)
        {
            lstFormats.SetSelected(0, true);
            lstcolorSpace.SetSelected(0, true);
            MagickNET.SetTempDirectory(String.Format(AppDomain.CurrentDomain.BaseDirectory + "Temp"));
            MessageBox.Show("                                              Welcome to Compress My Image                        "
                + "\n" +
                "This software was designed to help those who have a image with a large files size which you would" +
                " like to bring down in size to use on websites without having to loss the quality of the image."
                + "\n" + "\n" +
                "--------------------------------------Warning--------------------------------------"
                + "\n" +
                "Be careful when increasing the size of the image, increasing the size of the image could result in large Temp files being " +
                "created and stored in "
                + "\n" +
                AppDomain.CurrentDomain.BaseDirectory + "Temp"
                + "\n" + "\n" +
                "Also be aware by pressing the “Copy Image” button you will be skipping out on a lot of the compression which means the " +
                "file size would be much higher then if you were to just save the image as a new file");
        }

        private void numQuality_ValueChanged(object sender, EventArgs e)
        {

        }
       
        /// <summary>
        /// Show Image Button
        /// </summary>
        /// <see cref="ImageActions.ShowImage(string, string, string, PictureBox, int, int, int, out long)"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowImage_Click(object sender, EventArgs e)
        {
            var Image = new ImageActions();
            Image.ShowImage(txtFileName.Text, lstcolorSpace.SelectedItem.ToString(), lstFormats.SelectedItem.ToString(), pboxImage, Convert.ToInt32(numQuality.Value), Convert.ToInt32(numWidth.Value), Convert.ToInt32(numHeight.Value), out Size);
            
            txtSize.Text = Size.ToString();
        }
        /// <summary>
        /// Save Image Button
        /// </summary>
        /// <see cref="ImageActions.SaveImage(PictureBox, string, string, string, int, int, int)"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            var Image = new ImageActions();
            Image.SaveImage(pboxImage, lstcolorSpace.SelectedItem.ToString(), txtFileName.Text, lstFormats.SelectedItem.ToString(), Convert.ToInt32(numQuality.Value), Convert.ToInt32(numWidth.Value), Convert.ToInt32(numHeight.Value));
        }

        /// <summary>
        /// Load Image Button
        /// </summary>
        /// <see cref="ImageActions.LoadImage(PictureBox, out string, out int, out int, out long)"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                var Image = new ImageActions();
                Image.LoadImage(pboxImage, out File, out Height, out Width, out Size);
                txtFileName.Text = File;
                numWidth.Value = Width;
                numHeight.Value = Height;
                txtSize.Text = Size.ToString();
            }
            catch (Exception Error)
            {
                if (Error.Message.Contains("image format"))
                {
                    MessageBox.Show("Sorry We do not support this image.");
                }
                else
                {
                    MessageBox.Show("Something went wrong!!!" + "\n" + "\n" + "Image format type might not be supported." + Error);
                }
                
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Double the image Size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDouble_Click(object sender, EventArgs e)
        {
            numWidth.Value = numWidth.Value * 2;
            numHeight.Value = numHeight.Value * 2;
        }

        /// <summary>
        /// Half the Image Size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHalf_Click(object sender, EventArgs e)
        {
            numWidth.Value = numWidth.Value / 2;
            numHeight.Value = numHeight.Value / 2;
        }

        /// <summary>
        /// Open the Convert PDF Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenPdfForm_Click(object sender, EventArgs e)
        {
            var NewForm = new PdfToImage();
            NewForm.Show();
        }

        private void lstFormats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstcolorSpace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Copy Image to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyToClip_Click(object sender, EventArgs e)
        {
           Clipboard.SetImage(pboxImage.Image);
        }
    }
}
