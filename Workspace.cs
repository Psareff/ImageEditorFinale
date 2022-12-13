using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace ImageEditorFinale
{
    internal class Workspace : Canvas
    {
        private double _scale;
        public MatrixTransform matrixTransform;
        public Matrix matrix;

        public Workspace()
        {
            matrixTransform = (MatrixTransform)this.RenderTransform;
            matrix = matrixTransform.Matrix;
            _scale = 1;
        }

        public double scale
        {
            get { return _scale; }
            set { _scale = value; }
        }
    }
}
