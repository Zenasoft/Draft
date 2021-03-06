﻿using System;
using System.Linq;

namespace Draft.Exceptions
{
    /// <summary>
    ///     Represents an error where the directory operation failed due to still present children.
    /// </summary>
    public class DirectoryNotEmptyException : EtcdException
    {

        /// <summary>
        ///     Initializes a new <see cref="DirectoryNotEmptyException" /> instance.
        /// </summary>
        public DirectoryNotEmptyException() {}

        /// <summary>
        ///     Initializes a new <see cref="DirectoryNotEmptyException" /> instance with a specified error message.
        /// </summary>
        public DirectoryNotEmptyException(string message) : base(message) {}

        /// <summary>
        ///     Indicates that this exception is due to the passed directory still containing children.
        /// </summary>
        public override bool IsDirectoryNotEmpty
        {
            get { return true; }
        }

    }
}
