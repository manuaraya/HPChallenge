using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCGamePlay.Exceptions
{
    class InvalidPlayException: Exception
    {
        public InvalidPlayException() { }

        public InvalidPlayException(string message) : base(message) { }

        public InvalidPlayException(string message, Exception inner) : base(message, inner) { }


    }
}
