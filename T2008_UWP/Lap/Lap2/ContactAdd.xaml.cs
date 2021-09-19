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
    public sealed partial class ContactAdd : Page
    {

        public ContactAdd()
        {
            this.InitializeComponent();
            
        }
        public void Back(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Contact));
        }

        public void Submit(object sender, RoutedEventArgs e)
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
                string Name = inputName.Text;
                string Email= inpuEmail.Text;
                string Content= inputContent.Text;
                var a = new Contacts() { Name = Name, Email = Email, Content = Content };

                inputName.Text = "";
                inpuEmail.Text = "";
                inputContent.Text = "";
              
                LapMain._frame.Navigate(typeof(Contact),a);
            }

        }
        

    }
}
