using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Panels
{
    public sealed partial class ShapeElipse : Page
    {
        public ShapeElipse()
        {
            this.InitializeComponent();
            Rectangle rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Chocolate);
            rect.StrokeThickness = 10.0;
            (this.Content as Grid).Children.Add(rect);
            DoubleTapped += ShapeElipse_DoubleTapped;
        }

        void ShapeElipse_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StackPanel));
        }
    }
}
