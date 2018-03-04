using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Constants;
using TheSunchaser.Mars.Domain.Exceptions;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Entities
{
    public class Rover : IRover
    {
        #region Ctor
        public Rover()
        {
            Position = new Position() { XCoordinate = 0, YCoordinate = 0 };
            Id = Guid.NewGuid();
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets the Id of the Rover
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the friendly name of the Rover
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the current position of the Rover
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Gets the current orientation 
        /// </summary>
        public Orientation Orientation { get; set; }

        /// <summary>
        /// Gets the Landing Area of the rover
        /// </summary>
        public Plateau LandingArea { get; private set; }

        #endregion

        #region Public Properties

        public void Execute(Plateau landingArea, IList<IInstruction> instructions)
        {
            this.LandingArea = landingArea;

            foreach (var instruct in instructions)
            {
                switch (instruct.Key)
                {
                    case 'L':
                        GoLeft();
                        break;
                    case 'R':
                        GoRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        //do nothing
                        break;
                }
            }
        }


        #endregion

        #region Private Functions
        /// <summary>
        /// Changes the orientation of the rover to go Left 
        /// </summary>
        private void GoLeft()
        {
            this.Orientation = (this.Orientation - 1) < Orientation.N ? Orientation.W : this.Orientation - 1;
        }
        /// <summary>
        /// Changes the orientation of the rover to go Right 
        /// </summary>
        private void GoRight()
        {
            this.Orientation = (this.Orientation + 1) > Orientation.W ? Orientation.N : this.Orientation + 1;
        }

        /// <summary>
        /// Changes the position of the Rover
        /// </summary>
        private void Move()
        {
            switch (this.Orientation)
            {
                case Orientation.N:
                    this.Position.YCoordinate++;
                    break;
                case Orientation.E:
                    this.Position.XCoordinate++;
                    break;
                case Orientation.S:
                    this.Position.YCoordinate--;
                    break;
                case Orientation.W:
                    this.Position.XCoordinate--;
                    break;
                default:
                    throw new InvalidOperationException("Invalid orientation");
            }

            //check if the new position is within boundary
            if (!this.LandingArea.IsWithinBounds(this.Position))
            {
                throw new OutOfBoundException($"{this} is out of bound");
            }

        }

        public IRover SetName(string name)
        {
            this.Name = name;
            return this;
        }
        #endregion


        #region Overrides
        public override string ToString()
        {
            return $"Rover: {this.Name} Id: {Id} {Position.XCoordinate} {Position.YCoordinate} {Orientation}";
        }

        

        #endregion
    }
}
