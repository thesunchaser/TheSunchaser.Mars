using System;
using System.Runtime.Serialization;

namespace TheSunchaser.Mars.Domain.Exceptions
{
    [Serializable]
    public class UnknownInstructionException : Exception
    {
       
        public UnknownInstructionException() : base("Unknown instruction key encountered.")
        {
        }

        public UnknownInstructionException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}