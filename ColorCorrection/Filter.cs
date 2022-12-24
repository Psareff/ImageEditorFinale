
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditorFinale
{
    internal static class Filter
    {
        public static ImageViewModel ApplyFilter(ImageViewModel image, ColorMatrix colorMatrix)
        {
            Bitmap bmp = Converter.FromBitmapImagetoBitmap(image.bitmapImage);
            Bitmap dest = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(dest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                    0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, bmpAttributes);


            }
            image.Image.Source = Converter.BitmapToBitmapImage(dest);
            return image;

        }
    }
}
