using CSVdotNET.Configuration;
using CSVdotNET.Reader;
using NUnit.Framework;

namespace csvdotnet.tests
{
    [TestFixture]
    public class CsvReaderTests
    {
        private CsvConfiguration _config;

        [SetUp]
        public void Initialize()
        {
            _config = new CsvConfiguration
            {
                HasHeaderRow = true,
                TrimFields = true,
                Delimiter = ",",
                Headers = new[] {"head1", "head2", "head3"}
            };
        }

        [Test]
        public void ShouldReadCsvDataCorrectly()
        {
            
        }
    }
}
