using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Connections
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    

    public sealed partial class MainPage : Page
    {
        public List<Feed_Items> don_feed = new List<Feed_Items>();

        public List<Feed_Items> ahmed_feed = new List<Feed_Items>();

        public List<Feed_Items> james_feed = new List<Feed_Items>();

        
        public MainPage()
        {
            this.InitializeComponent();


            //IEnumerable<PropertyInfo> propertyInfos = typeof(Feed).GetRuntimeProperties();
            don_feed.Add(new Feed_Items("Ahmed Aboulcher", "Great meeting you @Jame_Daou", "Meeting"));
            don_feed.Add(new Feed_Items("Don Joe Martin", "Coffee breaks and loud drives - Chicken Soup for the Soul @Ahmed_Aboulcher", "Meeting"));
            don_feed.Add(new Feed_Items("Ahmed Aboulcher", "Need some petrol, gotta go to Fujairah", "Status"));

            ahmed_feed.Add(new Feed_Items("Don Joe Martin", "Good Coffee", "Status"));
            ahmed_feed.Add(new Feed_Items("James Daou", "BRAZIL FOR THE WIN", "Status"));
            ahmed_feed.Add(new Feed_Items("Don Joe Martin", "Coffee breaks and loud drives - Chicken Soup for the Soul @Ahmed_Aboulcher", "Meeting"));

            james_feed.Add(new Feed_Items("Ahmed Aboulcher", "Need some petrol, gotta go to Fujairah", "Status"));
            james_feed.Add(new Feed_Items("Don Joe Martin", "Coffee breaks and loud drives - Chicken Soup for the Soul @Ahmed_Aboulcher", "Meeting"));

            if (Globals.PERSON == 1)
                FeedView.ItemsSource = don_feed;

            else if (Globals.PERSON == 2)
                FeedView.ItemsSource = ahmed_feed;

            else
                FeedView.ItemsSource = james_feed;
        }

        private void GotoProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Profile));
        }
    }
    public class Feed_Items
    {
        public Feed_Items(string posterName, string postContent, string postType)
        {
            Poster_Name = posterName;
            Post_Content = postContent;
            Post_Type = postType;
        }

        public string Poster_Name { get; set; }
        public string Post_Content { get; set; }
        public string Post_Type { get; set; }

    }
}
