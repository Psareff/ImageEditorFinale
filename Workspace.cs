using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Diagnostics;

namespace ImageEditorFinale
{
    internal class Workspace : Canvas
    {
        private ImageEditorItem _elementBeingDragged;
        public MatrixTransform _matrixTransform;
        public Matrix _matrix;

        public Workspace()
        {
            _matrixTransform = (MatrixTransform)this.RenderTransform;
            _matrix = _matrixTransform.Matrix;
        }

        public ImageEditorItem ElementBeingDragged
        {
            get => _elementBeingDragged;
            set
            {
                if (value != _elementBeingDragged)  
                    _elementBeingDragged = value;
            }
        }

        public ImageEditorItem ImageViewModelDragging { get; set; }
        private Point _startPoint;
        private Point _currentPoint;
        private bool _isMoving;

        public UIElement FindChild(DependencyObject dependencyObject)
        {
            while (dependencyObject != null)
            {
                UIElement element = dependencyObject as UIElement;
                if (element != null && base.Children.Contains(element))
                    break;
                if (element is Visual || element is Visual3D)
                    dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
                else
                    dependencyObject = LogicalTreeHelper.GetParent(dependencyObject);
            }
            return dependencyObject as UIElement;
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);
            this._isMoving = false;
            this._startPoint = e.GetPosition(this);

            this.ElementBeingDragged = null;
            //this.PhotoViewDragging = null;

            this.ElementBeingDragged = this.FindChild(e.Source as DependencyObject) as ImageEditorItem;

            if (ImageViewModelDragging != null)
                ImageViewModelDragging.Deselect();
            if (ElementBeingDragged != null && ElementBeingDragged is ImageEditorItem)
            {
                ImageViewModelDragging = ElementBeingDragged;
                ImageViewModelDragging.Select();
                ImageViewModelDragging.CaptureMouse();
                this._isMoving = true;

            }
        }

        public ImageEditorItem SelectedItem()
        {
            if (ImageViewModelDragging != null)
                return ImageViewModelDragging;
            return null;
        }
        
        public void DeselectAll() => ImageViewModelDragging.Deselect();

        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonUp(e);
            if (ImageViewModelDragging != null)
            {
                ImageViewModelDragging.ReleaseMouseCapture();
            }
            this._isMoving = false;
        }

        protected override void OnPreviewMouseMove(MouseEventArgs e)
        {
            base.OnPreviewMouseMove(e);

            if (_isMoving == true && e.LeftButton == MouseButtonState.Pressed)
            {
                _currentPoint = e.GetPosition(this);
                ((ImageEditorItem)ElementBeingDragged)._location.X += _currentPoint.X - _startPoint.X;
                ((ImageEditorItem)ElementBeingDragged)._location.Y += _currentPoint.Y - _startPoint.Y;
                Canvas.SetLeft(ElementBeingDragged, ((ImageEditorItem)ElementBeingDragged)._location.X);
                Canvas.SetTop(ElementBeingDragged, ((ImageEditorItem)ElementBeingDragged)._location.Y);

                _startPoint = _currentPoint;
            }
        }

    }
}
