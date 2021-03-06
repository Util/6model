﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rakudo.Metamodel;

namespace Rakudo.Runtime
{
    /// <summary>
    /// We have one of these per thread that we are running.
    /// </summary>
    public class ThreadContext
    {
        /// <summary>
        /// The execution domain that we're operating under.
        /// </summary>
        public ExecutionDomain Domain;

        /// <summary>
        /// The current context we're in.
        /// </summary>
        public Context CurrentContext;

        /// <summary>
        /// The type object of the bool type we box to.
        /// </summary>
        public RakudoObject DefaultBoolBoxType;

        /// <summary>
        /// The type object of the integer type we box to.
        /// </summary>
        public RakudoObject DefaultIntBoxType;

        /// <summary>
        /// The type object of the number type we box to.
        /// </summary>
        public RakudoObject DefaultNumBoxType;

        /// <summary>
        /// The type object of the string type we box to.
        /// </summary>
        public RakudoObject DefaultStrBoxType;

        /// <summary>
        /// The default list type.
        /// </summary>
        public RakudoObject DefaultListType;

        /// <summary>
        /// The default array type.
        /// </summary>
        public RakudoObject DefaultArrayType;

        /// <summary>
        /// The default hash type.
        /// </summary>
        public RakudoObject DefaultHashType;
    }
}
