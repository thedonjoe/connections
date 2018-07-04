using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Connections.Models
{
    public class Profile
    {
        public string Name { get; set; }

        public Image Profile_Picture { get; set; }

        public string Location { get; set; }

        public Image Friend1 { get; set; }

        public Image Friend2 { get; set; }

        public Image Friend3 { get; set; }

        public string Friends_Count { get; set; }

        public string Likes1 { get; set; }
        public Image Likes1_Image { get; set; }

        public string Likes2 { get; set; }
        public Image Likes2_Image { get; set; }

        public string Likes3 { get; set; }
        public Image Likes3_Image { get; set; }

        public string Skills1 { get; set; }
        public Image Skills1_Logo { get; set; }

        public string Skills2 { get; set; }
        public Image Skills2_Logo { get; set; }

        public string Skills3 { get; set; }
        public Image Skills3_logo { get; set; }


    }
}
