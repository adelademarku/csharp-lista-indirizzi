using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class IndirizzoException : Exception
    {
        public IndirizzoException() : base()
        {

        }

        public IndirizzoException(string message) : base(message)
        {

        }
    }
}
