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


namespace Panels
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DoubleTapped += MainPage_DoubleTapped  ;
        }

        private void MainPage_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ShapeElipse));
        }

        private void TxtBlck2_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Grid parentGrid = (e.OriginalSource as TextBlock).Parent as Grid;
            Border brd = new Border();
            brd.BorderBrush = new SolidColorBrush(Colors.Aquamarine);
            brd.BorderThickness = new Thickness(10, 10, 10, 10);
            brd.Background = new SolidColorBrush(Colors.Goldenrod);
            brd.VerticalAlignment = VerticalAlignment.Center;
            brd.HorizontalAlignment = HorizontalAlignment.Center;            
            brd.CornerRadius = new CornerRadius(15);

            parentGrid.Children.Remove(TxtBlck2); // It is necessary! 
            brd.Child = TxtBlck2;
            parentGrid.Children.Add(brd);
        }
    }
}
