using System;
using System.Collections.Generic;
using System.Text;

namespace _00012860
{
    class NewBike : Bike
    {
        public NewBike(string model, string brand, int price, int productionYear, string rating)
        {
            Model = model;
            Brand = brand;
            Price = price;
            Condition = Condition.New;
            ProductionYear = productionYear;
            CustomerRating = rating;
        }
        public override double GetPriceWithTax()
        {
            // imagine we have 10% tax for new bikes
            return Price * 1.1;
        }
        protected override Type Type { get => Type.New; set { Type = Type.New; } }


    }
}
