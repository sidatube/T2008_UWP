using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T2008_UWP.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2008_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public static Frame _mainFrame;
        public MainPage()
        {
            _mainFrame = MainFrame;
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Lap1.Lap1));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void HomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));

        }
        private void PersonInfor(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.PersonInformation));

        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;

        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "Home" };
            var item2 = new MenuItem() { Name = "Person Infor", MenuPage = "pi" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selecteditem = (MenuItem)Menu.SelectedItem;
            switch (selecteditem.MenuPage)
            {
                case "Home": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "pi": MainFrame.Navigate(typeof(Pages.PersonInformation)); break;
            }
        }
    }
}
