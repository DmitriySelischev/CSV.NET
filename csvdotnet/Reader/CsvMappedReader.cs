using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CSVdotNET.Configuration;
using CSVdotNET.Records;

namespace CSVdotNET.Reader
{
    //TODO
    public class CsvMappedReader<T> : ICsvMappedReader<T> where T : struct, IConvertible
    {
        public CsvMappedReader(Stream stream, CsvMappedConfiguration<T> config)
        {

        }

        public IEnumerator<ICsvMappedRecord<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICsvMappedRecord<T> CurrentRecord { get; private set; }
    }
}
