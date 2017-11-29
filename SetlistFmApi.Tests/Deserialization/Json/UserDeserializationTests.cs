using RestSharp;

namespace SetlistFmApi.Tests.Deserialization.Json
{
  public class UserDeserializationTests : UserDeserializationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Json; }
        }
    }
}
