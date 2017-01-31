using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSVdotNET.Configuration;
using CSVdotNET.Records;

namespace CSVdotNET.Reader
{
    public class CsvReader : ICsvReader
    {
        protected StreamReader Reader;
        protected CsvConfiguration Config;
        private readonly LinkedList<string> _headers;
        private bool _isHeaderReaded;

        public CsvReader(Stream stream, CsvConfiguration config)
        {
            CurrentRecord = null;
            Config = new CsvConfiguration
            {
                HasHeaderRow = config.HasHeaderRow,
                Headers = config.Headers.ToArray(),
                Delimiter = config.Delimiter,
                TrimFields = config.TrimFields
            };
            if (Config.HasHeaderRow)
            {
                _isHeaderReaded = false;
                _headers = new LinkedList<string>();
            }
            else
            {
                _isHeaderReaded = true;
                _headers = new LinkedList<string>(Config.Headers);
            }
            Reader = new StreamReader(stream);
        }

        public IEnumerator<ICsvRecord> GetEnumerator()
        {
            while (Read())
            {
                yield return CurrentRecord;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            Reader.Dispose();
        }

        private bool Read()
        {
            if (!_isHeaderReaded)
            {
                ReadHeaderRow();
                _isHeaderReaded = true;
            }
            if (Reader.EndOfStream) return false;
            var fields = ReadRow();
            if (fields.Length != _headers.Count)
                throw new CsvReadingException("Invalid row. Fields are not accepts to headers");
            CurrentRecord = new CsvRecord();
            for (var i = 0; i < _headers.Count; i++)
            {
                CurrentRecord.Add(_headers.ElementAt(i), fields[i]);
            }
            return true;
        }

        private void ReadHeaderRow()
        {
            var fields = ReadRow();
            if (fields.Any(field => !Config.Headers.Contains(field)))
            {
                throw new CsvReadingException("Headers in config are not appropriate to a headers in file");
            }
            foreach (var field in fields)
            {
                _headers.AddLast(field);
            }
        }

        private string[] ReadRow()
        {
            var line = Reader.ReadLine();
            var fields = line.Split(new[] {Config.Delimiter}, StringSplitOptions.None);
            return Config.TrimFields ? fields.Select(s => s.Trim()).ToArray() : fields;
        }

        public ICsvRecord CurrentRecord { get; private set; }
    }
}