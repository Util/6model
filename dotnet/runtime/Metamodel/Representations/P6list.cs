﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rakudo.Runtime;

namespace Rakudo.Metamodel.Representations
{
    /// <summary>
    /// This is a very first cut at a list representation. Essentially,
    /// it just knows how to store a list of objects at the moment. At
    /// some point we need to define the way that it will handle compact
    /// arrays.
    /// </summary>
    public class P6list : Representation
    {
        internal class Instance : RakudoObject
        {
            /// <summary>
            /// Just use a .Net List at the moment, but an array would
            /// be more efficient in the long run (though give us more
            /// stuff to implement ourselves).
            /// </summary>
            public List<RakudoObject> Storage;
            public Instance(SharedTable STable)
            {
                this.STable = STable;
            }
        }

        /// <summary>
        /// Create a new type object.
        /// </summary>
        /// <param name="HOW"></param>
        /// <returns></returns>
        public override RakudoObject type_object_for(ThreadContext TC, RakudoObject MetaPackage)
        {
            var STable = new SharedTable();
            STable.HOW = MetaPackage;
            STable.REPR = this;
            STable.WHAT = new Instance(STable);
            return STable.WHAT;
        }

        /// <summary>
        /// Creates an instance of the type with the given type object.
        /// </summary>
        /// <param name="WHAT"></param>
        /// <returns></returns>
        public override RakudoObject instance_of(ThreadContext TC, RakudoObject WHAT)
        {
            var Object = new Instance(WHAT.STable);
            Object.Storage = new List<RakudoObject>();
            return Object;
        }

        /// <summary>
        /// Determines if the representation is defined or not.
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns></returns>
        public override bool defined(ThreadContext TC, RakudoObject Obj)
        {
            return ((Instance)Obj).Storage != null;
        }

        public override RakudoObject get_attribute(ThreadContext TC, RakudoObject Object, RakudoObject ClassHandle, string Name)
        {
            throw new NotImplementedException();
        }

        public override RakudoObject get_attribute_with_hint(ThreadContext TC, RakudoObject Object, RakudoObject ClassHandle, string Name, int Hint)
        {
            throw new NotImplementedException();
        }

        public override void bind_attribute(ThreadContext TC, RakudoObject Object, RakudoObject ClassHandle, string Name, RakudoObject Value)
        {
            throw new NotImplementedException();
        }

        public override void bind_attribute_with_hint(ThreadContext TC, RakudoObject Object, RakudoObject ClassHandle, string Name, int Hint, RakudoObject Value)
        {
            throw new NotImplementedException();
        }

        public override int hint_for(ThreadContext TC, RakudoObject ClassHandle, string Name)
        {
            throw new NotImplementedException();
        }

        public override void set_int(ThreadContext TC, RakudoObject Object, int Value)
        {
            throw new NotImplementedException();
        }

        public override int get_int(ThreadContext TC, RakudoObject Object)
        {
            throw new NotImplementedException();
        }

        public override void set_num(ThreadContext TC, RakudoObject Object, double Value)
        {
            throw new NotImplementedException();
        }

        public override double get_num(ThreadContext TC, RakudoObject Object)
        {
            throw new NotImplementedException();
        }

        public override void set_str(ThreadContext TC, RakudoObject Object, string Value)
        {
            throw new NotImplementedException();
        }

        public override string get_str(ThreadContext TC, RakudoObject Object)
        {
            throw new NotImplementedException();
        }
    }
}
