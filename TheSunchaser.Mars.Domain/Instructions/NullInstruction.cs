using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Instructions
{
    /// <summary>
    /// Represents an empty or null instruction
    /// </summary>
    public class NullInstruction : InstructionBase, IInstruction
    {
        public NullInstruction()
        {
            Key = ' ';
        }
    }
}
