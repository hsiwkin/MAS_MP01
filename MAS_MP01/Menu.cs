using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    class Menu
    {
        public List<Meal> meals { get; }

        Menu(List<Meal> meals)
        {
            this.meals = meals;
        }
    }
}
