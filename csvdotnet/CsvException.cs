using System;

namespace CSVdotNET
{
    public class CsvException : Exception
    {
        protected CsvException(string message) : base(message)
        {
        }

        protected CsvException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
