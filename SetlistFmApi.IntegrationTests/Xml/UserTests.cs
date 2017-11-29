using RestSharp;

namespace SetlistFmApi.IntegrationTests.Xml
{
  public class UserTests : UserTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Xml; }
        }
    }
}
