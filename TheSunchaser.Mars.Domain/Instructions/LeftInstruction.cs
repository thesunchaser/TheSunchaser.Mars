using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Instructions
{
    /// <summary>
    /// Represents an instruction to go left
    /// </summary>
    public class LeftInstruction : InstructionBase, IInstruction
    {
        public LeftInstruction()
        {
            Key = 'L';
        }
    }
}
