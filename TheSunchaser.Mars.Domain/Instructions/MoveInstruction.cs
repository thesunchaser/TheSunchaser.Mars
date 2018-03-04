using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Instructions
{
    public class MoveInstruction : InstructionBase, IInstruction
    {
        public MoveInstruction()
        {
            Key = 'M';
        }
    }
}
