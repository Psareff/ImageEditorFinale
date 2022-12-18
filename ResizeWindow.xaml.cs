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
    /// Interaction logic for ResizeWindow.xaml
    /// </summary>
    public partial class ResizeWindow : Window
    {
        public ImageViewModel _imageViewModel;

        public ResizeWindow(ImageViewModel imageViewModel)
        {
            _imageViewModel = imageViewModel;
            InitializeComponent();
            WidthSetter.Text = Convert.ToString(_imageViewModel._image.ActualWidth);
            HeightSetter.Text = Convert.ToString(_imageViewModel._image.ActualHeight);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            double newWidth = Convert.ToDouble(WidthSetter.Text);
            double newHeight = Convert.ToDouble(HeightSetter.Text);
            if (newWidth != null && newWidth > 0)
                _imageViewModel._image.Width = Convert.ToDouble(WidthSetter.Text);
            if (newHeight != null && newHeight > 0)
                _imageViewModel._image.Height = Convert.ToDouble(HeightSetter.Text);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}