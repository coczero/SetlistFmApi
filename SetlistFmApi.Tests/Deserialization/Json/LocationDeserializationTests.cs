using RestSharp;

namespace SetlistFmApi.Tests.Deserialization.Json
{
  public class LocationDeserializationTests : LocationDeserializationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Json; }
        }
    }
}
