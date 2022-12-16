using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorFinale
{
    internal static class ColorMatrixes
    {
        public readonly static ColorMatrix GrayScale = new ColorMatrix(new float[][]
        {
            new float[]{.299f, .299f, .299f, 0, 0},
            new float[]{.587f, .587f, .587f, 0, 0},
            new float[]{.114f, .114f, .114f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        public readonly static ColorMatrix SepiaTone = new ColorMatrix(new float[][]
{
            new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
});
        public readonly static ColorMatrix BlackAndWhite = new ColorMatrix(new float[][]
{
            new float[]{1.5f, 1.5f, 1.5f, 0, 0},
            new float[]{1.5f, 1.5f, 1.5f, 0, 0},
            new float[]{1.5f, 1.5f, 1.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{-1, -1, -1, 0, 1}
});
        public readonly static ColorMatrix Negative = new ColorMatrix(new float[][]
{
            new float[]{-1f, 0, 0, 0, 0},
            new float[]{0, -1f, 0, 0, 0},
            new float[]{0, 0, -1f, 0, 0},
            new float[]{0, 0, 0, 1f, 0},
            new float[]{1, 1, 1, 0, 1}
});
        public readonly static ColorMatrix Default = new ColorMatrix(new float[][]
{
            new float[]{1, 0, 0, 0, 0},
            new float[]{0, 1, 0, 0, 0},
            new float[]{0, 0, 1, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
});
    }
}
