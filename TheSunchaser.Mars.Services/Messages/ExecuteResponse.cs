using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Services.Base;

namespace TheSunchaser.Mars.Domain.Parser.Messages
{
    /// <summary>
    /// Represents the output result of a request
    /// </summary>
    public class ExecuteResponse : ResponseBase
    {
        public string Output { get; set; }
    }
}
