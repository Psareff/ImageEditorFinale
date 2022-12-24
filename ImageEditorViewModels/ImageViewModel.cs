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
    public class ImageViewModel : ImageEditorItem, IPrototype<ImageViewModel> 
    {

        public Image _image;
        private BitmapImage _bitmapImage;
        private string _filename;


        public ImageViewModel()
        {

        }

        public ImageViewModel(Point location, string filename) : base (location)
        {
            _filename = filename;

            _bitmapImage = new BitmapImage();
            _bitmapImage.BeginInit();
            _bitmapImage.UriSource = new Uri(filename, UriKind.Absolute);
            _bitmapImage.EndInit();
            Panel.SetZIndex(this, 2);
            _image = new Image();
            _image.Source = _bitmapImage;
            _image.Stretch = Stretch.Fill;
            Child = _image;
            Trace.WriteLine(filename);
            Canvas.SetLeft(this, base._location.X);
            Canvas.SetTop(this, base._location.Y);

        }

        public ImageViewModel CreateDeepCopy()
            => (ImageViewModel)MemberwiseClone();

        public BitmapImage bitmapImage
        {
            get => _bitmapImage;
            set => _bitmapImage = value;
        }

        public Image Image
        {
            get => _image;
            set => _image = value;
        }

        public string filename
        {
            get => _filename;
            set => _filename = value;
        }

    }
}