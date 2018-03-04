using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Instructions;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Parsers
{
    public class InstructionParser : IInstructionParser
    {
        public IList<IInstruction> Parse(string input)
        {
            List<IInstruction> instructions = new List<IInstruction>();

            //e.g. LMLMLMLMM
            foreach (char c in input.ToUpper())
            {
                IInstruction newInstruction = new NullInstruction(); ;

                switch (c)
                {
                    case 'L':
                        newInstruction = new LeftInstruction();
                        break;
                    case 'M':
                        newInstruction = new MoveInstruction();
                        break;
                    case 'R':
                        newInstruction = new RightInstruction();
                        break;
                    default:
                        break;
                }

                instructions.Add(newInstruction);
            }

            return instructions;
        }
    }
}
