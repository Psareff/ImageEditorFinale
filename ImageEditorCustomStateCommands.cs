using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageEditorFinale
{
    public static class ImageEditorCustomStateCommands
    {
        #region FileCommands

        public static readonly RoutedUICommand SaveFile = new RoutedUICommand(
            "SaveFile",
            "SaveFile",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.S , ModifierKeys.Control)
            });

        public static readonly RoutedUICommand OpenFile = new RoutedUICommand(
            "OpenFile",
            "OpenFile",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.O , ModifierKeys.Control)
            });
        #endregion

        #region EditCommands
        public static readonly RoutedUICommand CropImage = new RoutedUICommand(
            "CropImage",
            "CropImage",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.X , ModifierKeys.Control)
            });
        public static readonly RoutedUICommand RotateImage = new RoutedUICommand(
            "RotateImage",
            "RotateImage",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.R , ModifierKeys.Control)
            });
        public static readonly RoutedUICommand ResizeImage = new RoutedUICommand(
            "ResizeImage",
            "ResizeImage",
            typeof(ImageEditorCustomStateCommands)
            );
        public static readonly RoutedUICommand ResizeCanvas = new RoutedUICommand(
            "ResizeCanvas",
            "ResizeCanvas",
            typeof(ImageEditorCustomStateCommands)
            );
        #endregion

        #region FilterCommands
        public static readonly RoutedUICommand SepiaFilter = new RoutedUICommand(
            "SepiaFilter",
            "SepiaFilter",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.D1, ModifierKeys.Control)
            });
        public static readonly RoutedUICommand GrayScaleFilter = new RoutedUICommand(
            "GrayScaleFilter",
            "GrayScaleFilter",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.D2 , ModifierKeys.Control)
            });
        public static readonly RoutedUICommand BlackandWhiteFilter = new RoutedUICommand(
            "BlackandWhiteFilter",
            "BlackandWhiteFilter",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.D3 , ModifierKeys.Control)
            });
        #endregion

        #region AboutCommands
        public static readonly RoutedUICommand AboutMenu = new RoutedUICommand(
            "AboutMenu",
            "AboutMenu",
            typeof(ImageEditorCustomStateCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.OemQuestion , ModifierKeys.Control)
            });
        public static readonly RoutedUICommand Copyright = new RoutedUICommand(
            "Copyright",
            "Copyright",
            typeof(ImageEditorCustomStateCommands)
            );
        #endregion
    }
}
