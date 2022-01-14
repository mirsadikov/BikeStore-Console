using System;
using System.Collections.Generic;
using System.Text;

namespace _00012860
{
    class Store
    {
        private List<Bike> Bikes;

        // For Facade Design Pattern
        private UsedBikeSubSystem _UsedProvider;
        private NewBikeSubSystem _NewProvider;


        private Store()
        {
            Bikes = new List<Bike>();
            _UsedProvider = new UsedBikeSubSystem();
            _NewProvider = new NewBikeSubSystem();

        }

        private static Store _ourStore;
        public static Store GetStore()
        {
            // return store, if null return new Store
            return _ourStore ??= new Store();
        }

        public List<Bike> GetAllBikes()
        {
            return Bikes;
        }


        // Design Pattern: Factory
        // Can get 2 types of instance
        public void AddBike(Bike bike)
        {
            Store st = GetStore();
            st.Bikes.Add(bike);
        }

        // Polymorphism
        public void AddBike(string model, string brand, int price, int productionYear, string rating)
        {
            Store st = GetStore();
            st.Bikes.Add(new NewBike(model, brand, price, productionYear, rating));
        }
        public void AddBike(string model, string brand, Condition condition, int price, int productionYear, string rating)
        {
            Store st = GetStore();
            st.Bikes.Add(new UsedBike(model, brand, condition, price, productionYear, rating));
        }

        public List<Bike> SearchNew(Store st, string selection, string q)
        {
            return _NewProvider.SearchNew(st, selection, q);
        }

        public List<Bike> SearchUsed(Store st, string selection, string q)
        {
            return _UsedProvider.SearchUsed(st, selection, q);

        }


        public void PopulateBikesForTest()
        {
            AddBike(new NewBike("B1", "Phillips", 139, 2019, "9"));
            AddBike(new NewBike("XX77", "Rambo", 150, 2018, "4"));
            AddBike(new UsedBike("B7", "Phillips", Condition.Good, 109, 2019, "5"));
            AddBike(new UsedBike("SuperM1", "Arm", Condition.Normal, 99, 2017, "6"));

            AddBike("XX66", "Rumus", 150, 2018, "9");
            AddBike("SuperPro", "Arm", Condition.Bad, 99, 2017, "9");
        }

    }
}
