using System;

namespace delegates
{       
    public static class Zones
    {
        public static float Zone1(float price) => price * (float)0.25;
        public static float Zone2(float price) => price * (float)0.12 + 25;
        public static float Zone3(float price) => price * (float)0.08;
        public static float Zone4(float price) => price * (float)0.04 + 25;
        
    }
   class Program
    {   
        delegate float Shipping(float x);
        static void Main(string[] args)
        {
            Shipping f = null;
            string s;
            do
            {
                Console.WriteLine("Please enter zone");
                s = Console.ReadLine();
                if (s.Equals("exit")) break;
                Console.WriteLine("Please enter a price of the item");
                var s1 = Console.ReadLine();
                if (float.TryParse(s1, out float price))
                {
                  
                    switch (s)
                    {
                        
                        case "zone1": f = Zones.Zone1; break;
                        case "zone2": f = Zones.Zone2; break;
                        case "zone3": f = Zones.Zone3; break;
                        case "zone4": f = Zones.Zone4; break;
                    }
                    if (f != null)
                    {
                        Console.WriteLine("Cost is {0:C}",f(price));
                    }
                    else Console.WriteLine("You've entered a wrong zone!");
                }
            } while (s != "exit");
           

            Console.ReadLine();
        }
    }
}
