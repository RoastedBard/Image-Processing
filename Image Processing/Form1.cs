using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        [DllImport("GaussianBlur.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GaussianBlur(double[] imageData, int convolutionKernelSize, int convolutionKernelDeviation, int imageWidth, int imageHeight);

        public static double[] imageData;

        Bitmap image;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonApplyGaussian_Click(object sender, EventArgs e)
        {
            image = (Bitmap)pictureBoxImage.Image;

            int imageDataLength = pictureBoxImage.Width * pictureBoxImage.Height;
            imageData = new double[imageDataLength];

            for (int i = 0; i < image.Height; ++i)
            {
                for (int j = 0; j < image.Width; ++j)
                {
                    imageData[pictureBoxImage.Width * i + j] = (double)image.GetPixel(j, i).R;
                }
            }

            GaussianBlur(imageData, (int)numericUpDownConvolutionKernelSize.Value, (int)numericUpDownConvolutionKernelDeviation.Value, image.Width, image.Height);

            for (int i = 0; i < image.Height; ++i)
            {
                for (int j = 0; j < image.Width; ++j)
                {
                    int colorValue = (int)Math.Floor(imageData[pictureBoxImage.Width * i + j]);
                    Color newColor = Color.FromArgb(255, colorValue, colorValue, colorValue);
                    image.SetPixel(j, i, newColor);
                }
            }

            pictureBoxImage.Refresh();
            pictureBoxImage.Image = image;
        }
    }
}
