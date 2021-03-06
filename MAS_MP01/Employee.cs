﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    [Serializable]
    public class Employee : Person
    {
        public int salary { get; set; }
        public int employeeId { get; set; }

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        // przesłonięcie
        public new string GetIdentificationString()
        {
            return $"{base.GetIdentificationString()}: {employeeId}";
        }
    }
}
