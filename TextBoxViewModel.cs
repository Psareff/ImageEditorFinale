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
    internal class TextBoxViewModel : ImageEditorItem
    {
        private TextBlock _textBlock;

        private ImageEditorItem _imageEditorItem;


        public TextBoxViewModel(ImageEditorItem imageEditorItem)
        {
            _imageEditorItem = imageEditorItem;
            _textBlock = new TextBlock();
            _textBlock.Text = "Enter your text here";
            _textBlock.FontSize = 28;
            _textBlock.Foreground = Brushes.Black;
            Child = _textBlock;
            Canvas.SetLeft(this, _imageEditorItem._location.X);
            Canvas.SetTop(this, _imageEditorItem._location.Y);
        }

        public void ChangeText(string newText)
        {
            this._textBlock.Text = newText;
        }
    }
}
