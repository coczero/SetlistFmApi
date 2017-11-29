using RestSharp;

namespace SetlistFmApi.IntegrationTests.Json
{
  public class MusicTests : MusicTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Json; }
        }
    }
}
