using RestSharp;

namespace SetlistFmApi.Tests.Deserialization.Json
{
  public class MusicDeserializationTests : MusicDeserializationTestsBase
    {
        public override DataFormat Format
        {
            get { return DataFormat.Json; }
        }        
    }
}
