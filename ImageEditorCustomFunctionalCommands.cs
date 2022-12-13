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
    }
}
