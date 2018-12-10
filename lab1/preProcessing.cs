using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;

namespace lab1
{
    class preProcessing
    {
        public IplImage src,gray,nc;

        public void LoadOriginal() 
        {
            src=Cv.LoadImage("apples.jpg", LoadMode.Color);
            Cv.SaveImage("1.jpg",src);
        }

        public void GrayScale()
        {
            gray = Cv.CreateImage(src.Size, BitDepth.U8,1);
            Cv.CvtColor(src,gray,ColorConversion.RgbToGray);
            Cv.SaveImage("2.jpg",gray);
        }

        public void NegativeColor()
        {
            nc = Cv.CreateImage(src.Size, BitDepth.U8, 3);
            Cv.Not(src,nc);
            Cv.SaveImage("3.jpg",nc);

        }

        public void NegativeGray()
        {
            nc = Cv.CreateImage(src.Size, BitDepth.U8, 1);
            Cv.Not(gray, nc);
            Cv.SaveImage("4.jpg", nc);

        }



    }
}
