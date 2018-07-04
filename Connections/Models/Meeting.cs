using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Connections.Models
{
    public class Meeting
    {
        public string Location { get; set; }

        public string Name { get; set; }

        public string Attendee1 { get; set; }
        public Image Attendee1_image { get; set; }

        public string Attendee2 { get; set; }
        public Image Attendee2_Image { get; set; }

        public string Attendee3 { get; set; }
        public Image Attendee3_Image { get; set; }

        public DateTime Time { get; set; }


    }
}
