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
    public sealed partial class MeetingDetails : Page
    {
        public static List<Meeting> don_meeting = new List<Meeting>();
        public static List<Meeting> ahmed_meeting = new List<Meeting>();
        public static List<Meeting> james_meeting = new List<Meeting>();
        public MeetingDetails()
        {
            this.InitializeComponent();

            if (MeetingView.ItemsSource == null)
            {
                if (Globals.meetings_flag == 0)
                {
                    Globals.meetings_flag = 1;

                    don_meeting.Add(new Meeting("City Walk, Dubai, UAE", "Coffee Chat", "Ahmed Aboulcher", "", ""));
                    don_meeting.Add(new Meeting("JBR, Dubai, UAE", "Photography Walk", "Jack Bing", "Adam Robinson", "Rahul Prakash"));
                    don_meeting.Add(new Meeting("Atlantis - The Palm, Dubai, UAE", "Catch up", "Leonardo DiCaprio", "", ""));

                    ahmed_meeting.Add(new Meeting("City Walk, Dubai, UAE", "Coffee Chat", "Don Joe Martin", "", ""));
                    ahmed_meeting.Add(new Meeting("Dubai Mall, Dubai, UAE", "Meet up", "James Daou", "", ""));
                    ahmed_meeting.Add(new Meeting("Dubai Autodrome, Dubai, UAE", "Porsche Drivers' Club", "Harry Winston", "James Arthur", "Jack Wild"));

                    james_meeting.Add(new Meeting("Dubai Mall, Dubai, UAE", "Meet up", "Ahmed Aboulcher", "", ""));
                    james_meeting.Add(new Meeting("Dubai Media City, UAE", "Football Fever", "Ahlam Mohammed", "Jared Pinto", "Chandler Bing"));
                }

                if (Globals.PERSON == 1)
                    MeetingView.ItemsSource = don_meeting;
                else if (Globals.PERSON == 2)
                    MeetingView.ItemsSource = ahmed_meeting;
                else
                    MeetingView.ItemsSource = james_meeting;
            }
        }

    }

    public class Meeting
    {
        public Meeting(string location, string name, string attendee1, string attendee2, string attendee3)
        {
            Location = location;
            Name = name;
            Attendee1 = attendee1;

            if (Attendee1 != "")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/guy_photo2.jpg", UriKind.Absolute));

            if (Attendee1 == "Don Joe Martin")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/don_photo1.jpg", UriKind.Absolute));

            else if (Attendee1 == "Ahmed Aboulcher")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/ahmed_photo.jpg", UriKind.Absolute));

            else if (Attendee1 == "James Daou")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/james_photo.jpg", UriKind.Absolute));

            else if (Attendee1 == "Leonardo DiCaprio")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/leo_photo.jpg", UriKind.Absolute));


            Attendee2 = attendee2;

            if(Attendee2 != "")
                Attendee2_Image = new BitmapImage(new Uri("ms-appx:///Assets/guy_photo.jpg", UriKind.Absolute));

            if (Attendee2 == "Don Joe Martin")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/don_photo1.jpg", UriKind.Absolute));

            else if (Attendee2 == "Ahmed Aboulcher")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/ahmed_photo.jpg", UriKind.Absolute));

            else if (Attendee2 == "James Daou")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/james_photo.jpg", UriKind.Absolute));

            else if (Attendee2 == "Leonardo DiCaprio")
                Attendee1_Image = new BitmapImage(new Uri("ms-appx:///Assets/leo_photo.jpg", UriKind.Absolute));

            Attendee3 = attendee3;

            if(Attendee3 != "")
                Attendee3_Image = new BitmapImage(new Uri("ms-appx:///Assets/arab_man.jpg", UriKind.Absolute));

        }

        public string Location { get; set; }

        public string Name { get; set; }

        public string Attendee1 { get; set; }
        public ImageSource Attendee1_Image { get; set; }

        public string Attendee2 { get; set; }
        public ImageSource Attendee2_Image { get; set; }

        public string Attendee3 { get; set; }
        public ImageSource Attendee3_Image { get; set; }

        //public DateTime Time { get; set; }

    }
}
