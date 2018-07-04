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
                Profile_Picture = "Assets/don_photo.jpg";

            else if (Globals.PERSON == 2)
                Profile_Picture = "Assets/ahmed_photo.jpg";

            else if (Globals.PERSON == 3)
                Profile_Picture = "Assets/james_photo.jpg";

            Location = location;
            Friends_Count = friends_count;
            Likes1 = likes1;



            Likes2 = likes2;
            Likes3 = likes3;
            Skills1 = skills1;
            Skills2 = skills2;
            Skills3 = skills3;

        }

        public string Name { get; set; }

        public string Profile_Picture { get; set; }

        public string Location { get; set; }

        //public Image Friend1 { get; set; }

        //public Image Friend2 { get; set; }

        //public Image Friend3 { get; set; }

        public int Friends_Count { get; set; }

        public string Likes1 { get; set; }
        public string Likes1_logo { get; set; }

        public string Likes2 { get; set; }
        public string Likes2_logo { get; set; }

        public string Likes3 { get; set; }
        public string Likes3_logo { get; set; }

        public string Skills1 { get; set; }
        public string Skills1_logo { get; set; }

        public string Skills2 { get; set; }
        public string Skills2_logo { get; set; }

        public string Skills3 { get; set; }
        public string Skills3_logo { get; set; }
    }
}
