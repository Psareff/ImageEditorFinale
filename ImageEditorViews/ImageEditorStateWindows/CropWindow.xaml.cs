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
        private ImageViewModel _imageViewModel;

        public CropWindow(ImageViewModel imageViewModel)
        {
            _imageViewModel = imageViewModel.CreateDeepCopy();
            CroppingCanvas.Width = _imageViewModel._image.ActualWidth;
            CroppingCanvas.Height = _imageViewModel._image.ActualHeight;
            CroppingCanvas.Children.Add(_imageViewModel);
            InitializeComponent();
        }
    }
}
