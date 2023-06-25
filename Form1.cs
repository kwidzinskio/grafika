using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Wypełnianie_obszaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)pictureBox1.Image;

            FillArea(25, 25, image);
        }
        private void FillArea(int x, int y, Bitmap image)
        {
            Color borderColor = image.GetPixel(0, 0);
            Color fillColor = Color.BlueViolet;

            if (x < 0 || x >= image.Width - 1 || y < 0 || y >= image.Height - 1)
            {
                return;
            }

            image.SetPixel(x, y, fillColor);

            if (image.GetPixel(x - 1, y).ToArgb() != borderColor.ToArgb() && image.GetPixel(x - 1, y).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x - 1, y, image);
            }
            if (image.GetPixel(x + 1, y).ToArgb() != borderColor.ToArgb() && image.GetPixel(x + 1, y).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x + 1, y, image);
            }
            if (image.GetPixel(x, y - 1).ToArgb() != borderColor.ToArgb() && image.GetPixel(x, y - 1).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x, y - 1, image);
            }
            if (image.GetPixel(x, y + 1).ToArgb() != borderColor.ToArgb() && image.GetPixel(x, y + 1).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x, y + 1, image);
            }

            pictureBox1.Image = image;
        }
    }
}

