using RestSharp;

namespace SetlistFmApi.Tests.Deserialization.Xml
{
  public class MusicDeserializationTests : MusicDeserializationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Xml; }
        }
    }
}
