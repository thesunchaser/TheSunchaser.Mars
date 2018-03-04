using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Services.Base;

namespace TheSunchaser.Mars.Domain.Parser.Messages
{
    /// <summary>
    /// Represents a request action that contains parameters
    /// </summary>
    public class ExecuteRequest : RequestBase
    {
        public string Input { get; set; }
    }
}
