using RestSharp;

namespace SetlistFmApi.Tests.Deserialization.Xml
{
  public class UserDeserializationTests : UserDeserializationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Xml; }
        }
    }
}
