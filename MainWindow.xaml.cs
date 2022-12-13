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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveFile_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void OpenFile_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void CropImage_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void RotateImage_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ResizeImage_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ResizeCanvas_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void SepiaFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void GrayScaleFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void BlackandWhiteFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void AboutMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void Copyright_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void SaveFile_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("File Saved");
        }
        private void OpenFile_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CropImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void RotateImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void ResizeImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void ResizeCanvas_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void SepiaFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void GrayScaleFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void BlackandWhiteFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void AboutMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void Copyright_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ChangeHue_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ChangeSat_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ChangeVal_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void AddImage_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void AddText_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void DeleteItem_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void CanvasDefaultScale_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void ChangeHue_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Hue Change window");
        }

        private void ChangeSat_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Hue Change window");
        }

        private void ChangeVal_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Hue Change window");
        }

        private void AddImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Hue Change window");
        }

        private void AddText_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Hue Change window");
        }

        private void DeleteItem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Hue Change window");
        }

        private void CanvasDefaultScale_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Canvas Default Scale");
            var element = workspace;
            var transform = (MatrixTransform)element.RenderTransform;

            transform.Matrix = Matrix.Identity;
        }

        private void CanvasZoom(object sender, MouseWheelEventArgs e)
        {
            var element = workspace;
            var position = e.GetPosition(element);
            var transform = (MatrixTransform)element.RenderTransform;
            var matrix = transform.Matrix;
            Trace.WriteLine(transform.Matrix.M11);

            var scrollDirection = e.Delta >= 0 ? 1.1 : (1.0 / 1.1);

            var scaleDelta = (transform.Matrix.M11 * 1 < 0.25  || transform.Matrix.M11 > 5) ? 1.0); // choose appropriate scaling factor
            Scale.Text = Convert.ToInt32(transform.Matrix.M11*100)  + "%"; 
            matrix.ScaleAtPrepend(scaleDelta, scaleDelta, position.X, position.Y);
            transform.Matrix = matrix;
        }
    }
}
