﻿using System;
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
        static List<Contacts> _data  = new List<Contacts>();
        List<Contacts> Data { get; set; }
        public Contact()
        {
            this.InitializeComponent();
            loadData();
            Data = _data;
        }
        public Contact(string Name,string Email,string Content) : this()
        {
            _data.Add(new Contacts() { Name = Name, Email = Email, Content = Content });

        }
        public void loadData()
        {
            if (_data.Count == 0)
            {
                var a = new Contacts() { Name = "BCT", Email = "BCT@gmail.com", Content = "Test1" };
                var b = new Contacts() { Name = "HAT", Email = "HAT@gmail.com", Content = "Tse2" };
                var c = new Contacts() { Name = "TDQ", Email = "TDQ@gmail.com", Content = "Ttse3" };
                _data.Add(a);
                _data.Add(b);
                _data.Add(c);
            }
            else
            {
                Data = _data;
            }
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
               
                _data.Add(new Contacts() { Name = inputName.Text, Email = inpuEmail.Text, Content = inputContent.Text });

                inputName.Text = "";
                inpuEmail.Text = "";
                inputContent.Text = "";
                Data = _data;
                
            }

        }

    }
}
