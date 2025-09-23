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

        //private void buttonHistogram_Click(object sender, EventArgs e)
        //{
        //    Graphics g = pictureBoxEdited.CreateGraphics();
        //    g.Clear(Color.White);
        //    if (pictureBoxOriginal.Image != null)
        //    {
        //        int[] histogram = new int[256];
        //        for (int y = 0; y < originalHeight; y++)
        //        {
        //            for (int x = 0; x < originalWidth; x++)
        //            {
        //                Color originalColor = originalBitmap.GetPixel(x, y);
        //                int grayValue = (int)((originalColor.R + originalColor.G + originalColor.B) / 3);
        //                histogram[grayValue]++;
        //            }
        //        }
        //        int max = histogram.Max();
        //        for (int i = 0; i < 256; i++)
        //        {
        //            int barHeight = (int)((histogram[i] / (float)max) * pictureBoxEdited.Height);
        //            g.DrawLine(Pens.Black, i * 2, pictureBoxEdited.Height, i * 2, pictureBoxEdited.Height - barHeight);
        //        }
        //    }
        //}
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
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ignoreGreen = !ignoreGreen;
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
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            isReversed = !isReversed;
        }

        private void pictureBoxOriginal_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxEdited_Click_1(object sender, EventArgs e)
        {

        }
    }
}
