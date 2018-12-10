using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        preProcessing p = new preProcessing();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.LoadOriginal();
            Image copy=GetCopyImage("2.jpg");
            pictureBox1.Image = copy;
        }

        //copy image to delete at runtime
        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.GrayScale();
            Image copy = GetCopyImage("2.jpg");
            pictureBox2.Image = copy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.GrayScale();
            p.NegativeColor();
            p.NegativeGray();

            Image copy = GetCopyImage("3.jpg");
            pictureBox2.Image = copy;

            Image copy1 = GetCopyImage("4.jpg");
            pictureBox3.Image = copy1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
