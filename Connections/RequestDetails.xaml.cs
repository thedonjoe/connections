using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class RequestDetails : Page
    {
        public static ObservableCollection<Request> selectedRequest { get; set; } = new ObservableCollection<Request>();
        public static ObservableCollection<Request> selectedResponse { get; set; } = new ObservableCollection<Request>();
        public static string selectedIdea;

        public static string response;
        public RequestDetails()
        {
            this.InitializeComponent();

            selectedRequest.Add(Globals.selectedReq);

            Request_Details.ItemsSource = selectedRequest;

            
        }



        private async void RequestAcceptButton_Click(object sender, RoutedEventArgs e)
        {
            if(selectedIdea == null)
            {
                selectedIdea = Response_Message_Content.Text;
            }
            await showMessageAsync(selectedIdea);

            
            string person = null;

            if (Globals.PERSON == 1)
                person = "Don Joe Martin";

            else if (Globals.PERSON == 2)
                person = "Ahmed Aboulcher";

            else if (Globals.PERSON == 3)
                person = "James Daou";

            selectedResponse.Add(new Request(person, Globals.selectedReq.Requester , "Response", response));

            Globals.selectedResp = selectedResponse.Single();

            this.Frame.Navigate(typeof(Feed));
        }

        public async System.Threading.Tasks.Task showMessageAsync(string s)
        {
            response = s;

            var messageDialog = new MessageDialog("Just to confirm, the following is your selected response: " + s);

            

            messageDialog.Commands.Add(new UICommand(
                "Yes",
                new UICommandInvokedHandler(this.YesCommandInvokedHandler)));

            messageDialog.Commands.Add(new UICommand(
                "No",
                 new UICommandInvokedHandler(this.NoCommandInvokedHandler)));

            messageDialog.CancelCommandIndex = 1;

            await messageDialog.ShowAsync();
        }

        private void YesCommandInvokedHandler(IUICommand command)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void NoCommandInvokedHandler(IUICommand command)
        {

        }



        private void RequestDetailsGrid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Request_Ideas.Visibility = Visibility.Visible;
        }

        private void Idea1_Tapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlipViewItem t = sender as FlipViewItem;
            TextBlock a = t.Content as TextBlock;


            selectedIdea = a.Text;
        }

        private void Idea2_Tapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            FlipViewItem t = sender as FlipViewItem;
            TextBlock a = t.Content as TextBlock;


            selectedIdea = a.Text;
        }
    }
}
