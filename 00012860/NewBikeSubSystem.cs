using System;
using System.Collections.Generic;
using System.Text;

namespace _00012860
{
    class NewBikeSubSystem
    {


        public List<Bike> SearchNew(Store st, string selection, string q)
        {
            List<Bike> searchResults = new List<Bike>();

            foreach (Bike bike in st.GetAllBikes())
            {
                if (bike.GetType() == Type.New)
                {

                    if (selection == "1" && bike.Model.ToLower().Contains(q.ToLower()))
                    {
                        searchResults.Add(bike);
                    }
                    else if (selection == "2" && bike.Brand.ToLower().Contains(q.ToLower()))
                    {
                        searchResults.Add(bike);
                    }
                    else if (selection == "3" && bike.Price.ToString() == q)
                    {
                        searchResults.Add(bike);
                    }
                }
            }

            return searchResults;
        }
    }
}
