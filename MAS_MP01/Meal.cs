using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_MP01
{
    class Meal
    {
        List<Ingridient> ingridients;

        public Meal(List<Ingridient> ingridients)
        {
            this.ingridients = ingridients;
        }

        public double price
        {
            get
            {
                var ingridientsPriceSum = 0;
                var margin = .8;

                foreach (Ingridient ingridient in ingridients)
                {
                    ingridientsPriceSum += ingridient.price;
                }

                return (1 + margin) * ingridientsPriceSum;
            }
        }
    }
}
