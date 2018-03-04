using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Instructions
{
    public abstract class InstructionBase : IInstruction
    {
        public char Key { get; set; }

        public override string ToString()
        {
            return $"{Key}";
        }
    }
}
