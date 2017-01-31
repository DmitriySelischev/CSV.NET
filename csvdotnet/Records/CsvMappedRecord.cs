using System;
using System.Collections.Generic;

namespace CSVdotNET.Records
{
    public class CsvMappedRecord<T> : Dictionary<T, string>, ICsvMappedRecord<T> where T: struct, IConvertible
    {
    }
}
