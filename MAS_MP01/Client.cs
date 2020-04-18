using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    class Client : Person
    {
        public int taxId { get; set; }

        public Client(string firstName, string lastName) : base(firstName, lastName)
        {    
        }
    }
}
