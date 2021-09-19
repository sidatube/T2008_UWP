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
        static List<Contacts> Data { set; get; } = new List<Contacts>();
        public Contact()
        {
            this.InitializeComponent();
            if (Data.Count == 0)
            {
                var a = new Contacts() { Name = "BCT", Email = "BCT@gmail.com", Content = "Test1" };
                var b = new Contacts() { Name = "HAT", Email = "HAT@gmail.com", Content = "Tse2" };
                var c = new Contacts() { Name = "TDQ", Email = "TDQ@gmail.com", Content = "Ttse3" };
                Data.Add(a);
                Data.Add(b);
                Data.Add(c);

            }
        }
        public Contact(string Name, string Email, string Content) : this()
        {
            Menu.Items.Add(new Contacts() { Name = Name, Email = Email, Content = Content });

        }
        public void Home(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Home));
        }
        public void Add(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(ContactAdd));
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

                Data.Add(new Contacts() { Name = inputName.Text, Email = inpuEmail.Text, Content = inputContent.Text });

                inputName.Text = "";
                inpuEmail.Text = "";
                inputContent.Text = "";


            }

        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {

            if (Menu.Items != null)
                foreach (Contacts item in Data)
                {
                    Menu.Items.Add(item);
                }

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Contacts item = e.Parameter as Contacts;
            if (item != null)
                Data.Add(item);
        }
    }
}
