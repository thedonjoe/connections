using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// 
    
    public sealed partial class Requests : Page
    {
        static public ObservableCollection<Request> don_requests { get; set; } = new ObservableCollection<Request>();
        static public ObservableCollection<Request> ahmed_requests { get; set; } = new ObservableCollection<Request>();
        static public ObservableCollection<Request> james_requests { get; set; } = new ObservableCollection<Request>();

        
        public Requests() 
        {
            this.InitializeComponent();

            don_requests.Add(new Request("Jared Dunn", "Don Joe Martin", "Connection Request", "Could we please connect?"));

            if (Globals.PERSON == 1)
                RequestsView.ItemsSource = don_requests;

            else if (Globals.PERSON == 2)
                RequestsView.ItemsSource = ahmed_requests;

            else if (Globals.PERSON == 3)
                RequestsView.ItemsSource = james_requests;

            

        }

        private void Meeting_Create_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.PERSON == 1)
            {
                RequestingPerson.Text = "Don Joe Martin";
                Requesting.Items.Remove(Don_ListBox);
                IntroduceTo.Items.Remove(ConnectWithDon_ListBox);
            }

            else if (Globals.PERSON == 2)
            {
                RequestingPerson.Text = "Ahmed Aboulcher";
                Requesting.Items.Remove(Ahmed_ListBox);
                IntroduceTo.Items.Remove(ConnectWithAhmed_ListBox);
            }

            else
            {
                RequestingPerson.Text = "James Daou";
                Requesting.Items.Remove(James_ListBox);
                IntroduceTo.Items.Remove(ConnectWithJames_ListBox);
            }

                RequestingPerson.Visibility = Visibility.Visible;
                Requesting.Visibility = Visibility.Visible;
                RequestType.Visibility = Visibility.Visible;
                //IntroduceTo.Visibility = Visibility.Visible;
                Request_Message.Visibility = Visibility.Visible;
                SubmitButton.Visibility = Visibility.Visible;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            RequestingPerson.Visibility = Visibility.Collapsed;
            Requesting.Visibility = Visibility.Collapsed;
            RequestType.Visibility = Visibility.Collapsed;
            IntroduceTo.Visibility = Visibility.Collapsed;
            Request_Message.Visibility = Visibility.Collapsed;
            SubmitButton.Visibility = Visibility.Collapsed;


            Request req = new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text);

            

            if (Globals.PERSON == 1 || ((ListBoxItem)Requesting.SelectedItem).Content.ToString() =="Don Joe Martin")
                don_requests.Add(new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text));

            if (Globals.PERSON == 2 || ((ListBoxItem)Requesting.SelectedItem).Content.ToString() == "Ahmed Aboulcher")
                ahmed_requests.Add(new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text));

            if (Globals.PERSON == 3 || ((ListBoxItem)Requesting.SelectedItem).Content.ToString() == "James Daou")
                james_requests.Add(new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text));

            if (Globals.PERSON == 1)
            {
                Requesting.Items.Add(Don_ListBox);
                IntroduceTo.Items.Add(ConnectWithDon_ListBox);
            }
            else if (Globals.PERSON == 2)
            {
                Requesting.Items.Add(Ahmed_ListBox);
                IntroduceTo.Items.Add(ConnectWithAhmed_ListBox);
            }
            else if (Globals.PERSON == 3)
            {
                Requesting.Items.Add(James_ListBox);
                IntroduceTo.Items.Add(ConnectWithJames_ListBox);
            }

            if (Globals.PERSON == 1)
                RequestsView.ItemsSource = don_requests;

            else if (Globals.PERSON == 2)
                RequestsView.ItemsSource = ahmed_requests;

            else if (Globals.PERSON == 3)
                RequestsView.ItemsSource = james_requests;

            

            
        }

        private void RequestType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if( ((ListBoxItem)RequestType.SelectedItem).Content.ToString() == "Introduction")
                IntroduceTo.Visibility = Visibility.Visible;

            else
                IntroduceTo.Visibility = Visibility.Collapsed;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        private void RequestsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Globals.selectedReq = RequestsView.SelectedItem as Request;
            this.Frame.Navigate(typeof(RequestDetails));
        }
    }

    public class Request 
    {
        public Request(string requester, string receiver, string request_type, string request_text)
        {
            Requester = requester;
            Receiver = receiver;
            Request_Type = request_type;
            Request_Text = request_text;
        }

        public string Requester { get; set; }

        public string Receiver { get; set; }

        //public DateTime Requested_Date { get; set; }

        //public Image Requester_Image { get; set; }

        public string Request_Type { get; set; }

        //public Image Request_Type_Logo { get; set; }

        public string Request_Text { get; set; }
    }
}
