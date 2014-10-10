using RPCGamePlay.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RPCGamePlay.Exceptions;

namespace RPCGamePlay
{
    class TEST
    {

        static void Main()
        {
            List<Player> players = new List<Player>();
            try
            {
                Game myGame = new Game(FileLoader.serializeFile(players, "SinglePlay.txt"));
                Console.WriteLine(myGame.play().ToString());
                Console.Read();
            }
            catch (InvalidPlayException ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }

        }

    }
}
