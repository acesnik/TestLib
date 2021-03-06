﻿using System;

namespace TopDownProteomics.ProForma
{
    /// <summary>
    /// Base ProForma parsing exception.
    /// </summary>
    /// <seealso cref="Exception" />
    public class ProFormaParseException
        : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProFormaParseException"/> class.
        /// </summary>
        public ProFormaParseException()
            : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProFormaParseException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ProFormaParseException(string message)
            : base(message) { }
    }
}