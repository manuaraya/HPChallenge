using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPCGamePlay.Exceptions;
using RPCGamePlay.Constants;

namespace RPCGamePlay.Core
{
    public class Game
    {
        public List<Player> players;

        public Game() { }

        public Game(List<Player> players)
        {
            this.players = new List<Player>(players);
        }

        public void add(Player player)
        {
            players.Add(player);
        }

        public void remove(Player player)
        {
            players.Remove(player);
        }

        public Player play()
        {
            var temp = new List<Player>();
            int secondPlayerIndex;

            gameEval(this.players.Count);

            for (int i = 0; i < this.players.Count; i += 2)
            {
                secondPlayerIndex = i + 1;
                temp.Add(getMatchWinner(players.ElementAt(i), players.ElementAt(secondPlayerIndex)));
            }

            if (temp.Count == 1)
            {
                return temp.ElementAtOrDefault(0);
            }
            else
            {
                this.players = temp;
                return play();
            }
        }

        private void gameEval(int numberOfPlayers)
        {
            if (numberOfPlayers < 2)
                throw new InvalidPlayException(ExceptionConstants.wrongNumberOfPlayers);
            if (numberOfPlayers % 2 != 0)
                throw new InvalidPlayException(ExceptionConstants.invalidTournament);


        }

        private Player getMatchWinner(Player playerOne, Player playerTwo)
        {
            switch (playerOne.play)
            {
                case GlobalConstants.Rock:
                    return (playerTwo.play == GlobalConstants.Scissors || playerTwo.play == GlobalConstants.Rock) ? playerOne : playerTwo;

                case GlobalConstants.Paper:
                    return (playerTwo.play == GlobalConstants.Rock || playerTwo.play == GlobalConstants.Paper) ? playerOne : playerTwo;

                case GlobalConstants.Scissors:
                    return (playerTwo.play == GlobalConstants.Paper || playerTwo.play == GlobalConstants.Scissors) ? playerOne : playerTwo;

                default:
                    throw new InvalidPlayException(ExceptionConstants.wrongPlayFormat);
            }
        }
    }
}
