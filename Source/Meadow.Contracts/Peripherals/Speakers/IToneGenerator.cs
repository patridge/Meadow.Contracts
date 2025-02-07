﻿using Meadow.Units;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Speakers
{
    /// <summary>
    /// Audio tones generator that plays tones at a given frequency.
    /// </summary>
    public interface IToneGenerator
    {
        /// <summary>
        /// Plays the tone with a especified frequency and duration.
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="duration"></param>
        Task PlayTone(Frequency frequency, int duration = 0);

        /// <summary>
        /// Stops the tone playing.
        /// </summary>
        void StopTone();
    }
}