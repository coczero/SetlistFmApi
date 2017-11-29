using RestSharp;

namespace SetlistFmApi.Tests.Deserialization.Xml
{
  public class LocationDeserializationTests : LocationDeserializationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Xml; }
        }
    }
}
