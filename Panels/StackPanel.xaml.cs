using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Panels
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StackPanel : Page
    {
        public StackPanel()
        {
            this.InitializeComponent();
        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            foreach (TextBlock txtBlck in HorizontalPanel.Children)
            {
                txtBlck.FontSize = 20;
            }
            HorizontalPanel.Orientation = Orientation.Horizontal;
        }
    }
}
