using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSunchaser.Mars.Domain.Exceptions
{
    public class OutOfBoundException : Exception
    {
        public OutOfBoundException(string message) : base(message)
        {
        }

        public OutOfBoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
