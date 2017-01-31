using System;

namespace CSVdotNET
{
    public class CsvWritingException : CsvException
    {
        public CsvWritingException(string message) : base(message)
        {
        }

        public CsvWritingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
