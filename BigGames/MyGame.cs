using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigGames
{
    class MyGame:IGames
    {
        public void ChooseGame(List<string> teams)
        {
            Console.WriteLine(teams[3] + "Играет  в мою игру");
        }
    }
}
