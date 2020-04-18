using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    class Ingridient
    {
        string name;
        public int price { get; }

        public Ingridient(string name, int price) 
        {
            this.name = name;
            this.price = price;
        }
    }
}
