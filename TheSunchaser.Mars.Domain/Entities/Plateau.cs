using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Entities
{
    public class Plateau
    {
        public Position LowerBound { get; set; }

        public Position UpperBound { get; set; }

        public bool IsWithinBounds(Position position)
        {
            return 
                (position.XCoordinate >= LowerBound.XCoordinate 
                    && position.XCoordinate <= UpperBound.XCoordinate)
                &&
                (position.YCoordinate >= LowerBound.YCoordinate 
                    && position.YCoordinate <= UpperBound.YCoordinate);

        }
    }
}
