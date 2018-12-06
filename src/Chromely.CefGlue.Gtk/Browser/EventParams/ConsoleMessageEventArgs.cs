﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleMessageEventArgs.cs" company="Chromely Projects">
//   Copyright (c) 2017-2018 Chromely Projects
// </copyright>
// <license>
//      See the LICENSE.md file in the project root for more information.
// </license>
// --------------------------------------------------------------------------------------------------------------------

namespace Chromely.CefGlue.Gtk.Browser.EventParams
{
    using System;

    /// <summary>
    /// The console message event args.
    /// </summary>
    public class ConsoleMessageEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleMessageEventArgs"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <param name="line">
        /// The line.
        /// </param>
        public ConsoleMessageEventArgs(string message, string source, int line)
        {
            Message = message;
            Source = source;
            Line = line;
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Gets the line.
        /// </summary>
        public int Line { get; }

        /// <summary>
        /// Gets or sets a value indicating whether handled.
        /// </summary>
        public bool Handled { get; set; }
    }
}
