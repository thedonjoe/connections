using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Connections.Models
{
    public class Friends
    {
        public string Name { get; set; }

        public Image Photo { get; set; }

        public int Connections_No { get; set; }

        public DateTime Connected_Date { get; set; }
    }
}
