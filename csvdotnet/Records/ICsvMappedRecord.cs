using System;
using System.Collections.Generic;

namespace CSVdotNET.Records
{
    public interface ICsvMappedRecord<T> : IDictionary<T, string> where T : struct, IConvertible
    {
    }
}