using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessingAct
{
    public partial class Part2 : UserControl
    {
        Bitmap imageA, imageB;
        Bitmap bitmapResult;
        int widthA, heightA, widthB, heightB;
        int greenThreshold = 180;
        int redBlueMax = 100;
        private Device webcamDevice;
        private Timer frameTimer;
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

        private void buttonUseWebcam_Click(object sender, EventArgs e)
        {
            webcamDevice = new Device(0); // Use the correct index for your webcam
            webcamDevice.ShowWindow(pictureBoxA); // Show webcam preview in PictureBox
            Bitmap frame = webcamDevice.CaptureFrame();
            imageB = new Bitmap(frame);
            widthB = imageB.Width;
            heightB = imageB.Height;
        }

        private void StartLiveProcessing()
        {
            //webcamDevice = new Device(0); // Use the correct index for your camera
            //webcamDevice.ShowWindow(pictureBoxA); // Show live preview

            frameTimer = new Timer();
            frameTimer.Interval = 500; // ~30 FPS
            frameTimer.Tick += (s, e) =>
            {
                Bitmap frame = webcamDevice.CaptureFrame();
                if (frame != null)
                {
                    Bitmap processed = SubtractGreenscreen(frame); // Your existing method
                    pictureBoxResult.Image = processed;
                }
            };
            frameTimer.Start();
        }

        private Bitmap SubtractGreenscreen(Bitmap frame)
        {
            int width = frame.Width;
            int height = frame.Height;
            Bitmap result = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = frame.GetPixel(x, y);
                    if (pixel.G > greenThreshold && pixel.R < redBlueMax && pixel.B < redBlueMax)
                    {
                        result.SetPixel(x, y, Color.Transparent); // Replace with transparency or background
                    }
                    else
                    {
                        result.SetPixel(x, y, pixel);
                    }
                }
            }
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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
            if(webcamDevice != null)
            {
                StartLiveProcessing();
                return;
            }
            else
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
