﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    public class Ingridient
    {
        public static Address WarehouseAddress { get; set; }

        // atrybut prosty
        public string Name { get; }
        public int Price { get; }

        public Ingridient(string name, int price) 
        {
            this.Name = name;
            this.Price = price;
        }

        // metoda klasowa
        public static string ShowWarehouseAddress()
        {
            return WarehouseAddress.ToString();
        }
    }
}
