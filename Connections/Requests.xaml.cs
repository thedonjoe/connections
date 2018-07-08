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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static Connections.App;
using static Connections.MainPage;

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

            if (Globals.requests_flag == 0)
            {
                don_requests.Add(new Request("Jared Dunn", "Don Joe Martin", "Connection Request", "Could we please connect?"));
                Globals.requests_flag = 1;

                if (Globals.selectedResp != null)
                {
                    if (Globals.selectedResp.Receiver == "Don Joe Martin")
                        don_requests.Add(Globals.selectedResp);

                    else if (Globals.selectedResp.Receiver == "Ahmed Aboulcher")
                        ahmed_requests.Add(Globals.selectedResp);

                    else if (Globals.selectedResp.Receiver == "James Daou")
                        james_requests.Add(Globals.selectedResp);

                    Globals.selectedResp = null;
                }
            }

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
                Requesting.Items.Remove(James_ListBox);
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
                Requesting.Items.Remove(Don_ListBox);
                IntroduceTo.Items.Remove(ConnectWithJames_ListBox);
            }

            IntroduceTo_Grid.Visibility = Visibility.Visible;
            RequestingPerson_Grid.Visibility = Visibility.Visible;
            Requesting_Grid.Visibility = Visibility.Visible;
            RequestType_Grid.Visibility = Visibility.Visible;
            Request_Message_Grid.Visibility = Visibility.Visible;
            SubmitButton.Visibility = Visibility.Visible;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            IntroduceTo_Grid.Visibility = Visibility.Collapsed;
            RequestingPerson_Grid.Visibility = Visibility.Collapsed;
            Requesting_Grid.Visibility = Visibility.Collapsed;
            RequestType_Grid.Visibility = Visibility.Collapsed;
            Request_Message_Grid.Visibility = Visibility.Collapsed;
            SubmitButton.Visibility = Visibility.Collapsed;


            Request req = new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text);

            

            if (Globals.PERSON == 1 || (ListBoxItem)Requesting.SelectedItem == Don_ListBox)
                don_requests.Add(new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text));

            if (Globals.PERSON == 2 || (ListBoxItem)Requesting.SelectedItem == Ahmed_ListBox)
                ahmed_requests.Add(new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text));

            if (Globals.PERSON == 3 || (ListBoxItem)Requesting.SelectedItem == James_ListBox)
                james_requests.Add(new Request(RequestingPerson.Text, ((ListBoxItem)Requesting.SelectedItem).Content.ToString(), ((ListBoxItem)RequestType.SelectedItem).Content.ToString(), Request_Message.Text));

            if (Globals.PERSON == 1)
            {
                Requesting.Items.Add(Don_ListBox);
                Requesting.Items.Add(James_ListBox);
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
                Requesting.Items.Add(Don_ListBox);
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
            if ((ListBoxItem)RequestType.SelectedItem == Introduction)
            {
                IntroduceTo.Visibility = Visibility.Visible;
                if (Globals.PERSON == 1)
                    IntroduceTo.Items.Remove(ConnectWithJames_ListBox);

                else if (Globals.PERSON == 3)
                    IntroduceTo.Items.Remove(ConnectWithDon_ListBox);
            }

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

        private void RequestsView_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
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

            if (Requester == "Don Joe Martin")
                Requester_Image = new BitmapImage(new Uri("ms-appx:///Assets/don_photo1.jpg", UriKind.Absolute));

            else if (Requester == "Ahmed Aboulcher")
                Requester_Image = new BitmapImage(new Uri("ms-appx:///Assets/ahmed_photo.jpg", UriKind.Absolute));

            else if (Requester == "James Daou")
               Requester_Image = new BitmapImage(new Uri("ms-appx:///Assets/james_photo.jpg", UriKind.Absolute));


        }

        public string Requester { get; set; }

        public string Receiver { get; set; }

        //public DateTime Requested_Date { get; set; }

        public ImageSource Requester_Image { get; set; }

        public string Request_Type { get; set; }

        //public Image Request_Type_Logo { get; set; }

        public string Request_Text { get; set; }
    }
}
