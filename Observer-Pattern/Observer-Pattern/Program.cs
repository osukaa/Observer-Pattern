using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer_Pattern.Test;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation test = new WeatherStation();
            test.main();

            Console.ReadKey(true);
        }
    }
}
