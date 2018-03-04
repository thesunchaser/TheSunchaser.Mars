using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Entities;
using TheSunchaser.Mars.Domain.Parser.Messages;

namespace TheSunchaser.Mars.Services.Interfaces
{
    public interface IRoverService
    {
        /// <summary>
        /// A Service interface to interact with the Rover Domain
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ExecuteResponse ParseInput(ExecuteRequest request);
    }
}
