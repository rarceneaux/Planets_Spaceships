using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            string demPlanets = string.Join(",", planetList);
            Console.WriteLine(demPlanets);

            var planetList2 = new List<string>() {"Neptune","Uranus"};
            planetList.AddRange(planetList2);
            planetList.Insert(0,"Earth");
            planetList.Insert( 7,"Venus");
            planetList.Add("Pluto");

            var myPlanets = planetList.GetRange(0, 9);
            var rockyPlanets = new List<string>(){"Earth","Mercury","Venus","Mars"};
            myPlanets.Remove("Pluto");

            //Dictionary//
            
            var spacecrafts = new Dictionary<string,string>();

            spacecrafts.Add("SpaceX", "Mars,Saturn,Mercury");
            spacecrafts.Add("BlueOrigin", "Venus,Neptune");

            foreach (var (ship, planet) in spacecrafts)
            {
                Console.WriteLine($"Ship:{ship},Planets:{planet}");
            }
        }
    }
}
