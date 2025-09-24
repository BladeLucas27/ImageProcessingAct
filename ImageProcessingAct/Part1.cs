using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingAct
{
    public partial class Part1 : UserControl
    {
        Bitmap originalBitmap;
        Bitmap editedBitmap;
        Bitmap reversedBitmap;
        int originalWidth, originalHeight;
        Boolean isReversed = false, ignoreGreen = false;
        public Part1()
        {
            InitializeComponent();
        }

        private void Part1_Load(object sender, EventArgs e)
        {

        }

        private void reverseImage()
        {
            reversedBitmap = new Bitmap(originalBitmap);
            for (int y = 0; y < originalHeight; y++)
            {
                for (int x = 0; x < originalWidth; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    reversedBitmap.SetPixel(originalWidth - 1 - x, y, originalColor);
                }
            }
        }
        private void ShowRGBHistogram(Bitmap bitmap)
        {
            if (bitmap == null || pictureBoxHistogram == null) return;

            int[] redHistogram = new int[256];
            int[] greenHistogram = new int[256];
            int[] blueHistogram = new int[256];

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    redHistogram[pixel.R]++;
                    greenHistogram[pixel.G]++;
                    blueHistogram[pixel.B]++;
                }
            }

            int max = Math.Max(redHistogram.Max(), Math.Max(greenHistogram.Max(), blueHistogram.Max()));
            int width = 256;
            int height = pictureBoxHistogram.Height > 0 ? pictureBoxHistogram.Height : 100;
            int marginLeft = 30;
            int marginBottom = 20;
            int graphWidth = width;
            int graphHeight = height - marginBottom;

            Bitmap histImage = new Bitmap(width + marginLeft, height);
            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);

                // Draw gridlines and Y-axis labels
                int gridLines = 5;
                using (Pen gridPen = new Pen(Color.LightGray, 1))
                using (Font labelFont = new Font("Arial", 8))
                using (Brush labelBrush = new SolidBrush(Color.Black))
                {
                    for (int i = 0; i <= gridLines; i++)
                    {
                        int y = marginBottom + (int)((graphHeight) * (1 - i / (float)gridLines));
                        g.DrawLine(gridPen, marginLeft, y, marginLeft + graphWidth, y);
                        int labelValue = (int)(max * i / (float)gridLines);
                        g.DrawString(labelValue.ToString(), labelFont, labelBrush, 0, y - 8);
                    }
                }

                // Draw X-axis labels (0, 64, 128, 192, 255)
                using (Font labelFont = new Font("Arial", 8))
                using (Brush labelBrush = new SolidBrush(Color.Black))
                {
                    int[] xLabels = { 0, 64, 128, 192, 255 };
                    foreach (int xLabel in xLabels)
                    {
                        int x = marginLeft + xLabel;
                        g.DrawString(xLabel.ToString(), labelFont, labelBrush, x - 10, height - marginBottom + 2);
                    }
                }

                // Draw axes
                using (Pen axisPen = new Pen(Color.Black, 2))
                {
                    // Y-axis
                    g.DrawLine(axisPen, marginLeft, marginBottom, marginLeft, height - marginBottom);
                    // X-axis
                    g.DrawLine(axisPen, marginLeft, height - marginBottom, marginLeft + graphWidth, height - marginBottom);
                }

                // Draw histogram bars
                for (int i = 0; i < 256; i++)
                {
                    int rHeight = (int)((redHistogram[i] / (float)max) * graphHeight);
                    int gHeight = (int)((greenHistogram[i] / (float)max) * graphHeight);
                    int bHeight = (int)((blueHistogram[i] / (float)max) * graphHeight);

                    int x = marginLeft + i;
                    g.DrawLine(Pens.Red, x, height - marginBottom, x, height - marginBottom - rHeight);
                    g.DrawLine(Pens.Green, x, height - marginBottom, x, height - marginBottom - gHeight);
                    g.DrawLine(Pens.Blue, x, height - marginBottom, x, height - marginBottom - bHeight);
                }
            }
            pictureBoxHistogram.Image = histImage;
            pictureBoxHistogram.Refresh();
        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
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
                reverseImage();
            }
        }

        private void buttonCopy_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                if (isReversed)
                {
                    editedBitmap = new Bitmap(reversedBitmap);
                }
                else
                {
                    editedBitmap = new Bitmap(originalBitmap);
                }
                for (int y = 0; y < originalHeight; y++)
                {
                    for (int x = 0; x < originalWidth; x++)
                    {
                        Color originalColor;
                        if (isReversed)
                        {
                            originalColor = reversedBitmap.GetPixel(x, y);
                        }
                        else
                        {
                            originalColor = originalBitmap.GetPixel(x, y);
                        }
                        editedBitmap.SetPixel(x, y, originalColor);
                    }
                }
                pictureBoxEdited.Image = editedBitmap;
                ShowRGBHistogram(editedBitmap);
            }
        }

        private void buttonSepia_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                if (isReversed)
                {
                    editedBitmap = new Bitmap(reversedBitmap);
                }
                else
                {
                    editedBitmap = new Bitmap(originalBitmap);
                }
                for (int y = 0; y < originalHeight; y++)
                {
                    for (int x = 0; x < originalWidth; x++)
                    {
                        Color originalColor;
                        if (isReversed)
                        {
                            originalColor = reversedBitmap.GetPixel(x, y);
                        }
                        else
                        {
                            originalColor = originalBitmap.GetPixel(x, y);
                        }
                        Color sepia = Color.FromArgb(Math.Min(255, (int)(originalColor.R * 0.393 + originalColor.G * 0.769 + originalColor.B * 0.189)),
                                            Math.Min(255, (int)(originalColor.R * 0.349 + originalColor.G * 0.686 + originalColor.B * 0.168)),
                                            Math.Min(255, (int)(originalColor.R * 0.272 + originalColor.G * 0.534 + originalColor.B * 0.131)));
                        editedBitmap.SetPixel(x, y, sepia);
                    }
                }
                pictureBoxEdited.Image = editedBitmap;
                ShowRGBHistogram(editedBitmap);
            }
        }

        private void buttonGrayScale_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                if (isReversed)
                {
                    editedBitmap = new Bitmap(reversedBitmap);
                }
                else
                {
                    editedBitmap = new Bitmap(originalBitmap);
                }
                for (int y = 0; y < originalHeight; y++)
                {
                    for (int x = 0; x < originalWidth; x++)
                    {
                        Color originalColor;
                        if (isReversed)
                        {
                            originalColor = reversedBitmap.GetPixel(x, y);
                        }
                        else
                        {
                            originalColor = originalBitmap.GetPixel(x, y);
                        }
                        int grayValue = (int)((originalColor.R + originalColor.G + originalColor.B) / 3);
                        Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                        editedBitmap.SetPixel(x, y, grayColor);
                    }
                }
                pictureBoxEdited.Image = editedBitmap;
                ShowRGBHistogram(editedBitmap);
            }
        }

        private void buttonInvert_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                if (isReversed)
                {
                    editedBitmap = new Bitmap(reversedBitmap);
                }
                else
                {
                    editedBitmap = new Bitmap(originalBitmap);
                }
                for (int y = 0; y < originalHeight; y++)
                {
                    for (int x = 0; x < originalWidth; x++)
                    {
                        Color originalColor;
                        if (isReversed)
                        {
                            originalColor = reversedBitmap.GetPixel(x, y);
                        }
                        else
                        {
                            originalColor = originalBitmap.GetPixel(x, y);
                        }
                        Color invertedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                        editedBitmap.SetPixel(x, y, invertedColor);
                    }
                }
                pictureBoxEdited.Image = editedBitmap;
                ShowRGBHistogram(editedBitmap);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            isReversed = !isReversed;
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
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

        private void pictureBoxOriginal_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxEdited_Click_1(object sender, EventArgs e)
        {

        }
    }
}
