using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestHomework00.Core.Homework02
{
    public class MessyAddressInformation
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CleanAddressInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddres { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class MessyListToCleanList
    {
        public List<CleanAddressInformation> CleanAddresses(
            List<MessyAddressInformation> messyAddresses)
        {
            throw new NotImplementedException();
        }
    }
}
