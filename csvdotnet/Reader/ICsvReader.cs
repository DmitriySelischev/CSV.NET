using System;
using System.Collections.Generic;
using CSVdotNET.Records;

namespace CSVdotNET.Reader
{
    public interface ICsvReader : IEnumerable<ICsvRecord>, IDisposable
    {
         ICsvRecord CurrentRecord { get; }
    }
}