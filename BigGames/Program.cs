using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigGames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> country = new List<string>
            {
            "Russia",
            "France",
            "China",
            "Ukraine"
            };
            Teams teams1 = new Teams(country);
            teams1.Games(new BeachGame());
            teams1.Games(new Fishing());
            teams1.Games(new MyGame());
            teams1.Games(new MouseTrap());
            teams1.Games(new Postman());
            teams1.Games(new See());
            teams1.Games(new Slide());
           Console.ReadKey();
        }
    }
}
