using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using T2008_UWP.Lap.Lap2.Modal;
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
    public sealed partial class Customer : Page
    {
        List<Custom> _data { get; set; } = new List<Custom>();

        public Customer()
        {
            this.InitializeComponent();
            if (_data.Count == 0)
            {
                var a = new Custom() { Name = "BCT", Tel = "123125546", Address = "Address 1", Gender = "Male" };
                var b = new Custom() { Name = "HAT", Tel = "123125543", Address = "Address 2", Gender = "Female" };
                var c = new Custom() { Name = "TDQ", Tel = "123125575", Address = "Address 3", Gender = "Female" };
                _data.Add(a);
                _data.Add(b);
                _data.Add(c);
            }
        }
        private static List<Custom> cus = new List<Custom>();
        private void Home(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Home));
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(CustomerAdd));
        }

     

        

        
    }
}
