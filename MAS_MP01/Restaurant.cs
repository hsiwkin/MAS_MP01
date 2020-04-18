using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    class Restaurant
    {
        public int taxId { get; set; }
        public Address address { get; set; }
        public Register register { get; set; }
        static List<Restaurant> allRestaurants = new List<Restaurant>();

        public Restaurant()
        {
            AddRestaurant(this);
        }

        public static void AddRestaurant(Restaurant restaurant)
        {
            allRestaurants.Add(restaurant);
        }

        public static void RemoveRestaurant(Restaurant restaurant)
        {
            allRestaurants.Remove(restaurant);
        }

        public static void PrintAllRestaurants()
        {
            Console.WriteLine("Extent of the class: " + typeof(Restaurant));
        }
    }
}
