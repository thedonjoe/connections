using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static Connections.App;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Connections
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {


        
        public MainPage()
        {
            this.InitializeComponent();

            if(Globals.PERSON == 1)
            {
               // string url = "ms-appx:///Assets/don_photo1.jpg";
               ProPicture.ProfilePicture = new BitmapImage(new Uri("ms-appx:///Assets/don_photo1.jpg", UriKind.Absolute));
                ProName.Text = "Don Joe Martin";
                //ProfileDetails.Height = ProPicture.Height;
            }

            else if(Globals.PERSON == 2)
            {
                ProPicture.ProfilePicture = new BitmapImage(new Uri("ms-appx:///Assets/ahmed_photo.jpg", UriKind.Absolute));
                ProName.Text = "Ahmed Aboulcher";
            }

            else if(Globals.PERSON == 3)
            {
                ProPicture.ProfilePicture = new BitmapImage(new Uri("ms-appx:///Assets/james_photo.jpg", UriKind.Absolute));
                ProName.Text = "James Daou";
            }

        }

        #region NavigationView event handlers
        private void nvTopLevelNav_Loaded(object sender, RoutedEventArgs e)
        {
            
            // set the initial SelectedItem
            foreach (NavigationViewItemBase item in nvTopLevelNav.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "Feed")
                {
                    nvTopLevelNav.SelectedItem = item;
                    break;
                }
            }
            myFrame.Navigate(typeof(Feed));

            
        }

        private void nvTopLevelNav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
        }

        private async void nvTopLevelNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

            Grid gridcontent = args.InvokedItem as Grid;
            if(gridcontent!=null)
            {
                if (gridcontent.Tag.ToString() == "Profile_Details_Grid")
                {
                    myFrame.Navigate(typeof(Profile));
                }
            }

            TextBlock ItemContent = args.InvokedItem as TextBlock;
            if (ItemContent != null)
            {
                switch (ItemContent.Tag)
                {
                    case "Nav_Feed":
                        myFrame.Navigate(typeof(Feed));
                        break;

                    case "Nav_Requests":
                        myFrame.Navigate(typeof(Requests));
                        break;

                    case "Nav_Meetings":
                        myFrame.Navigate(typeof(MeetingDetails));
                        break;

                    case "Nav_LogOut":
                        await showMessageAsync();
                        Globals.requests_flag = 0;
                        break;
                }
            }

        }
        #endregion

        public async System.Threading.Tasks.Task showMessageAsync()
        {
            var messageDialog = new MessageDialog("Just to confirm: You want to log out?");

           

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
            this.Frame.Navigate(typeof(Login));
        }
        private void NoCommandInvokedHandler(IUICommand command)
        {
            
        }

    }
    
}
