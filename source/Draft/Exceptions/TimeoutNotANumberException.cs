﻿using System;
using System.Linq;

namespace Draft.Exceptions
{
    /// <summary>
    ///     Represents an error where etcd was unable to parse the passed timeout value into a number.
    /// </summary>
    public class TimeoutNotANumberException : EtcdException
    {

        /// <summary>
        ///     Initializes a new <see cref="TimeoutNotANumberException" /> instance.
        /// </summary>
        public TimeoutNotANumberException() {}

        /// <summary>
        ///     Initializes a new <see cref="TimeoutNotANumberException" /> instance with a specified error message.
        /// </summary>
        public TimeoutNotANumberException(string message) : base(message) {}

        /// <summary>
        ///     Indicates that this exception is due to the etcd being unable to parse the passed timeout value as a number.
        /// </summary>
        public override bool IsTimeoutNotANumber
        {
            get { return true; }
        }

    }
}
