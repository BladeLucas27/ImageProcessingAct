using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingAct
{
    public partial class ConvolutionMatrix : UserControl
    {
        Bitmap originalBitmap;
        Bitmap editedBitmap;
        Bitmap reversedBitmap;
        int originalWidth, originalHeight;
        public ConvolutionMatrix()
        {
            InitializeComponent();
        }

        private void ConvolutionMatrix_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxEdited.Image != null)
            {
                saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
                saveFileDialog1.Title = "Save the Edited Image";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog1.FileName;
                    pictureBoxEdited.Image.Save(saveFilePath);
                }
            }
        }

        private void buttonSmooth_Click(object sender, EventArgs e)
        {
            if(pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.Smooth(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
            
        }

        private void buttonGaussian_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.GaussianBlur(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonSharpen_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.Sharpen(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonMeanRemoval_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.MeanRemoval(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonEmbossLaplascian_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.EmbossLaplascian(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonEmboss_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.EmbossHoriVert(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonEmbossAllDirections_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.EmbossAllDirections(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonEmbossLossy_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.EmbossLossy(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonEmbossHorizontal_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.EmbossHorizontal(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonEmbossVertical_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                editedBitmap = ConvMatrix.EmbossVertical(originalBitmap);
                pictureBoxEdited.Image = editedBitmap;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select an Image File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBoxOriginal.Image = Image.FromFile(selectedFilePath);
                originalBitmap = new Bitmap(pictureBoxOriginal.Image);
                originalWidth = (int)originalBitmap.Width;
                originalHeight = (int)originalBitmap.Height;
            }
        }
    }
    public class ConvMatrix
    {
        public int TopLeft = 0, TopMid = 0, TopRight = 0;
        public int MidLeft = 0, Pixel = 1, MidRight = 0;
        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
        public int Factor = 1;
        public int Offset = 0;
        public void SetAll(int nVal)
        {
            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
        }

        public static bool Conv3x3(Bitmap b, ConvMatrix m)
        {
            // Avoid divide by zero errors 
            if (0 == m.Factor)
                return false; Bitmap

            // GDI+ still lies to us - the return format is BGR, NOT RGB.  
            bSrc = (Bitmap)b.Clone();
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),
                               ImageLockMode.ReadWrite,
                               PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            int stride2 = stride * 2;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width - 2;
                int nHeight = b.Height - 2;
                int nPixel;
                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = ((((pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) +
                            (pSrc[8] * m.TopRight) + (pSrc[2 + stride] * m.MidLeft) +
                            (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) +
                            (pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) +
                            (pSrc[8 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[5 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) +
                            (pSrc[7] * m.TopRight) + (pSrc[1 + stride] * m.MidLeft) +
                            (pSrc[4 + stride] * m.Pixel) + (pSrc[7 + stride] * m.MidRight) +
                            (pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) +
                            (pSrc[7 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[4 + stride] = (byte)nPixel;
                        nPixel = ((((pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) +
                                       (pSrc[6] * m.TopRight) + (pSrc[0 + stride] * m.MidLeft) +
                                       (pSrc[3 + stride] * m.Pixel) + (pSrc[6 + stride] * m.MidRight) +
                                       (pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) +
                                       (pSrc[6 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        p[3 + stride] = (byte)nPixel;
                        p += 3;
                        pSrc += 3;
                    }
                    p += nOffset;
                    pSrc += nOffset;
                }
            }
            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);
            return true;
        }
        public static Bitmap Smooth(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Factor = 9;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap GaussianBlur(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = 1;
            m.TopMid = m.BottomMid = m.MidLeft = m.MidRight = 2;
            m.Pixel = 4;
            m.Factor = 16;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap Sharpen(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = 0;
            m.TopMid = m.BottomMid = m.MidLeft = m.MidRight = -2;
            m.Pixel = 11;
            m.Factor = 3;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap MeanRemoval(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = 9;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap EmbossLaplascian(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = -1;
            m.TopMid = m.BottomMid = m.MidLeft = m.MidRight = 0;
            m.Pixel = 4;
            m.Factor = 1;
            m.Offset = 127;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap EmbossHoriVert(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = 0;
            m.TopMid = m.BottomMid = m.MidLeft = m.MidRight = -1;
            m.Pixel = 4;
            m.Factor = 1;
            m.Offset = 127;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap EmbossAllDirections(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = 8;
            m.Factor = 1;
            m.Offset = 127;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap EmbossLossy(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.TopLeft = m.TopRight = m.BottomMid = 1;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomLeft = m.BottomRight = -2;
            m.Pixel = 4;
            m.Factor = 1;
            m.Offset = 127;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap EmbossHorizontal(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.MidLeft = m.MidRight = -1;
            m.Pixel = 2;
            m.Factor = 1;
            m.Offset = 127;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
        public static Bitmap EmbossVertical(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.TopMid = -1;
            m.BottomMid = 1;
            m.Factor = 1;
            m.Offset = 127;

            Bitmap result = (Bitmap)b.Clone();
            Conv3x3(result, m);
            return result;
        }
    }
}
