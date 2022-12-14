using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace ImageEditorFinale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ItemAlbum _itemAlbum;
        public MainWindow()
        {
            _itemAlbum = new ItemAlbum();
            InitializeComponent();
        }

        private void SaveFile_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void OpenFile_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void CropImage_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void RotateItem_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ResizeImage_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ResizeCanvas_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void ChangeText_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void SepiaFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void GrayScaleFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void BlackandWhiteFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void NegativeFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void DefaultFilter_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void AboutMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void Copyright_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void SaveFile_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void OpenFile_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CropImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageViewModel = workspace.SelectedItem();
            if (imageViewModel != null && imageViewModel is ImageViewModel)
            {
                //(imageViewModel as ImageViewModel)._image.Source;
            }
        }
        private void RotateItem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageEditorItem = workspace.SelectedItem();
            if (imageEditorItem != null)
            {
                RotateTransform rotateTransform = new RotateTransform(Convert.ToDouble(RotationSetter.Text));
                imageEditorItem.RenderTransform = rotateTransform;
            }
        }
        private void ResizeImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {


            ImageEditorItem imageViewModel = workspace.SelectedItem();
            ResizeWindow resizeWindow = new ResizeWindow(imageViewModel as ImageViewModel);
            resizeWindow.Show();
            /*
            if (imageViewModel != null && imageViewModel is ImageViewModel)
                (imageViewModel as ImageViewModel)._image.Height = Convert.ToDouble(HeightSetter.Text);
            
            if (imageViewModel != null && imageViewModel is ImageViewModel)
                (imageViewModel as ImageViewModel)._image.Width = Convert.ToDouble(WidthSetter.Text);
            */
        }
        private void ChangeText_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem textBoxViewModel = workspace.SelectedItem();
            if (textBoxViewModel != null && textBoxViewModel is TextBoxViewModel)
                (textBoxViewModel as TextBoxViewModel).ChangeText(TextSetter.Text);
        }

        private void ResizeCanvas_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            workspace.Height = Convert.ToDouble(HeightSetter.Text);
            workspace.Width = Convert.ToDouble(WidthSetter.Text);
        }
        private void SepiaFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageViewModel = workspace.SelectedItem();
            if (imageViewModel != null && imageViewModel is ImageViewModel)
            {
                workspace.Children.Remove(imageViewModel);
                workspace.SetImage(Filter.ApplyFilter(imageViewModel as ImageViewModel, ColorMatrixes.SepiaTone));
            }
        }
        private void GrayScaleFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageViewModel = workspace.SelectedItem();
            if (imageViewModel != null && imageViewModel is ImageViewModel)
            {
                workspace.Children.Remove(imageViewModel);
                workspace.SetImage(Filter.ApplyFilter(imageViewModel as ImageViewModel, ColorMatrixes.GrayScale));
            }
        }
        private void BlackAndWhiteFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageViewModel = workspace.SelectedItem();
            if (imageViewModel != null && imageViewModel is ImageViewModel)
            {
                workspace.Children.Remove(imageViewModel);
                workspace.SetImage(Filter.ApplyFilter(imageViewModel as ImageViewModel, ColorMatrixes.BlackAndWhite));
            }
        }

        private void NegativeFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageViewModel = workspace.SelectedItem();
            if (imageViewModel != null && imageViewModel is ImageViewModel)
            {
                workspace.Children.Remove(imageViewModel);
                workspace.SetImage(Filter.ApplyFilter(imageViewModel as ImageViewModel, ColorMatrixes.Negative));
            }
        }
        private void DefaultFilter_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ImageEditorItem imageViewModel = workspace.SelectedItem();
            if (imageViewModel != null && imageViewModel is ImageViewModel)
            {
                workspace.Children.Remove(imageViewModel);
                workspace.SetImage(Filter.ApplyFilter(imageViewModel as ImageViewModel, ColorMatrixes.Default));
            }
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.png, etc.) | *.jpg; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == true)
            {
                //ImageEditorItem photo = new ImageEditorItem(new Point(0,0));
                ImageViewModel imageViewModel = new ImageViewModel(new Point(0, 0), openFileDialog.FileName);
                _itemAlbum.Items.Add(imageViewModel);
                workspace.Children.Add(imageViewModel);
            }
        }

        private void AddText_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Trace.WriteLine("Text added");
            ImageEditorItem text = new ImageEditorItem(new Point(0, 0));
            _itemAlbum.Items.Add(text);
            workspace.Children.Add(new TextBoxViewModel(text));
        }

        private void DeleteItem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _itemAlbum.Items.Remove(workspace.SelectedItem());
            workspace.Children.Remove(workspace.SelectedItem());
        }

        #region CanvasScale handler
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
            var scaleDelta = e.Delta >= 0 ? 1.1 : (1.0 / 1.1);

            Scale.Text = Convert.ToInt32(Math.Round(transform.Matrix.M11, 4)*100)  + "%"; 
            matrix.ScaleAtPrepend(scaleDelta, scaleDelta, position.X, position.Y);
            transform.Matrix = matrix;
        }
        #endregion
    }
}
