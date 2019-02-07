using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeHouseLibrary
{
    class WeeklyPayRoll
    {
        public void PayRoll()
        {
            try
            {
                double S = 12.50;
                double a;
                double b;
                double c;
                double d;
                double e;
                double ot;
                Console.WriteLine($"How many hours did {Employess.Jon} work this week?");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many hours did {Employess.Jacky} work this week?");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many hours did {Employess.Issy} work this week?");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many hours did {Employess.Eric} work this week?");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"How many hours did {Employess.Elaine} work this week?");
                e = Convert.ToDouble(Console.ReadLine());
                ot = S + (S / 2);
                if (a <= 40)
                {
                    Console.WriteLine($"{Employess.Jon} earned ${a * S}");
                    Console.ReadLine();
                }
                if (a >= 40)
                {
                    Console.WriteLine($"{Employess.Jon} earned ${a * ot}");
                    Console.ReadLine();
                }
                if (b <= 40)
                {
                    Console.WriteLine($"{Employess.Jacky} earned ${b * S}");
                    Console.ReadLine();
                }
                if (b >= 40)
                {
                    Console.WriteLine($"{Employess.Jacky} earned ${b * ot}");
                    Console.ReadLine();
                }
                if (c <= 40)
                {
                    Console.WriteLine($"{Employess.Issy} earned ${c * S}");
                    Console.ReadLine();
                }
                if (c >= 40)
                {
                    Console.WriteLine($"{Employess.Issy} earned ${c * ot}");
                    Console.ReadLine();
                }
                if (d <= 40)
                {
                    Console.WriteLine($"{Employess.Eric} earned ${d * S}");
                    Console.ReadLine();
                }
                if (d >= 40)
                {
                    Console.WriteLine($"{Employess.Eric} earned ${d * ot}");
                    Console.ReadLine();
                }
                if (e <= 40)
                {
                    Console.WriteLine($"{Employess.Elaine} earned ${e * S}");
                    Console.ReadLine();
                }
                if (e >= 40)
                {
                    Console.WriteLine($"{Employess.Elaine} earned ${e * ot}");
                    Console.ReadLine();
                }

                // Console.WriteLine($"{Employess.Jon} earned ${a * S}, {Employess.Jacky} earned ${b * S}, {Employess.Issy} earned ${c * S}, {Employess.Eric} earned ${d * S}, and {Employess.Elaine} earned ${e * S}");
                

              
            }
            catch (Exception)
            {
                Console.WriteLine($"Please input a valid value.");
                WeeklyPayRoll wpr = new WeeklyPayRoll();
                wpr.PayRoll();
            }
        }
        public enum Employess
        {
           Jon, Jacky, Issy, Eric, Elaine
        }
    }
}
