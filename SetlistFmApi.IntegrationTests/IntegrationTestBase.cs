using RestSharp;

namespace SetlistFmApi.IntegrationTests
{
  public abstract class IntegrationTestBase
    {
        protected SetlistFmApi _client;

        public abstract DataFormat Format { get; }

        public IntegrationTestBase()
        {
            _client = new SetlistFmApi("23b3fd98-f5c7-49c6-a7d2-28498c0c2283");
            _client.Format = Format;
        }
    }
}
