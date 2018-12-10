using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace lab2
{
    class preprocessing
    {
        public IplImage scr;
        public IplImage bw;
        public IplImage gray;


        public bool LoadOrignal(string fname)
        {
            scr = Cv.LoadImage(fname, LoadMode.Color);
                Cv.SaveImage("1.jpg", scr);
            if (scr != null)
                return true;
            return false;
        }
        public void Extract()
        {
            System.Windows.Forms.MessageBox.Show("Height:" + scr.Height + "width:" + scr.Width + "no of channels:" + scr.NChannels);

        }
        public void ThresholdImage(double threshValue)
        {
            bw = Cv.CreateImage(scr.Size, BitDepth.U8 ,1);
            Cv.Threshold(gray, bw, threshValue, 255, ThresholdType.Binary);
            Cv.SaveImage("2.jpg", bw);

        }
        public void GrayScale() {
            gray = Cv.CreateImage(scr.Size, BitDepth.U8, 1);
                 Cv.CvtColor(scr, gray, ColorConversion.RgbaToGray);
            Cv.SaveImage("3.jpg", gray);
        }
    } 
   
}
