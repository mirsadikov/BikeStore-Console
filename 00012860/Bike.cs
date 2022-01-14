using System;
using System.Collections.Generic;
using System.Text;

namespace _00012860
{
    public interface IBike
    {
        /*id, model, price, condition, and production year*/
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        int Price { get; set; }
        Condition Condition { get; set; }
        int ProductionYear { get; set; }
    }


    abstract class Bike:IBike
    {
        private int _id;
        public int Id {
            get => _id;
            set { _id = value; }
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public Condition Condition { get; set; }
        protected abstract Type Type { get; set; }
        public int ProductionYear { get; set; }
        public string CustomerRating { get; set; }

        public abstract double GetPriceWithTax();
        public new Type GetType()
        {
            return Type;
        }


    }

    public enum Condition
    {
        New,
        Good,
        Normal,
        Bad
    }

    public enum Type
    {
        New,
        Used
    }
}
