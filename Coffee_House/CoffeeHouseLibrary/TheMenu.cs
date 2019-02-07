using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseLibrary
{
    public class MainMenu
    {
        public void Menu()
        {
            string userSelection = "0";
            while (userSelection != "3")
            {
                Console.Clear();
                DailySales ds = new DailySales();
                WeeklyPayRoll wpr = new WeeklyPayRoll();

                Console.WriteLine($"Welcome!");
                Console.WriteLine($"select (1) to calculate youur daily sales.");
                Console.WriteLine($"Select (2) to calculate weekly payroll.");
                Console.WriteLine($"Or select (3) to exit");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        ds.Sales();
                        break;
                    case "2":
                        wpr.PayRoll();
                        break;
                    case "3":
                        Console.WriteLine($"Thank you, have a nice day!");
                        Console.ReadLine();
                        break;
                }
            } 
          
        }
    }
}


    

