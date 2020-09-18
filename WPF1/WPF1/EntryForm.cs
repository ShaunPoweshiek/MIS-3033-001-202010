using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    { //Set class variables
        public string name { get; set; }
        public string address { get; set; }
        public int zipCode { get; set; }

        //default contructor.
        public EntryForm()
        {
            name = string.Empty;
            address = string.Empty;
            zipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            this.name = name;
            this.address = address;
            this.zipCode = zipCode;
        }
    }


}
