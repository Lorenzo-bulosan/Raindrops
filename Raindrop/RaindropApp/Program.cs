using System;

namespace RaindropApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("======== Raindrops ====");

            Raindrops Raindrops = new Raindrops();
            Console.WriteLine(Raindrops.Solve(15));
        }
    }
}
