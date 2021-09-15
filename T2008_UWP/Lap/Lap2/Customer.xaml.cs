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
       
        public Customer()
        {
            this.InitializeComponent();
        }
        private static List<Custom> cus = new List<Custom>();
        private void Home(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Home));
        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            if (inputName.Text == "" || inpuTel.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }else if (inputGender.Text == "" || inputAddres.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";

            }
            else
            {
                errors.Text = "";
                //  string txt = inputMail.Text + "--" + inputSubject.Text + "\n --------------------------------------";
                var m = new Custom() { Name = inputName.Text, Tel = inpuTel.Text, Gender = inputGender.Text,Address = inputAddres.Text };
                cus.Add(m);
                PrintMails();
                inputName.Text = "";
                inpuTel.Text = "";
                inputGender.Text = "";
                inputAddres.Text = "";
            }

        }

        private void PrintMails()
        {
            txtData.Text = "";
            foreach (Custom m in cus)
            {
                txtData.Text += m.Name + "--" + m.Tel + "--" + m.Gender +"--" + m.Address + "\n";
            }
        }

        private void inputGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = e.AddedItems[0].ToString();
            inputGender.Text = text;
        }
    }
}
