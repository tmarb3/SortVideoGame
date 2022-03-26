using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] videoGames = { "Halo", "Cod", "Madden" };

            List<string> videoGamesList = new List<string>(videoGames);

            var name = from a in videoGames
                       orderby a.Length ascending
                       select a;
            foreach (var game in name)
            {
                Console.WriteLine(game);
            }
        }
    }
}
