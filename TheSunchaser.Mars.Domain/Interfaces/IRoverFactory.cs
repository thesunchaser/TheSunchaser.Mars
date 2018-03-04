using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSunchaser.Mars.Domain.Interfaces
{
    /// <summary>
    /// Interface factory responsible for creation of Rover entities
    /// </summary>
    public interface IRoverFactory
    {
        IRover GetRover(string deployment);
    }
}
