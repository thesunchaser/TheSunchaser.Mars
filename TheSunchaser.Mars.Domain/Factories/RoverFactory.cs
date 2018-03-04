using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Constants;
using TheSunchaser.Mars.Domain.Entities;
using TheSunchaser.Mars.Domain.Exceptions;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Factories
{
    public class RoverFactory : IRoverFactory
    {
        public IRover GetRover(string conditions)
        {
            // no logic required for creation of rover, therefore create a simple rover object
            return SetDeployment(conditions);
        }

        /// <summary>
        /// Sets the initial deployment of the given rover using the string input
        /// </summary>
        /// <param name="rover"></param>
        /// <param name="input"></param>
        private IRover SetDeployment(string input)
        {
            IRover rover = new Rover();
            
            var instructions = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (instructions.Length == 3)
            {
                var roverPosition = new Position { XCoordinate = int.Parse(instructions[0]), YCoordinate = int.Parse(instructions[1]) };
                var roverOrientation = (Orientation)Enum.Parse(typeof(Orientation), instructions[2]);

                rover.Position = roverPosition;
                rover.Orientation = roverOrientation;
            }
            else
            {
                throw new ParserException("Expecting two input integer values for upper right coordinates");
            }
            return rover;
        }
    }
}
