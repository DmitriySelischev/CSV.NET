using System;
using System.Collections.Generic;
using CSVdotNET.Records;

namespace CSVdotNET.Reader
{
    public interface ICsvMappedReader<T> : IEnumerable<ICsvMappedRecord<T>>, IDisposable where T: struct, IConvertible
    {
         ICsvMappedRecord<T> CurrentRecord { get; }
    }
}