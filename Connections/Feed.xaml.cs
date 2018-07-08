using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static Connections.App;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Connections
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Feed : Page
    {
        public List<Feed_Items> don_feed = new List<Feed_Items>();

        public List<Feed_Items> ahmed_feed = new List<Feed_Items>();

        public List<Feed_Items> james_feed = new List<Feed_Items>();


        public Feed()
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


    }

    public class Feed_Items
    {
        public Feed_Items(string posterName, string postContent, string postType)
        {
            Poster_Name = posterName.ToUpper();
            Post_Content = postContent;
            Post_Type = postType;

            if (Post_Type == "Meeting")
                Post_Type_Logo_path = "Assets/meeting_logo.png";

            if (Poster_Name == "Don Joe Martin")
                Poster_Photo = new BitmapImage(new Uri("ms-appx:///Assets/don_photo1.jpg", UriKind.Absolute));

            if (Poster_Name == "Ahmed Aboulcher")
                Poster_Photo = new BitmapImage(new Uri("ms-appx:///Assets/ahmed_photo.jpg", UriKind.Absolute));

            if (Poster_Name == "James Daou")
                Poster_Photo = new BitmapImage(new Uri("ms-appx:///Assets/james_photo1.jpg", UriKind.Absolute));

            if (Post_Type == "Status")
                Post_Type_Logo_path = "Assets/status_logo.png";

        }

        public string Poster_Name { get; set; }
        public ImageSource Poster_Photo { get; set; }
        public string Post_Content { get; set; }
        public string Post_Type { get; set; }
        public string Post_Type_Logo_path { get; set; }
    }
}
