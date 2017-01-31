using System;
using CSVdotNET.Mapping;

namespace CSVdotNET.Configuration
{
    public class CsvMappedConfiguration<T> : CsvConfiguration where T : struct, IConvertible
    {
        public ICsvMapping<T> Mapping { get; set; }
    }
}
