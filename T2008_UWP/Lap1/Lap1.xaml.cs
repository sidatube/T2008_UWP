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

namespace T2008_UWP.Lap1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lap1 : Page
    {
        private List<Email> mails = new List<Email>();
        public Lap1()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputMail.Text == "" || inputTitle.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }
            else
            {
                errors.Text = "";
                //  string txt = inputMail.Text + "--" + inputSubject.Text + "\n --------------------------------------";
                var m = new Email() { Mail = inputMail.Text, Title = inputTitle.Text, Content = inputContent.Text };
                mails.Add(m);
                PrintMails();
                inputMail.Text = "";
                inputTitle.Text = "";
                inputContent.Text = "";
            }

        }

        private void PrintMails()
        {
            txtData.Text = "";
            foreach (Email m in mails)
            {
                txtData.Text += m.Mail + "--" + m.Title + "--" + m.Content + "\n";
            }
        }
    }
}
