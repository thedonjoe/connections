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
    public sealed partial class Profile : Page
    {
        public List<Profile_View> don = new List<Profile_View>();
        public List<Profile_View> ahmed = new List<Profile_View>();
        public List<Profile_View> james = new List<Profile_View>();
        public Profile()
        {
            this.InitializeComponent();

            //Profile_View don= new Profile_View("Don Joe Martin", "Dubai, UAE", 234, "Harry Potter", "Racing", "Food", "Software Development", "Photography", "Writing");
            don.Add(new Profile_View("Don Joe Martin", "Dubai, UAE", 234, "Harry Potter", "Racing", "Food", "Software Development", "Photography", "Writing"));
            //Profile_View ahmed = new Profile_View("Ahmed Aboulcher", "Dubai, UAE", 343, "Porsche", "Traveling", "Movies", "Management", "Public Speaking", "Innovation");
            ahmed.Add(new Profile_View("Ahmed Aboulcher", "Dubai, UAE", 343, "Porsche", "Traveling", "Deadpool", "Management", "Public Speaking", "Innovation"));
            //Profile_View james = new Profile_View("James Daou", "Dubai, UAE", 275, "Football", "Titanic", "Cars", "Front End Development", "Server Architecture", "Computer Engineering");
            james.Add(new Profile_View("James Daou", "Dubai, UAE", 275, "Football", "Titanic", "Cars", "Front End Development", "Server Architecture", "Computer Engineering"));


            if (Globals.PERSON == 1)
                ProfView.ItemsSource = don;
            else if (Globals.PERSON == 2)
                ProfView.ItemsSource = ahmed;
            else if(Globals.PERSON==3)
                ProfView.ItemsSource = james;

        }

        private void Meetings_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MeetingDetails));
        }

        private void GoToRequests_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Requests));
        }
    }

    public class Profile_View
    {
        public Profile_View(string name, string location, int friends_count, string likes1, string likes2, string likes3, string skills1, string skills2, string skills3)
        {
            Name = name;

            if (Globals.PERSON == 1)
                Profile_Picture = new BitmapImage(new Uri("ms-appx:///Assets/don_photo1.jpg", UriKind.Absolute));

            else if (Globals.PERSON == 2)
                Profile_Picture = new BitmapImage(new Uri("ms-appx:///Assets/ahmed_photo.jpg", UriKind.Absolute));

            else if (Globals.PERSON == 3)
                Profile_Picture = new BitmapImage(new Uri("ms-appx:///Assets/james_photo.jpg", UriKind.Absolute));

            Location = location;
            Friends_Count = friends_count;
            Likes1 = likes1;

            if(Likes1 == "Harry Potter")
                Likes1_logo = new BitmapImage(new Uri("ms-appx:///Assets/harry_potter.jpg", UriKind.Absolute));
            else if(Likes1 == "Porsche")
                Likes1_logo = new BitmapImage(new Uri("ms-appx:///Assets/porsche.jpg", UriKind.Absolute));
            else if(Likes1 == "Football")
                Likes1_logo = new BitmapImage(new Uri("ms-appx:///Assets/football.jpg", UriKind.Absolute));

            Likes2 = likes2;

            if(Likes2 == "Racing")
                Likes2_logo = new BitmapImage(new Uri("ms-appx:///Assets/car_racing.jpg", UriKind.Absolute));
            else if(Likes2 == "Traveling")
                Likes2_logo = new BitmapImage(new Uri("ms-appx:///Assets/traveling.jpg", UriKind.Absolute));
            else if (Likes2 == "Titanic")
                Likes2_logo = new BitmapImage(new Uri("ms-appx:///Assets/titanic_movie_poster.jpg", UriKind.Absolute));

            Likes3 = likes3;

            if(Likes3=="Food")
                Likes3_logo = new BitmapImage(new Uri("ms-appx:///Assets/food.jpg", UriKind.Absolute));
            else if(Likes3 == "Deadpool")
                Likes3_logo = new BitmapImage(new Uri("ms-appx:///Assets/deadpool.jpg", UriKind.Absolute));
            else if(Likes3 == "Cars")
                Likes3_logo = new BitmapImage(new Uri("ms-appx:///Assets/cars.jpg", UriKind.Absolute));

            Skills1 = skills1;

            if(Skills1=="Software Development")
                Skills1_logo = new BitmapImage(new Uri("ms-appx:///Assets/software_development.png", UriKind.Absolute));
            else if(Skills1=="Management")
                Skills1_logo = new BitmapImage(new Uri("ms-appx:///Assets/management.png", UriKind.Absolute));
            else if(Skills1 == "Front End Development")
                Skills1_logo = new BitmapImage(new Uri("ms-appx:///Assets/front_end.png", UriKind.Absolute));

            Skills2 = skills2;

            if(Skills2 == "Photography")
                Skills2_logo = new BitmapImage(new Uri("ms-appx:///Assets/photo.png", UriKind.Absolute));
            else if(Skills2 == "Public Speaking")
                Skills2_logo = new BitmapImage(new Uri("ms-appx:///Assets/public_speaking.png", UriKind.Absolute));
            else if(Skills2 == "Server Architecture")
                Skills2_logo = new BitmapImage(new Uri("ms-appx:///Assets/server_architecture.png", UriKind.Absolute));

            Skills3 = skills3;

            if(Skills3 == "Writing")
                Skills3_logo = new BitmapImage(new Uri("ms-appx:///Assets/blogging.png", UriKind.Absolute));
            else if(Skills3 == "Innovation")
                Skills3_logo = new BitmapImage(new Uri("ms-appx:///Assets/innovation.png", UriKind.Absolute));
            else if(Skills3 == "Computer Engineering")
                Skills3_logo = new BitmapImage(new Uri("ms-appx:///Assets/computer_engineering.png", UriKind.Absolute));

        }

        public string Name { get; set; }

        public ImageSource Profile_Picture { get; set; }

        public string Location { get; set; }

        //public Image Friend1 { get; set; }

        //public Image Friend2 { get; set; }

        //public Image Friend3 { get; set; }

        public int Friends_Count { get; set; }

        public string Likes1 { get; set; }
        public ImageSource Likes1_logo { get; set; }

        public string Likes2 { get; set; }
        public ImageSource Likes2_logo { get; set; }

        public string Likes3 { get; set; }
        public ImageSource Likes3_logo { get; set; }

        public string Skills1 { get; set; }
        public ImageSource Skills1_logo { get; set; }

        public string Skills2 { get; set; }
        public ImageSource Skills2_logo { get; set; }

        public string Skills3 { get; set; }
        public ImageSource Skills3_logo { get; set; }
    }
}
