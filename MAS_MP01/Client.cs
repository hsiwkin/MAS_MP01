using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    [Serializable]
    public class Client : Person
    {
        public int taxId { get; set; }
        // Atrybut złożony
        public Address postalAddress { get; set; }

        public Client(string firstName, string lastName) : base(firstName, lastName)
        {    
        }
    }
}
