using ImageMagick;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageComprestionTool.Methods
{
    /// <summary>
    /// Interface For ImageAction
    /// </summary>
    interface IImageActions
    {
        string LoadImage(PictureBox pictureBox, out string fileName, out int Height, out int Width, out long Size);

        void ShowImage(string fileName, string colorSpace, string Format, PictureBox pictureBox, int Quality, int Width, int Height, out long Size);

        void SaveImage(PictureBox pictureBox, string colorSpace, string fileName, string Format, int Quality, int Width, int Height);

        string LoadPDF(PictureBox pictureBox, out string fileName);

        void SavePdfImage(PictureBox pictureBox, string fileName);

    }

    /// <summary>
    /// Image Action
    /// </summary>
    /// <Info>
    /// This is where all the Image and PDF Methods are stored
    /// </Info>
    class ImageActions : IImageActions
    {
        /// <summary>
        /// Loads the image into Picture box
        /// </summary>
        /// <param name="pictureBox">Name of picture box used in form</param>
        /// <param name="fileName">The name of the image file</param>
        /// <param name="Height">Hight of the Image </param>
        /// <param name="Width">Width of the Image</param>
        /// <param name="Size">File Size of the image</param>
        /// <returns>
        /// This will Return the image its self inside the picture box and will populate all of the fields in the form about that image
        /// </returns>
        public string LoadImage(PictureBox pictureBox, out string fileName, out int Height, out int Width, out long Size)
        {
            string filename;

            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (MagickImage image = new MagickImage(open.FileName))
                {
                    MagickImageInfo info = new MagickImageInfo(open.FileName);

                    Height = info.Height;
                    Width = info.Width;

                    pictureBox.Image = image.ToBitmap();
                    filename = image.FileName;

                    Size = new FileInfo(open.FileName).Length;
                }
            }
            else
            {
                filename = string.Empty;
                Height = 0;
                Width = 0;
                Size = 0;
            }

            return fileName = filename;
        }
        
        /// <summary>
        /// Save a Copy of the new image
        /// </summary>
        /// <param name="pictureBox">Name of picture box used in form</param>
        /// <param name="colorSpace">ColourSpace Selected</param>
        /// <param name="fileName">Original image location</param>
        /// <param name="Format">Image Type</param>
        /// <param name="Quality">Quality of image (int)</param>
        /// <param name="Width">Width of image</param>
        /// <param name="Height">Height of image</param>
        /// <seealso cref="ImageActions.SavePdfImage(PictureBox, string)">
        /// This will Save the PDF as an image
        /// </seealso>
        public void SaveImage(PictureBox pictureBox, string colorSpace, string fileName, string Format, int Quality, int Width, int Height)
        {
            ImageFormat imageFormat = null;
            var save = new SaveFileDialog();
            using (MemoryStream memStream = new MemoryStream())
            {

                using (MagickImage image = new MagickImage(fileName))
                {
                    MagickGeometry size = new MagickGeometry(Width, Height);
                    size.IgnoreAspectRatio = true;
                    image.Quality = Quality;

                    #region Colour and Format
                    switch (colorSpace)
                    {
                        case "CMY":
                            image.ColorSpace = ColorSpace.CMY;
                            break;
                        case "CMYK":
                            image.ColorSpace = ColorSpace.CMYK;
                            break;
                        case "Gray":
                            image.ColorSpace = ColorSpace.Gray;
                            break;
                        case "HCL":
                            image.ColorSpace = ColorSpace.HCL;
                            break;
                        case "HCLp":
                            image.ColorSpace = ColorSpace.HCLp;
                            break;
                        case "HSB":
                            image.ColorSpace = ColorSpace.HSB;
                            break;
                        case "HSI":
                            image.ColorSpace = ColorSpace.HSI;
                            break;
                        case "HSL":
                            image.ColorSpace = ColorSpace.HSL;
                            break;
                        case "HSV":
                            image.ColorSpace = ColorSpace.HSV;
                            break;
                        case "HWB":
                            image.ColorSpace = ColorSpace.HWB;
                            break;
                        case "Lab":
                            image.ColorSpace = ColorSpace.Lab;
                            break;
                        case "LCH":
                            image.ColorSpace = ColorSpace.LCH;
                            break;
                        case "LCHab":
                            image.ColorSpace = ColorSpace.LCHab;
                            break;
                        case "LCHuv":
                            image.ColorSpace = ColorSpace.LCHuv;
                            break;
                        case "Log":
                            image.ColorSpace = ColorSpace.Log;
                            break;
                        case "LMS":
                            image.ColorSpace = ColorSpace.LMS;
                            break;
                        case "Luv":
                            image.ColorSpace = ColorSpace.Luv;
                            break;
                        case "OHTA":
                            image.ColorSpace = ColorSpace.OHTA;
                            break;
                        case "Rec601YCbCr":
                            image.ColorSpace = ColorSpace.Rec601YCbCr;
                            break;
                        case "Rec709YCbCr":
                            image.ColorSpace = ColorSpace.Rec709YCbCr;
                            break;
                        case "RGB":
                            image.ColorSpace = ColorSpace.RGB;
                            break;
                        case "scRGB":
                            image.ColorSpace = ColorSpace.scRGB;
                            break;
                        case "sRGB":
                            image.ColorSpace = ColorSpace.sRGB;
                            break;
                        case "Transparent":
                            image.ColorSpace = ColorSpace.Transparent;
                            break;
                        case "XyY":
                            image.ColorSpace = ColorSpace.XyY;
                            break;
                        case "XYZ":
                            image.ColorSpace = ColorSpace.XYZ;
                            break;
                        case "YCbCr":
                            image.ColorSpace = ColorSpace.YCbCr;
                            break;
                        case "YCC":
                            image.ColorSpace = ColorSpace.YCC;
                            break;
                        case "YDbDr":
                            image.ColorSpace = ColorSpace.YDbDr;
                            break;
                        case "YIQ":
                            image.ColorSpace = ColorSpace.YIQ;
                            break;
                        case "YPbPr":
                            image.ColorSpace = ColorSpace.YPbPr;
                            break;
                        case "YUV":
                            image.ColorSpace = ColorSpace.YUV;
                            break;
                        case "LinearGRAY":
                            image.ColorSpace = ColorSpace.LinearGRAY;
                            break;
                        default:
                            image.ColorSpace = ColorSpace.Undefined;
                            break;
                    }

                    switch (Format)
                    {
                        case "PNG":
                            image.Format = MagickFormat.Png;
                            imageFormat = ImageFormat.Png;
                            save.Filter = "Images|*.png;";
                            break;
                        case "GIF":
                            image.Format = MagickFormat.Gif;
                            imageFormat = ImageFormat.Gif;
                            save.Filter = "Images|*.gif;";
                            break;
                        case "JPEG":
                            image.Format = MagickFormat.Jpeg;
                            imageFormat = ImageFormat.Jpeg;
                            save.Filter = "Images|*.jpeg;";
                            break;
                        case "BMP":
                            image.Format = MagickFormat.Bmp;
                            imageFormat = ImageFormat.Bmp;
                            save.Filter = "Images|*.Bmp;";
                            break;
                        case "TIFF":
                            image.Format = MagickFormat.Tiff;
                            imageFormat = ImageFormat.Tiff;
                            save.Filter = "Images|*.Tiff;";
                            break;
                        default:

                            break;
                    }
                    #endregion
                    image.Resize(size);
                    image.Write(memStream);


                    Bitmap bitmap = new Bitmap(memStream);
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = bitmap;

                        image.Write(save.FileName);

                        MessageBox.Show("Your image has been saved");
                    }
                    else
                    {
                        MessageBox.Show("There was an error");
                    }
                    image.Dispose();
                }
            }
        }

        /// <summary>
        /// Showing New image with the new properties
        /// </summary>
        /// <param name="fileName">Original image location</param>
        /// <param name="colorSpace">ColourSpace Selected</param>
        /// <param name="Format">Image Type</param>
        /// <param name="pictureBox">Name of picture box used in form</param>
        /// <param name="Quality">Quality of image (int)</param>
        /// <param name="Width">Width of image</param>
        /// <param name="Height">Height of image</param>
        /// <param name="Size">New Size of image</param>
        public void ShowImage(string fileName, string colorSpace, string Format, PictureBox pictureBox, int Quality, int Width, int Height, out long Size)
        {
            ImageFormat imageFormat = null;
            using (MagickImage image = new MagickImage(fileName))
            {
                MagickGeometry size = new MagickGeometry(Width, Height);
                size.IgnoreAspectRatio = true;
                image.Quality = Quality;
                #region Colour and Format
                switch (colorSpace)
                {
                    case "CMY":
                        image.ColorSpace = ColorSpace.CMY;
                        break;
                    case "CMYK":
                        image.ColorSpace = ColorSpace.CMYK;
                        break;
                    case "Gray":
                        image.ColorSpace = ColorSpace.Gray;
                        break;
                    case "HCL":
                        image.ColorSpace = ColorSpace.HCL;
                        break;
                    case "HCLp":
                        image.ColorSpace = ColorSpace.HCLp;
                        break;
                    case "HSB":
                        image.ColorSpace = ColorSpace.HSB;
                        break;
                    case "HSI":
                        image.ColorSpace = ColorSpace.HSI;
                        break;
                    case "HSL":
                        image.ColorSpace = ColorSpace.HSL;
                        break;
                    case "HSV":
                        image.ColorSpace = ColorSpace.HSV;
                        break;
                    case "HWB":
                        image.ColorSpace = ColorSpace.HWB;
                        break;
                    case "Lab":
                        image.ColorSpace = ColorSpace.Lab;
                        break;
                    case "LCH":
                        image.ColorSpace = ColorSpace.LCH;
                        break;
                    case "LCHab":
                        image.ColorSpace = ColorSpace.LCHab;
                        break;
                    case "LCHuv":
                        image.ColorSpace = ColorSpace.LCHuv;
                        break;
                    case "Log":
                        image.ColorSpace = ColorSpace.Log;
                        break;
                    case "LMS":
                        image.ColorSpace = ColorSpace.LMS;
                        break;
                    case "Luv":
                        image.ColorSpace = ColorSpace.Luv;
                        break;
                    case "OHTA":
                        image.ColorSpace = ColorSpace.OHTA;
                        break;
                    case "Rec601YCbCr":
                        image.ColorSpace = ColorSpace.Rec601YCbCr;
                        break;
                    case "Rec709YCbCr":
                        image.ColorSpace = ColorSpace.Rec709YCbCr;
                        break;
                    case "RGB":
                        image.ColorSpace = ColorSpace.RGB;
                        break;
                    case "scRGB":
                        image.ColorSpace = ColorSpace.scRGB;
                        break;
                    case "sRGB":
                        image.ColorSpace = ColorSpace.sRGB;
                        break;
                    case "Transparent":
                        image.ColorSpace = ColorSpace.Transparent;
                        break;
                    case "XyY":
                        image.ColorSpace = ColorSpace.XyY;
                        break;
                    case "XYZ":
                        image.ColorSpace = ColorSpace.XYZ;
                        break;
                    case "YCbCr":
                        image.ColorSpace = ColorSpace.YCbCr;
                        break;
                    case "YCC":
                        image.ColorSpace = ColorSpace.YCC;
                        break;
                    case "YDbDr":
                        image.ColorSpace = ColorSpace.YDbDr;
                        break;
                    case "YIQ":
                        image.ColorSpace = ColorSpace.YIQ;
                        break;
                    case "YPbPr":
                        image.ColorSpace = ColorSpace.YPbPr;
                        break;
                    case "YUV":
                        image.ColorSpace = ColorSpace.YUV;
                        break;
                    case "LinearGRAY":
                        image.ColorSpace = ColorSpace.LinearGRAY;
                        break;
                    default:
                        image.ColorSpace = ColorSpace.Undefined;
                        break;
                }
                switch (Format)
                {
                    case "PNG":
                        image.Format = MagickFormat.Png;
                        imageFormat = ImageFormat.Png;

                        break;
                    case "GIF":
                        image.Format = MagickFormat.Gif;
                        imageFormat = ImageFormat.Gif;

                        break;
                    case "JPEG":
                        image.Format = MagickFormat.Jpeg;
                        imageFormat = ImageFormat.Jpeg;
                        ;
                        break;
                    case "BMP":
                        image.Format = MagickFormat.Bmp;
                        imageFormat = ImageFormat.Bmp;

                        break;
                    case "TIFF":
                        image.Format = MagickFormat.Tiff;
                        imageFormat = ImageFormat.Tiff;

                        break;
                    default:

                        break;
                }
                #endregion

                image.Resize(size);

                // In order for the compression to show I have to do it though the memory steam.
                MemoryStream memStream = new MemoryStream();
                image.Write(memStream);

                Bitmap bitmap = new Bitmap(memStream);

                pictureBox.Image = bitmap;

                Size = memStream.Length;

                image.Dispose();
            }
        }
        
        /// <summary>
        /// Saves the PDF as an image
        /// </summary>
        /// <param name="pictureBox">Shows the PDF as a picture</param>
        /// <param name="fileName">FileName/Location of PDF</param>
        public void SavePdfImage(PictureBox pictureBox, string fileName)
        {
            var save = new SaveFileDialog();
            using (MemoryStream memStream = new MemoryStream())
            {
                MagickReadSettings settings = new MagickReadSettings();
                // Settings the density to 300 dpi will create an image with a better quality
                settings.Density = new Density(50);

                using (MagickImageCollection images = new MagickImageCollection(fileName))
                {
                    using (IMagickImage vertical = images.AppendVertically())
                    {
                        vertical.Write(memStream, MagickFormat.Png);
                    }
                    save.Filter = "Images|*.png;";

                    Bitmap bitmap = new Bitmap(memStream);
                    if (save.ShowDialog() == DialogResult.OK)
                    {

                        pictureBox.Image = bitmap;
                        pictureBox.Image.Save(save.FileName, ImageFormat.Png);
                        MessageBox.Show("Your image has been saved");
                    }
                    else
                    {
                        MessageBox.Show("There was an error");
                    }
                    images.Dispose();
                }
            }
        }

        /// <summary>
        /// Loads the PDF into the Form
        /// </summary>
        /// <param name="pictureBox">Name of picture box used in form</param>
        /// <param name="fileName">Original image location</param>
        /// <returns></returns>
        public string LoadPDF(PictureBox pictureBox, out string fileName)
        {
            string filename;
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (MemoryStream tempImage = new MemoryStream())
                {
                    MagickReadSettings settings = new MagickReadSettings();
                    // Settings the density to 300 dpi will create an image with a better quality
                    settings.Density = new Density(50);

                    using (MagickImageCollection images = new MagickImageCollection(open.FileName))
                    {
                        using (IMagickImage vertical = images.AppendVertically())
                        {
                            vertical.Write(tempImage, MagickFormat.Png);
                        }

                        Bitmap bitmap = new Bitmap(tempImage);

                        pictureBox.Image = bitmap;

                        filename = open.FileName;

                    }
                }
            }
            else
            {
                filename = string.Empty;
            }

            return fileName = filename;
        }
    }
}
