using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    class Address
    {
        string street;
        string city;
        string zipCode;
        string apartmentNumber;

        public Address(string street, string city, string zipCode, string apartmentNumber = null)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.apartmentNumber = apartmentNumber;
        }

        public void UpdateAddress(string street, string city, string zipCode, string apartmentNumber = null)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.apartmentNumber = apartmentNumber;
        }

        public void UpdateAddress(Address address)
        {
            this.street = address.street;
            this.city = address.city;
            this.zipCode = address.zipCode;
            this.apartmentNumber = address.apartmentNumber;
        }
    }
}
