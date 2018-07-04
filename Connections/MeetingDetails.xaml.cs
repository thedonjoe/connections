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
    public sealed partial class MeetingDetails : Page
    {
        public static List<Meeting> don_meeting = new List<Meeting>();
        public static List<Meeting> ahmed_meeting = new List<Meeting>();
        public static List<Meeting> james_meeting = new List<Meeting>();
        public MeetingDetails()
        {
            this.InitializeComponent();

            don_meeting.Add(new Meeting("City Walk, Dubai, UAE", "Coffee Chat", "Ahmed Aboulcher", "", ""));
            don_meeting.Add(new Meeting("JBR, Dubai, UAE", "Photography Walk", "Jack Bing", "Adam Robinson", "Rahul Prakash"));
            don_meeting.Add(new Meeting("Atlantis - The Palm, Dubai, UAE", "Catch up", "Leonardo DiCaprio", "", ""));

            ahmed_meeting.Add(new Meeting("City Walk, Dubai, UAE", "Coffee Chat", "Don Joe Martin", "", ""));
            ahmed_meeting.Add(new Meeting("Dubai Mall, Dubai, UAE", "Meet up", "James Daou", "", ""));
            ahmed_meeting.Add(new Meeting("Dubai Autodrome, Dubai, UAE", "Porsche Drivers' Club", "Harry Winston", "James Arthur", "Jack Wild"));

            james_meeting.Add(new Meeting("Dubai Mall, Dubai, UAE", "Meet up", "Ahmed Aboulcher", "", ""));
            james_meeting.Add(new Meeting("Dubai Media City, UAE", "Football Fever", "Ahlam Mohammed", "Jared Pinto", "Chandler Bing"));

            if (Globals.PERSON == 1)
                MeetingView.ItemsSource = don_meeting;
            else if (Globals.PERSON == 2)
                MeetingView.ItemsSource = ahmed_meeting;
            else
                MeetingView.ItemsSource = james_meeting;
        }

    }

    public class Meeting
    {
        public Meeting(string location, string name, string attendee1, string attendee2, string attendee3)
        {
            Location = location;
            Name = name;
            Attendee1 = attendee1;
            Attendee2 = attendee2;
            Attendee3 = attendee3;

        }

        public string Location { get; set; }

        public string Name { get; set; }

        public string Attendee1 { get; set; }
        //public Image Attendee1_image { get; set; }

        public string Attendee2 { get; set; }
        //public Image Attendee2_Image { get; set; }

        public string Attendee3 { get; set; }
        //public Image Attendee3_Image { get; set; }

        //public DateTime Time { get; set; }

    }
}
