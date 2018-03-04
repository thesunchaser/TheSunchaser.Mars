using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSunchaser.Mars.Domain.Interfaces
{
    /// <summary>
    /// Represents an instruction
    /// </summary>
    public interface IInstruction
    {
        /// <summary>
        /// Char representing an instruction key
        /// </summary>
        char Key { get; }

    }
}
