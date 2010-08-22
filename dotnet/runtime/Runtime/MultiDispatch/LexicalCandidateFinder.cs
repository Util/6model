﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rakudo.Metamodel;
using Rakudo.Metamodel.Representations;

namespace Rakudo.Runtime.MultiDispatch
{
    /// <summary>
    /// Finds all candidates that we may dispatch to.
    /// </summary>
    public static class LexicalCandidateFinder
    {
        /// <summary>
        /// Locates all matching candidates between the two scopes.
        /// </summary>
        /// <param name="FromScope"></param>
        /// <param name="ToScope"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static List<RakudoCodeRef.Instance> FindCandidates(Context CallerScope, Context ProtoScope, string CandidateHolderName)
        {
            var Result = new List<RakudoCodeRef.Instance>();
            Context CurScope = null;
            do
            {
                // Get the next outer scope, or alternatively start off with the
                // caller scope.
                CurScope = CurScope == null ? CallerScope : CurScope.Outer;

                // Any candidates here?


            } while (CurScope != ProtoScope);
            return Result;
        }
    }
}