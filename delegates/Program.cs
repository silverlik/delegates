using System;

namespace delegates
{
    
   
        
    class Program
    { public static int Plus(int x, int y) => x + y;

        public static int Multi(int x, int y) => x * y;
    
        delegate int Function(int x, int y);
        static void Main(string[] args)
        {
            Function f = Plus;
            
            Console.WriteLine("Plus" + f(10,20));
            f = Multi;
            Console.WriteLine("Multi" + f(10, 20));
            f = delegate (int x, int y) { return x - y; };
            Console.WriteLine("Sub" + f(10, 20));

            Console.ReadLine();
        }
    }
}
