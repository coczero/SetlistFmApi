using RestSharp;

namespace SetlistFmApi.IntegrationTests.Json
{
  public class UserTests : UserTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Json; }
        }
    }
}
