using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageEditorFinale
{
    public static class ImageEditorCustomFunctionalCommands
    {
        public static readonly RoutedUICommand ChangeHue = new RoutedUICommand(
            "ChangeHue",
            "ChangeHue",
            typeof(ImageEditorCustomStateCommands)
            );
        public static readonly RoutedUICommand CanvasDefaultScale = new RoutedUICommand(
            "CanvasDefaultScale",
            "CanvasDefaultScale",
            typeof(ImageEditorCustomStateCommands)
            );
        public static readonly RoutedUICommand AddImage = new RoutedUICommand(
           "AddImage",
           "AddImage",
           typeof(ImageEditorCustomStateCommands),
           new InputGestureCollection()
               {
                new KeyGesture(Key.A , ModifierKeys.Control)
               }
           );
        public static readonly RoutedUICommand DeleteItem = new RoutedUICommand(
           "DeleteItem",
           "DeleteItem",
           typeof(ImageEditorCustomStateCommands),
           new InputGestureCollection()
               {
                new KeyGesture(Key.X , ModifierKeys.Control)
               }
           );
        public static readonly RoutedUICommand RotateItem = new RoutedUICommand(
           "RotateItem",
           "RotateItem",
           typeof(ImageEditorCustomStateCommands),
           new InputGestureCollection()
               {
                new KeyGesture(Key.R , ModifierKeys.Control)
               }
           );
        public static readonly RoutedUICommand AddText = new RoutedUICommand(
               "AddText",
               "AddText",
               typeof(ImageEditorCustomStateCommands)
            );
        public static readonly RoutedUICommand ChangeText = new RoutedUICommand(
                "ChangeText",
                "ChangeText",
                typeof(ImageEditorCustomStateCommands)
            );
    }
}
