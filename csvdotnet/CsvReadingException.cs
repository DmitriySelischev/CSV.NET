using System;

namespace CSVdotNET
{
    public class CsvReadingException : CsvException
    {
        public CsvReadingException(string message) : base(message)
        {
        }

        public CsvReadingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
