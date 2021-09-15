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
    public sealed partial class Contact : Page
    {
        public Contact()
        {
            this.InitializeComponent();
        }

        private static List<Contacts> cus = new List<Contacts>();
        private void Home(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Home));
        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            if (inputName.Text == "" || inpuEmail.Text == "")
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
                var m = new Contacts() { Name = inputName.Text, Email = inpuEmail.Text, Content = inputContent.Text };
                cus.Add(m);
                PrintMails();
                inputName.Text = "";
                inpuEmail.Text = "";
                inputContent.Text = "";
            }

        }

        private void PrintMails()
        {
            txtData.Text = "";
            foreach (Contacts m in cus)
            {
                txtData.Text += m.Name + "--" + m.Email + "--" + m.Content+ "\n";
            }
        }
    }
}
