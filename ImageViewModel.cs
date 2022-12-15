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

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(filename, UriKind.Absolute);
            bitmapImage.EndInit();
            Trace.Write("Width: " + bitmapImage.Width+ "; Height: " + bitmapImage.Height);
            Panel.SetZIndex(this, -2);
            _image = new Image();
            _image.Source = bitmapImage;
            Child = _image;
            Canvas.SetLeft(this, _imageEditorItem._location.X);
            Canvas.SetTop(this, _imageEditorItem._location.Y);

        }

        public string filename
        {
            get => _filename;
            set => _filename = value;
        }
    }
}