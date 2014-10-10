using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCGamePlay.Constants
{
    static class ExceptionConstants
    {
        public const string wrongPlayFormat = "The Play most be a Upper Case Letter R(ock), P(paper), S(cissors)";
        public const string wrongNumberOfPlayers = "Must have atleast 2 players";
        public const string invalidTournament = "The number of players for a tournament must be Even";
    }
}
