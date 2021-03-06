﻿using System;
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
using static Connections.App;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Connections
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();

        }

        private void Username_LoginForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Username_LoginForm.SelectedItem == Don_LoginComboBox)
                Globals.PERSON = 1;

            if (Username_LoginForm.SelectedItem == Ahmed_LoginComboBox)
                Globals.PERSON = 2;

            if (Username_LoginForm.SelectedItem == Ahmed_LoginComboBox)
                Globals.PERSON = 3;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
