using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotofilter
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                //Opens the file
                bitmap = new Bitmap(openFile.FileName);
                pbImage.Image = bitmap;
                pbImage.Width = bitmap.Width;
                pbImage.Height = bitmap.Height;

                //Change(swap) picture
                Color original = bitmap.GetPixel(10, 25);

                //How to change the color
                Color modified = Color.FromArgb(original.R, original.G, original.R);
                /*
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        bitmap.SetPixel(x, y, original);
                    }
                }
                */
                //saves the picture with a new name inside the CODE file
                //bitmap.Save("minbild.png");

            }

        }
        private void skiftaFärgkanalerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    //bitmap.GetPixel(x, y);
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(original.B, original.R, original.G);
                    bitmap.SetPixel(x, y, modified);
                    pbImage.Image = bitmap;
                }
            }
            //Grått = 200/200/200
            

            //bitmap.Save("rgb.png");
            pbImage.Image = bitmap;
        }

        private void skiftaFärgerGråskalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    var greyscale = (original.R + original.G + original.B) / 3;
                    Color modified = Color.FromArgb(greyscale, greyscale, greyscale);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sparaBildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saves a copy of the current image. NOTE: Repeated use of this tool overwrites previous image unless moved/saved elsewhere.
            bitmap.Save("temporaryfotofilter.png");
        }

        private void inverteraFärgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                { 
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(255 - original.R, 255 - original.G, 255 - original.B);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }

        private void tillbaksTillStartbildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                { //FIND WAY TO GO BACK TO ORIGINAL IMAGE
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(original.R, original.G, original.B);
                    bitmap.SetPixel(x, y, modified);
                }
            }
            pbImage.Image = bitmap;
        }
    }
}
