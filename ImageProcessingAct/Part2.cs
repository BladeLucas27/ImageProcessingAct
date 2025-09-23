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
    public partial class Part2 : UserControl
    {
        Bitmap imageA, imageB;
        Bitmap bitmapResult;
        int widthA, heightA, widthB, heightB;
        int greenThreshold = 180;
        int redBlueMax = 100;
        public Part2()
        {
            InitializeComponent();
        }

        private void pictureBoxA_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxB_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            greenThreshold = trackBar1.Value;
        }

        private void pictureBoxResult_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            redBlueMax = trackBar3.Value;
        }

        private Bitmap ResizeBitmap(Bitmap source, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(source, 0, 0, width, height);
            }
            return result;
        }

        private void buttonLoad1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select an Image File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                Image img = Image.FromFile(selectedFilePath);
                pictureBoxA.Image = img;
                imageB = new Bitmap(img);
                widthB = imageB.Width;
                heightB = imageB.Height;
            }
        }

        private void buttonLoad2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog2.Title = "Select an Image File";
            
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog2.FileName;
                Image img = Image.FromFile(selectedFilePath);
                pictureBoxB.Image = img;
                imageA = ResizeBitmap(new Bitmap(img), widthB, heightB);
                widthA = imageA.Width;
                heightA = imageA.Height;
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            int width = Math.Min(widthA, widthB);
            int height = Math.Min(heightA, heightB);
            bitmapResult = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color bgPixel = imageA.GetPixel(x, y);

                    if (pixel.G > greenThreshold && pixel.R < redBlueMax && pixel.B < redBlueMax)
                    {
                        bitmapResult.SetPixel(x, y, bgPixel);
                    }
                    else
                    {
                        bitmapResult.SetPixel(x, y, pixel);
                    }
                }
            }
            pictureBoxResult.Image = bitmapResult;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxResult.Image != null)
            {
                saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
                saveFileDialog1.Title = "Save the Edited Image";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog1.FileName;
                    pictureBoxResult.Image.Save(saveFilePath);
                }
            }
        }
    }
}
