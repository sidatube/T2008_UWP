using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace T2008_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonInformation : Page
    {
        public PersonInformation()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtTitle.Text = "Đây là thông tin sau submit!";
            string name = inputName.Text;
            string tel = inputPhone.Text;
            string id = inputCMND.Text;
            string address = inputAddress.Text;
            txtName.Text = name;
            txtPhone.Text = tel;
            txtCMND.Text = id;
            txtAddress.Text = address;

        }
    }
}
