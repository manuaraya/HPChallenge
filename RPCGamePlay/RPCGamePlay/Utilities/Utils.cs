using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPCGamePlay.Constants;

namespace RPCGamePlay.Utilities
{
   public static class Utils
    {

        public static string getName(char letter)
        {
            switch (letter)
            {
                case GlobalConstants.Rock:
                    return GlobalConstants.DisplayRock;
                case GlobalConstants.Paper:
                    return GlobalConstants.DisplayPaper;
                case GlobalConstants.Scissors:
                    return GlobalConstants.DisplayScissors;

                default:
                    throw new RPCGamePlay.Exceptions.InvalidPlayException(ExceptionConstants.wrongPlayFormat);
            }


        }

    }
}
