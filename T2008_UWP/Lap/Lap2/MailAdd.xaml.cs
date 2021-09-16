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
    public sealed partial class MailAdd : Page
    {
        private static List<Mails> cus = new List<Mails>();
        public MailAdd()
        {
            this.InitializeComponent();
        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            if (inputEmail.Text == "" || inpuTitle.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }
            else if (inputContent.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";

            }
            else
            {
                errors.Text = "";
                //  string txt = inputMail.Text + "--" + inputSubject.Text + "\n --------------------------------------";
                var m = new Mails() { Email = inputEmail.Text, Title = inpuTitle.Text, Content = inputContent.Text };
                cus.Add(m);
                inpuTitle.Text = "";
                inputEmail.Text = "";
                inputContent.Text = "";
            }

        }

        public void Back(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Contact));
        }
    }
}
