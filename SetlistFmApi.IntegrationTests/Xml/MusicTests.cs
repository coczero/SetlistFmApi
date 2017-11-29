using RestSharp;

namespace SetlistFmApi.IntegrationTests.Xml
{
  public class MusicTests : MusicTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Xml; }
        }
    }
}
