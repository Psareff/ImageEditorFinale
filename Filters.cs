
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditorFinale
{
    internal static class Filters
    {
        public static ImageViewModel ConvertToGrayScale(ImageViewModel image)
        {
            Bitmap bmp = Converter.FromBitmapImagetoBitmap(image.bitmapImage);
            Color p;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int average = (r + g + b) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(a, average, average, average));

                }
            }
            image.bitmapImage = Converter.BitmapToBitmapImage(bmp); ;
            return image;

        }
    }
}
