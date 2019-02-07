using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseLibrary
{
    class DailySales
    {
        public void Sales()
        {
            try
            {
                double a;
                double b;
                double c;
                double d;
                double e;
                
                Console.WriteLine($"How many small coffess were sold?");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many meduim coffess were sold?");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many large coffess were sold?");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many egg sandwiches were sold?");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many checken biscuits were sold?");
                e = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"The total sales for today is: ${((sales.smallCoffee * a) - (a * sales.CostSC)) + ((sales.meduimCoffee * b) - (b * sales.CostMC)) + ((sales.largeCoffee * c) - (c * sales.CostLC)) + ((sales.Eggs * d) - (sales.CostE * d)) + ((sales.Chick * e) - (sales.CostC * e)) }");
                Console.ReadLine();

            } catch (Exception)
            {
                Console.WriteLine($"Please input a valid value.");
                DailySales ds = new DailySales();
                ds.Sales();
            }
    }
        public struct sales
        {
            public const double smallCoffee = 1.00;
            public const double meduimCoffee = 3.00;
            public const double largeCoffee = 1.00;
            public const double Eggs= 5.50;
            public const double Chick = 7.50;
            public const double CostSC = 0.10;
            public const double CostMC = 0.15;
            public const double CostLC = 0.20;
            public const double CostE = 0.95;
            public const double CostC = 1.20;
        }

    }
}

