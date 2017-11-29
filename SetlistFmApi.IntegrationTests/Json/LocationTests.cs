using RestSharp;

namespace SetlistFmApi.IntegrationTests.Json
{
  public class LocationTests : LocationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Json; }
        }
    }
}
