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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008_UWP.Lap.Lap2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LapMain : Page
    {
        public static Frame _frame;
        public LapMain()
        {
            this.InitializeComponent();
            _frame = Frame;
        }
        private void click_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "Home" };
            var item2 = new MenuItem() { Name = "Contact", MenuPage = "Contact" };
            var item3 = new MenuItem() { Name = "Customer", MenuPage = "Customer" };
            var item4 = new MenuItem() { Name = "Mail", MenuPage = "Mail" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {

                case "Contact": Frame.Navigate(typeof(Lap2.Contact)); break;
                case "Home": Frame.Navigate(typeof(Lap2.Home)); break;
                case "Customer": Frame.Navigate(typeof(Lap2.Customer)); break;
                case "Mail": Frame.Navigate(typeof(Lap2.Mail)); break;
            }
        }
    }
}
