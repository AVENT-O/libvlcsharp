﻿namespace LibVLCSharp.Shared.MediaPlayerElement
{
    /// <summary>
    /// Describes how content is resized to fill its allocated space
    /// </summary>
    public enum AspectRatio
    {
        /// <summary>
        /// Best fit
        /// </summary>
        BestFit,
        /// <summary>
        /// Fit screen
        /// </summary>
        FitScreen,
        /// <summary>
        /// Fill
        /// </summary>
        Fill,
        /// <summary>
        /// 16/9
        /// </summary>
        _16_9,
        /// <summary>
        /// 4/3
        /// </summary>
        _4_3,
        /// <summary>
        /// Original
        /// </summary>
        Original,
        /// <summary>
        /// x2
        /// </summary>
        _x2,
        /// <summary>
        /// x4
        /// </summary>
        _x4
    }
}
