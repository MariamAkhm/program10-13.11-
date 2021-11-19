using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigGames
{
    class Fishing:IGames
    {
        public void ChooseGame(List<string> teams)
        {
            Console.WriteLine(teams[1] + "Играет в рыбалку");
        }
    }
}
