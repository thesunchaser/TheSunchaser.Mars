using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Domain.Constants;
using TheSunchaser.Mars.Domain.Interfaces;

namespace TheSunchaser.Mars.Domain.Entities
{
    public class Position 
    {
        /// <summary>
        /// X-axis coordinate
        /// </summary>
        public int XCoordinate { get; set; }

        /// <summary>
        /// Y-axis coordinate
        /// </summary>
        public int YCoordinate { get; set; }


    }
}
