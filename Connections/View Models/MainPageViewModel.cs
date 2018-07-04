using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Connections.Helper_Class;
using Connections.Models;

namespace Connections.View_Models
{
    public class MainPageViewModel : BindableBase
    {
        private List<Feed> don_feed;

        public List<Feed> Don_Feed
        {
            get
            {
                return don_feed;
            }

            set
            {
                SetProperty(ref don_feed, value);
            }
        }
            public MainPageViewModel()
        {
            Don_Feed = new List<Feed>();

            Don_Feed.Add(new Feed
            {
                Poster = "Ahmed Aboulcher",
                Post_Text = "Great meeting you @Jame_Daou",
                //Poster_Image = "",
                //Posted_Time = ,
                Post_Type = "Meeting",
                //Post_Type_Logo = " "
            });
         }

        
    }
}
