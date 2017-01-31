namespace CSVdotNET.Configuration
{
    public class CsvConfiguration
    {
        public bool HasHeaderRow { get; set; }
        public string[] Headers { get; set; }
        public string Delimiter { get; set; }
        public bool TrimFields { get; set; }
    }
}
