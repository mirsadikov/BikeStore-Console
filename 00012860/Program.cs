using System;
using System.Collections.Generic;

namespace _00012860
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"***********************************************************
WELCOME TO THE BIKE STORE
***********************************************************");

            Store st = Store.GetStore();
            st.PopulateBikesForTest();

            repeatActions(st);
        }

        public static void repeatActions(Store st)
        {
            Console.Write(@"
What do you want to do?
[1] Search for
[2] Display all
>> type number: ");

            string step1 = Console.ReadLine();

            if (step1 == "1")
            {
                string selection = GetSelection();
                string search = GetSearch();

                Console.WriteLine("Type query: ");
                string q = Console.ReadLine();

                if (selection == "1")
                {
                    displayAsTable(st.SearchNew(st, search, q));
                }
                else
                {
                    displayAsTable(st.SearchUsed(st, search, q));
                }
            }
            else if (step1 == "2")
            {
                displayAsTable(st.GetAllBikes());
            }
            else
            {
                Console.WriteLine("\nWRONG SELECATOIN");
            }

            Console.WriteLine("**************************************************************");
            repeatActions(st);
        }


        // get list and display as table
        public static void displayAsTable(List<Bike> bikes)
        {
            if (bikes.Count <= 0)
            {
                Console.WriteLine("\nNO BIKES FOUND");
                return;
            }


            Console.WriteLine();
            Console.Write("Model".PadRight(15, ' '));
            Console.Write('|');
            Console.Write("Brand".PadRight(15, ' '));
            Console.Write('|');
            Console.Write("Price".PadRight(10, ' '));
            Console.Write('|');
            Console.Write("Rating".PadRight(10, ' '));
            Console.Write('|');
            Console.Write("Year".PadRight(10, ' '));
            Console.Write('|');
            Console.WriteLine("Type".PadRight(15, ' '));
            Console.WriteLine("—".PadRight(75, '—'));

            foreach (Bike bike in bikes)
            {
                Console.Write(bike.Model.PadRight(15, ' '));
                Console.Write('|');
                Console.Write(bike.Brand.PadRight(15, ' '));
                Console.Write('|');
                Console.Write(bike.Price.ToString().PadRight(10, ' '));
                Console.Write('|');
                Console.Write(bike.CustomerRating.PadRight(10, ' '));
                Console.Write('|');
                Console.Write(bike.ProductionYear.ToString().PadRight(10, ' '));
                Console.Write('|');
                Console.WriteLine(bike.GetType().ToString().PadRight(15, ' '));
            }

            Console.WriteLine();
        }

        // Ask user for search selection: by Model or by Industry
        static string GetSelection()
        {
            Console.Write(@"
What do you want to search: 
[1] New Bike
[2] Used Bike

>>");
            string q = Console.ReadLine();

            if (q != "1" && q != "2")
            {
                Console.WriteLine("WRONG INPUT!");
                return GetSelection();
            }
            else
            {
                return q;
            }
        }

        static string GetSearch()
        {
            Console.Write(@"
How do you want to search: 
[1] Model
[2] Brand
[3] Budget

>>");
            string q = Console.ReadLine();

            if (q != "1" && q != "2" && q != "3")
            {
                Console.WriteLine("WRONG INPUT!");
                return GetSearch();
            }
            else
            {
                return q;
            }
        }
    }
}
