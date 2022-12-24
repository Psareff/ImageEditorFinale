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
using System.Windows.Shapes;

namespace ImageEditorFinale
{
    /// <summary>
    /// Interaction logic for CropWindow.xaml
    /// </summary>
    public partial class CropWindow : Window
    {
        private ImageViewModel _image;

        public CropWindow(ImageViewModel image)
        {
            InitializeComponent();
            /*
            _image = new ImageViewModel(image._image);
            CroppingCanvas.Width = image._image.ActualWidth;
            CroppingCanvas.Height = image._image.ActualHeight;
            CroppingCanvas.Children.Add(new ImageViewModel(image._image));
            */
        }
    }
}
