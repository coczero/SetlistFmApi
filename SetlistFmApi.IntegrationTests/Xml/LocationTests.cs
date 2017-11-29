using RestSharp;

namespace SetlistFmApi.IntegrationTests.Xml
{
  public class LocationTests : LocationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Xml; }
        }
    }
}
