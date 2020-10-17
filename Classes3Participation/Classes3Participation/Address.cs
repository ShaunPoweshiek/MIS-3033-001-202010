using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3Participation
{
    //Constructor Properties
    class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
    }

    //Default Constructor Methods
    public Address()
    {
        StreetNumber = 0;
        StreetName = "";
        State = "";
        City = "";
        Zip = 0;
    }

    public Address(int streetNumber, string streetName, string state, string city, int zip)
    {
        streetNumber = StreetNumber;
        streetName = StreetName;
        state = State;
        city = City;
        zip = Zip;
    }
}
