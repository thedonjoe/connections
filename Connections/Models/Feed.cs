using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Connections.Models
{
    public class Feed
    {
        public string Poster { get; set; }

        public string Post_Text { get; set; }

        public Image Poster_Image { get; set; }

        public DateTime Posted_Time { get; set; }

        public string Post_Type { get; set; }
        public Image Post_Type_Logo { get; set; }
    }
}
