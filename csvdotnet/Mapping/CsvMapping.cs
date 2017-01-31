using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVdotNET.Mapping
{
    public class CsvMapping<T> : ICsvMapping<T> where T: struct, IConvertible
    {
        public CsvMapping(ICollection<T> keys, ICollection<string> values)
        {
            if (keys.Count != values.Count)
                throw new ArgumentException("Keys does not appropriate to values");
            Mapping = new LinkedList<KeyValuePair<T, string>>();
            for (var i = 0; i < keys.Count && i<values.Count; i++)
            {
                Mapping.AddLast(new KeyValuePair<T, string>(keys.ElementAt(i), values.ElementAt(0)));
            }
        }

        public LinkedList<KeyValuePair<T, string>> Mapping { get; private set; }
    }
}
