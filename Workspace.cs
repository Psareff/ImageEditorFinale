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
using System.Windows.Shapes;

namespace ImageEditorFinale
{
    internal class Workspace : Canvas
    {
        private ImageEditorItem _elementBeingDragged;
        public MatrixTransform _matrixTransform;
        public Matrix _matrix;

        public ImageEditorItem ItemDragging { get; set; }
        private Point _startPoint;
        private Point _currentPoint;
        private bool _isMoving;

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


        public ImageEditorItem SelectedItem()
        {
            if (ItemDragging != null)
                return ItemDragging;
            return null;
        }

        public void SetImage(ImageViewModel imageViewModel)
        {
           // ImageViewModelDragging = imageViewModel;
            this.Children.Remove(ItemDragging);
            this.Children.Add(imageViewModel);
            Trace.WriteLine("Set image handled");
        }
        
        public void DeselectAll() => ItemDragging.Deselect();

        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonUp(e);
            if (ItemDragging != null)
            {
                ItemDragging.ReleaseMouseCapture();
            }
            this._isMoving = false;
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);
            this._isMoving = false;
            this._startPoint = e.GetPosition(this);

            this.ElementBeingDragged = null;

            this.ElementBeingDragged = this.FindChild(e.Source as DependencyObject) as ImageEditorItem;

            if (ItemDragging != null)
            {
                ItemDragging.Deselect();
            }
            if (ElementBeingDragged != null && ElementBeingDragged is ImageEditorItem)
            {
                ItemDragging = ElementBeingDragged;
                ItemDragging.Select();
                ItemDragging.CaptureMouse();
                this._isMoving = true;
            }

        }
        protected override void OnPreviewMouseMove(MouseEventArgs e)
        {
            base.OnPreviewMouseMove(e);

            if (_isMoving == true && e.LeftButton == MouseButtonState.Pressed)
            {
                    _currentPoint = e.GetPosition(this);
                if (ElementBeingDragged != null && ElementBeingDragged is ImageEditorItem)
                {
                    (ElementBeingDragged)._location.X += _currentPoint.X - _startPoint.X;
                    (ElementBeingDragged)._location.Y += _currentPoint.Y - _startPoint.Y;
                    Canvas.SetLeft(ElementBeingDragged, ElementBeingDragged._location.X);
                    Canvas.SetTop(ElementBeingDragged, ElementBeingDragged._location.Y);

                    _startPoint = _currentPoint;
                }

            }

        }


    }
}
