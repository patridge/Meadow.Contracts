﻿namespace Meadow.Hardware
{
    /// <summary>
    /// Whether the circuit is terminated into the common/ground or a high (3.3V) voltage
    /// source. Used to determine whether to pull the resistor wired to the switch
    /// sensor high or low to close the circuit when the switch is closed.
    /// 
    /// To disable the resistor, set to Floating.
    /// </summary>
    public enum TerminationType
    {
        /// <summary>
        /// Circuit is terminated at ground.
        /// </summary>
        CommonGround,
        /// <summary>
        /// The circuit is terminated at VCC.
        /// </summary>
        High,
        /// <summary>
        /// The circuit is not terminated.
        /// </summary>
        Floating
    }
}
