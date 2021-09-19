using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T2008_UWP.Lap.Lap2.Modal;
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
    public sealed partial class Mail : Page
    {
        List<Mails> _data { get; set; } = new List<Mails>();

        public Mail()
        {
            this.InitializeComponent();
            if (_data.Count == 0)
            {
                var a = new Mails() { Title = "BCT", Email = "BCT@gmail.com", Content = "Test1" };
                var b = new Mails() { Title = "HAT", Email = "HAT@gmail.com", Content = "Tse2" };
                var c = new Mails() { Title = "TDQ", Email = "TDQ@gmail.com", Content = "Ttse3" };
                _data.Add(a);
                _data.Add(b);
                _data.Add(c);
            }
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Home));
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(MailAdd));
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            if (Menu.Items != null)
                foreach (Mails item in _data)
                {
                    Menu.Items.Add(item);
                }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Mails item = e.Parameter as Mails;
            if (item != null)
                _data.Add(item);

        }
    }
}
