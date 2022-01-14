using System;
using System.Collections.Generic;
using System.Text;

namespace _00012860
{
    class UsedBike:Bike
    {
        public UsedBike(string model, string brand, Condition condition, int price, int productionYear, string rating)
        {
            Model = model;
            Brand = brand;
            Price = price;
            Condition = condition;
            ProductionYear = productionYear;
            CustomerRating = rating;
        }

        public override double GetPriceWithTax()
        {
            // no tax, we suppose
            return Price;
        }
        protected override Type Type { get => Type.Used; set { Type = Type.Used; } }
        public int YearsUsed
        {
            get => DateTime.Now.Year - ProductionYear;
        }
    }
}
