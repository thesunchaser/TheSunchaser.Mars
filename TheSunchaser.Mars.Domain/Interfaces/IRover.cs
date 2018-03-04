using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Constants;
using TheSunchaser.Mars.Domain.Entities;

namespace TheSunchaser.Mars.Domain.Interfaces
{
    public interface IRover
    {
        /// <summary>
        /// Get the unique ID of the Rover
        /// </summary>
         Guid Id { get; }

        /// <summary>
        /// Get the friendly name of the rover
        /// </summary>
        string Name { get;}

        /// <summary>
        /// The current position of the Rover
        /// </summary>
        Position Position { get; set; }

        /// <summary>
        /// The current orientation of the rover
        /// </summary>
        Orientation Orientation { get; set; }


        /// <summary>
        /// Executes the rover to perform the given input orders
        /// </summary>
        /// <param name="landingarea">Surface area Landing position</param>
        /// <param name="instructions">List of instructions to execute</param>
        void Execute(Plateau landingArea, IList<IInstruction> instructions);

        /// <summary>
        /// Sets the rover's friendly name
        /// </summary>
        /// <param name="name"></param>
        IRover SetName(string name);
    }
}
