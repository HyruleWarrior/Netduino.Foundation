using System;
using Microsoft.SPOT;

namespace Netduino.Foundation.Motors
{
    public interface IDCMotor
    {
        /// <summary>
        /// The speed of the motor from -1 to 1.
        /// </summary>
        float Speed { get; }

        /// <summary>
        /// When true, the wheels spin "freely"
        /// </summary>
        bool IsNeutral { get; set; }
    }
}
