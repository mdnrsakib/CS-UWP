using BusInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInformationApp
{
    public class BusRepo
    {
        ObservableCollection<Bus> buses;
        public BusRepo()
        {
            this.buses = new ObservableCollection<Bus>()
            {
                new Bus{RegistrationNo=8587,Name="Saintmartin Paribhan",Route="Dhaka-Cox's Bazar-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,26),DeparturePlace="Arambag" ,Fare=1650.00M,Image="Assets/i1.jpg"},
                new Bus{RegistrationNo=9097,Name="GreenLine Express",Route="Dhaka-Benapol-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,28),DeparturePlace="Gabtoli", Fare=1800.00M,Image="Assets/i2.jpg"},
                new Bus{RegistrationNo=8590,Name="Hanif Enterprise",Route="Dhaka-Sylhet-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,27),DeparturePlace="Kamalapur" ,Fare=750.00M,Image="Assets/i3.jpg" },
                new Bus{RegistrationNo=9587,Name="Royal Express",Route="Dhaka-Khustia-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,29),DeparturePlace="Shymoli", Fare=650.00M,Image="Assets/i4.jpg" },
                new Bus{RegistrationNo=7587,Name="Unique Service",Route="Dhaka-Chattogram-Dhaka",BusType="Non-Ac", JourneyDate=new DateTime(2022,05,30),DeparturePlace="Saydabad", Fare=450.00M,Image="Assets/i5.jpg" },
                new Bus{RegistrationNo=8962,Name="Nabil Express",Route="Dhaka-Chattogram-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,30),DeparturePlace="Saydabad", Fare=450.00M,Image="Assets/i6.jpg" },
                new Bus{RegistrationNo=8752,Name="Himachol Express",Route="Dhaka-Noakhali-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Kamalapur", Fare=450.00M,Image="Assets/i7.jpg"},
                new Bus{RegistrationNo=7532,Name="London Express",Route="Dhaka-Sylhet-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Kamalapur", Fare=1050.00M,Image="Assets/i8.jpg"},
                new Bus{RegistrationNo=9863,Name="Sakura Paribahan",Route="Dhaka-Barishal-Dhaka",BusType="Non-Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Kamalapur", Fare=1050.00M,Image="Assets/i9.jpg"},
                new Bus{RegistrationNo=6825,Name="Ena Service",Route="Dhaka-Maymansingh-Dhaka",BusType="Non-Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Kamalapur", Fare=1050.00M,Image="Assets/i10.jpg"},
                new Bus{RegistrationNo=5580,Name="Asia Aircon",Route="Dhaka-Cumilla-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Kamalapur", Fare=350.00M,Image="Assets/i11.jpg"},
                new Bus{RegistrationNo=8004,Name="Dipjol Paribahan",Route="Dhaka-Rangpur-Dhaka",BusType="Non-Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Gabtoli", Fare=450.00M,Image="Assets/i12.jpg"},
                new Bus{RegistrationNo=8003,Name="Shohagh Elite",Route="Dhaka-Teknaf-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Kamalapur", Fare=2250.00M,Image="Assets/i13.jpg"},
                new Bus{RegistrationNo=8007,Name="TungiPara Express",Route="Dhaka-Gopalgonj-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Gabtoli", Fare=650.00M,Image="Assets/i14.jpg"},
                new Bus{RegistrationNo=9007,Name="Desh Travels",Route="Dhaka-Rajshahi-Dhaka",BusType="Ac", JourneyDate=new DateTime(2022,05,31),DeparturePlace="Gabtoli", Fare=950.00M,Image="Assets/i15.jpg"},

            };
        }
        public ObservableCollection<Bus> Get()
        {
            return this.buses;
        }
        public Bus Get(int id)
        {
            return this.buses.First(x => x.RegistrationNo == id);
        }
    }
}
