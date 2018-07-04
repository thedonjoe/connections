using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Connections.Models
{
    public class Request
    {
        public string Requester { get; set; }

        public string Receiver { get; set; }

        public DateTime Requested_Date { get; set; }

        public Image Requester_Image { get; set; }

        public string Request_Type { get; set; }

        public Image Request_Type_Logo { get; set; }

        public string Request_Text { get; set; }

    }
}
