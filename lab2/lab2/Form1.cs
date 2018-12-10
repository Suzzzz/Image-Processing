using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.IO;

namespace lab2
{
    public partial class Form1 : Form
    {
        preprocessing p = new preprocessing();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select Image File";
            ofd.Filter = "images(*.PMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "ALL files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (p.LoadOrignal(ofd.FileName))
                    {
                    string picPath = ofd.FileName.ToString();
                    pictureBox1.ImageLocation = picPath;
                    pictureBox1.Load(ofd.FileName);
                }
            }
            p.Extract();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.GrayScale();
            double val = Convert.ToDouble(textBox1.Text);
            p.ThresholdImage(val);
            // p.ThresholdImage(500);
            Image copy = GetCopyImage("3.jpg");
            pictureBox2.Image = copy;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("1.jpg");
            File.Delete("2.jpg");
            File.Delete("3.jpg");
        }
    }
}
