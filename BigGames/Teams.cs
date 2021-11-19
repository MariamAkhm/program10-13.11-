using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigGames
{
    class Teams
    {
        public List<string> teams;
        public Teams (List <string> teams)
        {
            this.teams = teams;
        }
        public void Games(IGames games)
        {
            games.ChooseGame(teams);
        }
    }
}
