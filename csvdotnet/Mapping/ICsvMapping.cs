using System;
using System.Collections.Generic;

namespace CSVdotNET.Mapping
{
    public interface ICsvMapping<T> where T : struct, IConvertible
    {
        LinkedList<KeyValuePair<T, string>> Mapping { get; }
    }
}