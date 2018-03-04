using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSunchaser.Mars.Services.Base
{
    /// <summary>
    /// Represents a response class
    /// </summary>
    public abstract class ResponseBase
    {
        public Exception Exception { get; set; }
    }
}
