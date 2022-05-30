using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInformationApp.Models
{
    public class Bus
    {
        public int RegistrationNo { get; set; }
        public string Name { get; set; }
        public string Route { get; set; }
        public string BusType { get; set; }
        public string Image { get; set; }
        public DateTime JourneyDate { get; set; }
        public string DeparturePlace { get; set; }
        public decimal Fare { get; set; }

        public string JourneyON { get => this.JourneyDate.ToString("MMM yyyy dd"); }
    }
}
