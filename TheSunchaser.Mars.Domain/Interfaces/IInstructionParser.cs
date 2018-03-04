using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSunchaser.Mars.Domain.Interfaces
{
    public interface IInstructionParser
    {
        IList<IInstruction> Parse(string input);
    }
}
