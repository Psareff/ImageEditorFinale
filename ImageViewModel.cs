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
    internal class ImageViewModel : ImageEditorItem
    {
        private ImageEditorItem _imageEditorItem;

        public Image _image;
        private BitmapImage _bitmapImage;
        private string _filename;


        public ImageViewModel()
        {
            _imageEditorItem = new ImageEditorItem();
        }
        public ImageEditorItem Photo
        {
            get => _imageEditorItem;
            set => _imageEditorItem = value;
        }
        public ImageViewModel(ImageEditorItem imageEditorItem, string filename)
        {
            _imageEditorItem = imageEditorItem;
            _filename = filename;

            _bitmapImage = new BitmapImage();
            _bitmapImage.BeginInit();
            _bitmapImage.UriSource = new Uri(filename, UriKind.Absolute);
            _bitmapImage.EndInit();
            Panel.SetZIndex(this, -2);
            _image = new Image();
            _image.Source = _bitmapImage;
            Child = _image;
            Canvas.SetLeft(this, _imageEditorItem._location.X);
            Canvas.SetTop(this, _imageEditorItem._location.Y);

        }

        public BitmapImage bitmapImage
        {
            get => _bitmapImage;
            set => _bitmapImage = value;
        }

        public string filename
        {
            get => _filename;
            set => _filename = value;
        }
    }
}