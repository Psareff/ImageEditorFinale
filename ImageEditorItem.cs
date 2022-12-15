using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace ImageEditorFinale
{
    internal class ImageEditorItem : Border
    {
        public Point _location;

        //private List<Modifier> modifiers;

        public ImageEditorItem()
        {

        }

        public ImageEditorItem(Point location)
        {
            _location = location;
        }

        internal void Select()
        {
            Trace.WriteLine("Is selected");
            this.BorderBrush = Brushes.LightGray;
            this.BorderThickness = new Thickness(1);
        }
        internal void Deselect() => this.BorderThickness = new Thickness(0);


    }
}
