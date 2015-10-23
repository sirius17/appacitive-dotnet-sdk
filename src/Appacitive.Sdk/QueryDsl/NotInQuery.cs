﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appacitive.Sdk.Internal
{
    internal class NotInQuery : IQuery
    {
        public NotInQuery(Field field,  IEnumerable<string> values)
        {
            this.Values = values.Select(x => new PrimtiveFieldValue(x)).ToArray();
            this.Field = field;
        }

        public NotInQuery(Field field, IEnumerable<long> values)
        {
            this.Values = values.Select(x => new PrimtiveFieldValue(x)).ToArray();
            this.Field = field;
        }

        public override string ToString()
        {
            return this.AsString();
        }

        public string AsString()
        {
            return string.Format("{0} not in {1}",
                this.Field,
                string.Join(",", this.Values));
        }

        public PrimtiveFieldValue[] Values { get; private set; }

        public Field Field { get; set; }
    }
}
