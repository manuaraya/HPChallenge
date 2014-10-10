using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPCGamePlay.Exceptions;
using RPCGamePlay.Constants;
using RPCGamePlay.Utilities;

namespace RPCGamePlay.Core
{
    public class Player
    {
        public string name { get; set; }
        public char play { get; set; }
       
        public Player()
        {
            // TODO: Complete member initialization
        }
        
        public override string ToString()
        {
            return String.Format(GlobalConstants.outputFormat, name, Utils.getName(play));
        }
    }
}
