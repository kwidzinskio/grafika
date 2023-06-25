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
            
            
            FillArea(5, 5);
        }
        private void FillArea(int x, int y )
        {
            Bitmap image = (Bitmap)pictureBox1.Image;
            int width = image.Width;
            int height = image.Height;
            Color borderColor = image.GetPixel(1, 1);
            Color fillColor = Color.Azure;
            // Sprawdzanie, czy punkt znajduje się w obszarze obrazka
            if (x < 0 || x >= width || y < 0 || y >= height)
            {
                return;
            }


            // Sprawdzanie, czy piksel ma odpowiedni kolor
            //Color pixelColor = image.GetPixel(x, y);
            //if (pixelColor != borderColor && pixelColor != insideColor)
            //{
            //    return;
            //}

            // Wypełnianie piksela nowym kolorem
            image.SetPixel(x, y, fillColor);

            // Rekurencyjne wypełnianie sąsiadujących pikseli
            //if (image.GetPixel(x - 1, y) != borderColor && image.GetPixel(x-1,y)!=fillColor)
            //{ FillArea(x - 1, y); }
            //if (image.GetPixel(x + 1, y) != borderColor && image.GetPixel(x + 1, y) != fillColor)
            //{ FillArea(x + 1, y); }
            //if (image.GetPixel(x, y - 1) != borderColor && image.GetPixel(x , y-1) != fillColor)
            //{ FillArea(x, y - 1); }
            //if (image.GetPixel(x, y + 1) != borderColor && image.GetPixel(x, y+1) != fillColor)
            //{ FillArea(x, y + 1); }
            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)pictureBox1.Image;
            image.SetPixel(5, 5, Color.Azure);
            image.SetPixel(6, 5, Color.Azure);
            image.SetPixel(7, 5, Color.Azure);
            pictureBox2.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

